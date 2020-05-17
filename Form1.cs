using System;
using System.Text;                       // для кодировки в том числе
//using System.Threading.Tasks;          
using System.Windows.Forms;
using System.Text.RegularExpressions;    // для использования регулярных выражений
using System.IO;                         // для работы с потоками и файлами

namespace Work_with_text_in_file
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            // для удобного выбора файлов:
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private string source_file_name = "";
        private void button_choose_file_Click(object sender, EventArgs e)
        {
            // открытие файла:
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл, сохраняем его полный путь:
            source_file_name = openFileDialog1.FileName;

            // показываем выбранный файл в форме:                    
            textBox_source_file_path.Text = System.IO.Path.GetFullPath(source_file_name);
            textBox_source_file_path.Visible = true;
        }

        private string result_file_name = "";
        private void button_create_result_file_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл, сохраняем его полный путь:
            result_file_name = saveFileDialog1.FileName;

            if (result_file_name == source_file_name)
                MessageBox.Show("Выберите файл, отличный от источника или создайте новый.\nЭто просто.");
            else
            {
                // показываем выбранный файл в форме:
                textBox_result_file.Text = System.IO.Path.GetFullPath(result_file_name);
                textBox_result_file.Visible = true;
                // и кнопку для запуска алгоритма обработки:
                button_execute.Visible = true;
            }
        }
        private void button_execute_Click(object sender, EventArgs e)
        {
            button_execute.Text = "Обрабатывается...";
            // ПРОЦЕДУРА ОБРАБОТКИ ТЕКСТА
            work_with_text();
        }

        // основной алгоритм обработки текста:
        private async void work_with_text()
        {
            uint delete_max = 0;  // будем удалять слова не длиннее этой переменной, получаем её от пользователя:
            try
            {
                if (textBox_word_length.Text != "")
                    delete_max = Convert.ToUInt32(textBox_word_length.Text);
            }
            catch
            {
                MessageBox.Show("Некорректное число в поле для количества букв!");
            }

            bool delete_punctuation = checkBox_delete_punctuation.Checked;

            // будем асинхронно построчно читать файл:
            using (StreamReader stream_read = new StreamReader(source_file_name, Encoding.UTF8)) // System.Text.Encoding.Default почему-то не срабоатала на кириллице
            {
                try
                {
                    // пытаемся создать поток для построчной записи:
                    using (StreamWriter stream_write = new StreamWriter(result_file_name, false, System.Text.Encoding.Default))  // false означает перезапись, а не дозапись
                    {
                        String line;                                                 // line - строка из потока для чтения, её и будем обрабатывать
                        while ((line = await stream_read.ReadLineAsync()) != null)   // пока строки не кончатся
                        {
                            if (delete_punctuation)
                               // используем регулярные выражения, чтобы удалить пунктуацию:
                            {
                                Regex punctuation = new Regex("([.,:;!?()]+)|([/-]+)");  // шаблон означает любой из перечисленных знаков пунктуации, встречающийся 1 и более раз, тире рассмотрено отдельно
                                string target = "";                                      // на что будем заменять неподходящее по шаблону - на пусто, то есть удаляем
                                line = punctuation.Replace(line, target);                // удаляем из считанной строки пунктуацию
                            }
                            if (delete_max > 0)                                          // иначе нечего удалять
                                delete_too_short_words(ref line, delete_max);
                            await stream_write.WriteLineAsync(line);                     // асинхронно записываем получившуюся строку в файл для результата
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то не так с файлом для результата, попробуйте выбрать другой файл!");
                }
            }
            button_execute.Text = "Выполнить обработку";
            MessageBox.Show("ВСЁ ПОЛУЧИЛОСЬ!\n\nРезультат обработки сохранён");
        }

        // следующая процедура удаляет из переданной строки слова длины до параметра max (включительно) 
        private void delete_too_short_words(ref string line, uint max)
        /* идея алгоритма: идём по строке, считаем символы слова, когда дошли до конца слова - возвращаем бегунок и удаляем слово.
        ...я бы хотела здесь тоже использовать замену с шаблоном регулярного выражения 
        например, так: Regex bad_word = new Regex(@"\b\w{1, max}\b");
        но в шаблон не получается передать переменную max */
        {
             int word_length = 0;     // длина очередного встреченного слова
             int i = 0;               // бегунок по строке
             while (i < line.Length)
             {
                // чтобы дальше не пересчитывать это несколько раз:
                bool is_separator = char.IsSeparator(line[i]);
                bool is_punctuation = char.IsPunctuation(line[i]);

                if (!is_separator && !is_punctuation)  // это должно быть буква или цифра - значит символ слова
                    ++word_length;

                bool do_not_iterate = false;           // нам понадобится этот флаг, т.к. не все следующие случаи одинаковые
                // иначе (если знак разделения или пунктуация) или последний символ слова в конце строки:
                if (is_separator || is_punctuation || (i == (line.Length - 1)))
                {
                     if (word_length <= max)
                     {
                        //  конец слова и строки одновременно:
                        if (!is_separator && !is_punctuation)
                        {
                            i = i + 1 - word_length;
                            do_not_iterate = true;   // так как на месте i и так новый знак, который надо рассматривать
                        }
                        else // текущий символ - пробел или знак пунктуации, слово уже позади:
                            i -= word_length;
                        line = line.Remove(i, word_length);
                     }
                     word_length = 0;  // как бы там ни было, слово кончилось и будем искать следующее
                }
                if (!do_not_iterate) 
                    ++i;
             }
        }
    }
}

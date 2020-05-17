namespace Work_with_text_in_file
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_execute = new System.Windows.Forms.Button();
            this.label_word_length = new System.Windows.Forms.Label();
            this.textBox_source_file_path = new System.Windows.Forms.TextBox();
            this.button_choose_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_what_to_do = new System.Windows.Forms.Label();
            this.textBox_word_length = new System.Windows.Forms.TextBox();
            this.checkBox_delete_punctuation = new System.Windows.Forms.CheckBox();
            this.textBox_result_file = new System.Windows.Forms.TextBox();
            this.button_create_result_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_execute
            // 
            this.button_execute.BackColor = System.Drawing.Color.LimeGreen;
            this.button_execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_execute.Location = new System.Drawing.Point(365, 212);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(210, 58);
            this.button_execute.TabIndex = 0;
            this.button_execute.Text = "Выполнить обработку";
            this.button_execute.UseVisualStyleBackColor = false;
            this.button_execute.Visible = false;
            this.button_execute.Click += new System.EventHandler(this.button_execute_Click);
            // 
            // label_word_length
            // 
            this.label_word_length.AutoSize = true;
            this.label_word_length.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_word_length.Location = new System.Drawing.Point(96, 108);
            this.label_word_length.Name = "label_word_length";
            this.label_word_length.Size = new System.Drawing.Size(412, 25);
            this.label_word_length.TabIndex = 1;
            this.label_word_length.Text = "- максимальная длина удаляемых слов";
            // 
            // textBox_source_file_path
            // 
            this.textBox_source_file_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_source_file_path.Location = new System.Drawing.Point(14, 61);
            this.textBox_source_file_path.Name = "textBox_source_file_path";
            this.textBox_source_file_path.Size = new System.Drawing.Size(561, 26);
            this.textBox_source_file_path.TabIndex = 2;
            this.textBox_source_file_path.Visible = false;
            // 
            // button_choose_file
            // 
            this.button_choose_file.BackColor = System.Drawing.Color.BurlyWood;
            this.button_choose_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_choose_file.Location = new System.Drawing.Point(14, 12);
            this.button_choose_file.Name = "button_choose_file";
            this.button_choose_file.Size = new System.Drawing.Size(312, 43);
            this.button_choose_file.TabIndex = 3;
            this.button_choose_file.Text = "Выбрать исходный файл";
            this.button_choose_file.UseVisualStyleBackColor = false;
            this.button_choose_file.Click += new System.EventHandler(this.button_choose_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_what_to_do
            // 
            this.label_what_to_do.AutoSize = true;
            this.label_what_to_do.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_what_to_do.Location = new System.Drawing.Point(12, 182);
            this.label_what_to_do.Name = "label_what_to_do";
            this.label_what_to_do.Size = new System.Drawing.Size(577, 25);
            this.label_what_to_do.TabIndex = 4;
            this.label_what_to_do.Text = "Создать или выбрать файл для сохранения результата:";
            // 
            // textBox_word_length
            // 
            this.textBox_word_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_word_length.Location = new System.Drawing.Point(17, 107);
            this.textBox_word_length.Name = "textBox_word_length";
            this.textBox_word_length.Size = new System.Drawing.Size(63, 26);
            this.textBox_word_length.TabIndex = 5;
            // 
            // checkBox_delete_punctuation
            // 
            this.checkBox_delete_punctuation.AutoSize = true;
            this.checkBox_delete_punctuation.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_delete_punctuation.Location = new System.Drawing.Point(17, 139);
            this.checkBox_delete_punctuation.Name = "checkBox_delete_punctuation";
            this.checkBox_delete_punctuation.Size = new System.Drawing.Size(309, 29);
            this.checkBox_delete_punctuation.TabIndex = 6;
            this.checkBox_delete_punctuation.Text = "удалять знаки препинания";
            this.checkBox_delete_punctuation.UseVisualStyleBackColor = true;
            // 
            // textBox_result_file
            // 
            this.textBox_result_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result_file.Location = new System.Drawing.Point(17, 278);
            this.textBox_result_file.Name = "textBox_result_file";
            this.textBox_result_file.Size = new System.Drawing.Size(558, 26);
            this.textBox_result_file.TabIndex = 7;
            this.textBox_result_file.Visible = false;
            // 
            // button_create_result_file
            // 
            this.button_create_result_file.BackColor = System.Drawing.Color.BurlyWood;
            this.button_create_result_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_result_file.Location = new System.Drawing.Point(17, 220);
            this.button_create_result_file.Name = "button_create_result_file";
            this.button_create_result_file.Size = new System.Drawing.Size(309, 43);
            this.button_create_result_file.TabIndex = 8;
            this.button_create_result_file.Text = "Выбрать файл для результата";
            this.button_create_result_file.UseVisualStyleBackColor = false;
            this.button_create_result_file.Click += new System.EventHandler(this.button_create_result_file_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(587, 317);
            this.Controls.Add(this.button_create_result_file);
            this.Controls.Add(this.textBox_result_file);
            this.Controls.Add(this.checkBox_delete_punctuation);
            this.Controls.Add(this.textBox_word_length);
            this.Controls.Add(this.label_what_to_do);
            this.Controls.Add(this.button_choose_file);
            this.Controls.Add(this.textBox_source_file_path);
            this.Controls.Add(this.label_word_length);
            this.Controls.Add(this.button_execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_execute;
        private System.Windows.Forms.Label label_word_length;
        private System.Windows.Forms.TextBox textBox_source_file_path;
        private System.Windows.Forms.Button button_choose_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label_what_to_do;
        private System.Windows.Forms.TextBox textBox_word_length;
        private System.Windows.Forms.CheckBox checkBox_delete_punctuation;
        private System.Windows.Forms.TextBox textBox_result_file;
        private System.Windows.Forms.Button button_create_result_file;
    }
}


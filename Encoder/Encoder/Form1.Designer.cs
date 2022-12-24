namespace Encoder
{
    partial class Form1
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
            this.Del_text_code = new System.Windows.Forms.Button();
            this.Text_input = new System.Windows.Forms.TextBox();
            this.GB = new System.Windows.Forms.GroupBox();
            this.Text_for_code = new System.Windows.Forms.Button();
            this.Code_for_text = new System.Windows.Forms.Button();
            this.Text_out = new System.Windows.Forms.TextBox();
            this.Del_text_original = new System.Windows.Forms.Button();
            this.Box_key = new System.Windows.Forms.TextBox();
            this.Creat_key = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sistem_button = new System.Windows.Forms.Button();
            this.Binar_code_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Del_key = new System.Windows.Forms.Button();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Del_text_code
            // 
            this.Del_text_code.Location = new System.Drawing.Point(812, 122);
            this.Del_text_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Del_text_code.Name = "Del_text_code";
            this.Del_text_code.Size = new System.Drawing.Size(266, 35);
            this.Del_text_code.TabIndex = 0;
            this.Del_text_code.Text = "Удалить";
            this.Del_text_code.UseVisualStyleBackColor = true;
            this.Del_text_code.Click += new System.EventHandler(this.Del_text_code_Click);
            // 
            // Text_input
            // 
            this.Text_input.Location = new System.Drawing.Point(9, 46);
            this.Text_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_input.Multiline = true;
            this.Text_input.Name = "Text_input";
            this.Text_input.Size = new System.Drawing.Size(482, 450);
            this.Text_input.TabIndex = 1;
            this.Text_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_input_KeyDown);
            // 
            // GB
            // 
            this.GB.Controls.Add(this.Text_for_code);
            this.GB.Controls.Add(this.Code_for_text);
            this.GB.Controls.Add(this.Text_out);
            this.GB.Controls.Add(this.Text_input);
            this.GB.Location = new System.Drawing.Point(18, 166);
            this.GB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB.Name = "GB";
            this.GB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB.Size = new System.Drawing.Size(1164, 508);
            this.GB.TabIndex = 2;
            this.GB.TabStop = false;
            // 
            // Text_for_code
            // 
            this.Text_for_code.Location = new System.Drawing.Point(526, 77);
            this.Text_for_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_for_code.Name = "Text_for_code";
            this.Text_for_code.Size = new System.Drawing.Size(112, 177);
            this.Text_for_code.TabIndex = 4;
            this.Text_for_code.Text = "Из текста в шифр";
            this.Text_for_code.UseVisualStyleBackColor = true;
            this.Text_for_code.Click += new System.EventHandler(this.Text_for_code_Click);
            // 
            // Code_for_text
            // 
            this.Code_for_text.Location = new System.Drawing.Point(526, 291);
            this.Code_for_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Code_for_text.Name = "Code_for_text";
            this.Code_for_text.Size = new System.Drawing.Size(112, 177);
            this.Code_for_text.TabIndex = 3;
            this.Code_for_text.Text = "Из шифра в текст";
            this.Code_for_text.UseVisualStyleBackColor = true;
            this.Code_for_text.Click += new System.EventHandler(this.Code_for_text_Click);
            // 
            // Text_out
            // 
            this.Text_out.Location = new System.Drawing.Point(670, 46);
            this.Text_out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_out.Multiline = true;
            this.Text_out.Name = "Text_out";
            this.Text_out.Size = new System.Drawing.Size(482, 450);
            this.Text_out.TabIndex = 2;
            // 
            // Del_text_original
            // 
            this.Del_text_original.Location = new System.Drawing.Point(210, 122);
            this.Del_text_original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Del_text_original.Name = "Del_text_original";
            this.Del_text_original.Size = new System.Drawing.Size(112, 35);
            this.Del_text_original.TabIndex = 3;
            this.Del_text_original.Text = "Удалить";
            this.Del_text_original.UseVisualStyleBackColor = true;
            this.Del_text_original.Click += new System.EventHandler(this.Del_text_original_Click);
            // 
            // Box_key
            // 
            this.Box_key.Location = new System.Drawing.Point(72, 20);
            this.Box_key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Box_key.Multiline = true;
            this.Box_key.Name = "Box_key";
            this.Box_key.Size = new System.Drawing.Size(319, 66);
            this.Box_key.TabIndex = 4;
            // 
            // Creat_key
            // 
            this.Creat_key.Location = new System.Drawing.Point(422, 20);
            this.Creat_key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Creat_key.Name = "Creat_key";
            this.Creat_key.Size = new System.Drawing.Size(112, 35);
            this.Creat_key.TabIndex = 5;
            this.Creat_key.Text = "Создать";
            this.Creat_key.UseVisualStyleBackColor = true;
            this.Creat_key.Click += new System.EventHandler(this.Creat_key_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ключ";
            // 
            // Sistem_button
            // 
            this.Sistem_button.Location = new System.Drawing.Point(812, 20);
            this.Sistem_button.Name = "Sistem_button";
            this.Sistem_button.Size = new System.Drawing.Size(266, 35);
            this.Sistem_button.TabIndex = 9;
            this.Sistem_button.Text = "Системная кнопка";
            this.Sistem_button.UseVisualStyleBackColor = true;
            this.Sistem_button.Click += new System.EventHandler(this.Sistem_button_Click);
            // 
            // Binar_code_text
            // 
            this.Binar_code_text.Location = new System.Drawing.Point(1288, 212);
            this.Binar_code_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Binar_code_text.Multiline = true;
            this.Binar_code_text.Name = "Binar_code_text";
            this.Binar_code_text.Size = new System.Drawing.Size(247, 450);
            this.Binar_code_text.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1284, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Двоичный код текста";
            // 
            // Del_key
            // 
            this.Del_key.Location = new System.Drawing.Point(544, 21);
            this.Del_key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Del_key.Name = "Del_key";
            this.Del_key.Size = new System.Drawing.Size(112, 35);
            this.Del_key.TabIndex = 12;
            this.Del_key.Text = "Удалить";
            this.Del_key.UseVisualStyleBackColor = true;
            this.Del_key.Click += new System.EventHandler(this.Del_key_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 685);
            this.Controls.Add(this.Del_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Binar_code_text);
            this.Controls.Add(this.Sistem_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Creat_key);
            this.Controls.Add(this.Box_key);
            this.Controls.Add(this.Del_text_original);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.Del_text_code);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "о";
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Del_text_code;
        private System.Windows.Forms.TextBox Text_input;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Button Text_for_code;
        private System.Windows.Forms.Button Code_for_text;
        private System.Windows.Forms.TextBox Text_out;
        private System.Windows.Forms.Button Del_text_original;
        private System.Windows.Forms.TextBox Box_key;
        private System.Windows.Forms.Button Creat_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sistem_button;
        private System.Windows.Forms.TextBox Binar_code_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Del_key;
    }
}


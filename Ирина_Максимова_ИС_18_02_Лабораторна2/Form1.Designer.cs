namespace Ирина_Максимова_ИС_18_02_Лабораторна2
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
            this.RASSCHITAT = new System.Windows.Forms.Button();
            this.Konvert2 = new System.Windows.Forms.ComboBox();
            this.Konvert1 = new System.Windows.Forms.ComboBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RASSCHITAT
            // 
            this.RASSCHITAT.Location = new System.Drawing.Point(329, 348);
            this.RASSCHITAT.Name = "RASSCHITAT";
            this.RASSCHITAT.Size = new System.Drawing.Size(143, 37);
            this.RASSCHITAT.TabIndex = 0;
            this.RASSCHITAT.Text = "Рассчитать";
            this.RASSCHITAT.UseVisualStyleBackColor = true;
            this.RASSCHITAT.Click += new System.EventHandler(this.RASSCHITAT_Click);
            // 
            // Konvert2
            // 
            this.Konvert2.FormattingEnabled = true;
            this.Konvert2.Items.AddRange(new object[] {
            "Квадратный Милиметр(ММ)",
            "Квадратный Сантиметр(СМ)",
            "Квадратный Дециметр(ДМ)",
            "Квадратный метр(М)",
            "Аршин(А)",
            "Гектар(ГА)",
            "Километр(КМ)"});
            this.Konvert2.Location = new System.Drawing.Point(560, 178);
            this.Konvert2.Name = "Konvert2";
            this.Konvert2.Size = new System.Drawing.Size(193, 21);
            this.Konvert2.TabIndex = 1;
            // 
            // Konvert1
            // 
            this.Konvert1.FormattingEnabled = true;
            this.Konvert1.Items.AddRange(new object[] {
            "Квадратный Милиметр(ММ)",
            "Квадратный Сантиметр(СМ)",
            "Квадратный Дециметр(ДМ)",
            "Квадратный метр(М)",
            "Аршин(А)",
            "Гектар(ГА)",
            "Километр(КМ)"});
            this.Konvert1.Location = new System.Drawing.Point(287, 178);
            this.Konvert1.Name = "Konvert1";
            this.Konvert1.Size = new System.Drawing.Size(185, 21);
            this.Konvert1.TabIndex = 2;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(99, 178);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 20);
            this.Number.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Konvert1);
            this.Controls.Add(this.Konvert2);
            this.Controls.Add(this.RASSCHITAT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RASSCHITAT;
        private System.Windows.Forms.ComboBox Konvert2;
        private System.Windows.Forms.ComboBox Konvert1;
        private System.Windows.Forms.TextBox Number;
    }
}


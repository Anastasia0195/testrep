namespace Testing
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.firstRadio = new System.Windows.Forms.RadioButton();
            this.secondRadio = new System.Windows.Forms.RadioButton();
            this.thirdRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(35, 29);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(0, 13);
            this.QuestionLabel.TabIndex = 0;
            // 
            // firstRadio
            // 
            this.firstRadio.AutoSize = true;
            this.firstRadio.Location = new System.Drawing.Point(24, 81);
            this.firstRadio.Name = "firstRadio";
            this.firstRadio.Size = new System.Drawing.Size(14, 13);
            this.firstRadio.TabIndex = 1;
            this.firstRadio.TabStop = true;
            this.firstRadio.UseVisualStyleBackColor = true;
            // 
            // secondRadio
            // 
            this.secondRadio.AutoSize = true;
            this.secondRadio.Location = new System.Drawing.Point(24, 120);
            this.secondRadio.Name = "secondRadio";
            this.secondRadio.Size = new System.Drawing.Size(14, 13);
            this.secondRadio.TabIndex = 2;
            this.secondRadio.TabStop = true;
            this.secondRadio.UseVisualStyleBackColor = true;
            // 
            // thirdRadio
            // 
            this.thirdRadio.AutoSize = true;
            this.thirdRadio.Location = new System.Drawing.Point(24, 155);
            this.thirdRadio.Name = "thirdRadio";
            this.thirdRadio.Size = new System.Drawing.Size(14, 13);
            this.thirdRadio.TabIndex = 3;
            this.thirdRadio.TabStop = true;
            this.thirdRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thirdRadio);
            this.Controls.Add(this.secondRadio);
            this.Controls.Add(this.firstRadio);
            this.Controls.Add(this.QuestionLabel);
            this.MaximumSize = new System.Drawing.Size(900, 279);
            this.MinimumSize = new System.Drawing.Size(16, 279);
            this.Name = "Form1";
            this.Text = "Тестик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton firstRadio;
        private System.Windows.Forms.RadioButton secondRadio;
        private System.Windows.Forms.RadioButton thirdRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


namespace SummerPractice
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
            this.paintButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(12, 74);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(95, 44);
            this.paintButton.TabIndex = 0;
            this.paintButton.Text = "Paint";
            this.paintButton.UseVisualStyleBackColor = true;
            this.paintButton.Click += new System.EventHandler(this.paintButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "y = ";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(57, 24);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(212, 26);
            this.input.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 530);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paintButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paintButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
    }
}


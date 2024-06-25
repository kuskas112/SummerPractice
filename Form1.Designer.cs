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
            this.gapTextBox = new System.Windows.Forms.TextBox();
            this.gapLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xAbsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(12, 241);
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
            this.input.Location = new System.Drawing.Point(61, 24);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(212, 26);
            this.input.TabIndex = 2;
            this.input.Text = "x*x";
            // 
            // gapTextBox
            // 
            this.gapTextBox.Location = new System.Drawing.Point(61, 98);
            this.gapTextBox.Name = "gapTextBox";
            this.gapTextBox.Size = new System.Drawing.Size(64, 26);
            this.gapTextBox.TabIndex = 3;
            this.gapTextBox.Text = "1";
            // 
            // gapLabel
            // 
            this.gapLabel.AutoSize = true;
            this.gapLabel.Location = new System.Drawing.Point(17, 101);
            this.gapLabel.Name = "gapLabel";
            this.gapLabel.Size = new System.Drawing.Size(38, 20);
            this.gapLabel.TabIndex = 4;
            this.gapLabel.Text = "Шаг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "|x| <";
            // 
            // xAbsTextBox
            // 
            this.xAbsTextBox.Location = new System.Drawing.Point(62, 60);
            this.xAbsTextBox.Name = "xAbsTextBox";
            this.xAbsTextBox.Size = new System.Drawing.Size(64, 26);
            this.xAbsTextBox.TabIndex = 6;
            this.xAbsTextBox.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пикселей в единичном отрезке";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(21, 161);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(64, 26);
            this.scaleTextBox.TabIndex = 8;
            this.scaleTextBox.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 530);
            this.Controls.Add(this.scaleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xAbsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gapLabel);
            this.Controls.Add(this.gapTextBox);
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
        private System.Windows.Forms.TextBox gapTextBox;
        private System.Windows.Forms.Label gapLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xAbsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scaleTextBox;
    }
}


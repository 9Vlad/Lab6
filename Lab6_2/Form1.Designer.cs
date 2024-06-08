namespace Lab6_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbX1 = new TextBox();
            tbX2 = new TextBox();
            tbY = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label4 = new Label();
            tbY2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 59);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Змінна X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 123);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Змінна X2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 228);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 2;
            label3.Text = "Результат розрахунку Y";
            // 
            // tbX1
            // 
            tbX1.Location = new Point(221, 61);
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(125, 23);
            tbX1.TabIndex = 3;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(221, 123);
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(125, 23);
            tbX2.TabIndex = 4;
            // 
            // tbY
            // 
            tbY.Location = new Point(221, 230);
            tbY.Name = "tbY";
            tbY.ReadOnly = true;
            tbY.Size = new Size(125, 23);
            tbY.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(17, 387);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 35);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(139, 387);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(272, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 34);
            btnExit.TabIndex = 8;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 315);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 9;
            label4.Text = "Менше із значень X";
            // 
            // tbY2
            // 
            tbY2.Location = new Point(221, 315);
            tbY2.Name = "tbY2";
            tbY2.ReadOnly = true;
            tbY2.Size = new Size(125, 23);
            tbY2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 444);
            Controls.Add(tbY2);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(tbY);
            Controls.Add(tbX2);
            Controls.Add(tbX1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbY;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label4;
        private TextBox tbY2;
    }
}
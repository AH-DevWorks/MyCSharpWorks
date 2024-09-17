namespace Login
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
            bt1 = new Button();
            bt2End = new Button();
            label1 = new Label();
            label2 = new Label();
            bx1Password = new TextBox();
            bx2Money = new TextBox();
            bt3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            bt1.ForeColor = Color.DimGray;
            bt1.Location = new Point(119, 133);
            bt1.Name = "bt1";
            bt1.Size = new Size(79, 30);
            bt1.TabIndex = 0;
            bt1.Text = "確認提款";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click_1;
            // 
            // bt2End
            // 
            bt2End.FlatStyle = FlatStyle.Popup;
            bt2End.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            bt2End.Location = new Point(223, 133);
            bt2End.Name = "bt2End";
            bt2End.Size = new Size(79, 30);
            bt2End.TabIndex = 1;
            bt2End.Text = "結束";
            bt2End.UseVisualStyleBackColor = true;
            bt2End.Click += bt2End_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 12.0542984F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 22);
            label1.TabIndex = 2;
            label1.Text = "請輸入密碼：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 12.0542984F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(16, 59);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 22);
            label2.TabIndex = 3;
            label2.Text = "請輸入提款金額：";
            // 
            // bx1Password
            // 
            bx1Password.Font = new Font("微軟正黑體", 12.0542984F, FontStyle.Regular, GraphicsUnit.Point, 136);
            bx1Password.Location = new Point(152, 14);
            bx1Password.Margin = new Padding(1, 1, 1, 1);
            bx1Password.Name = "bx1Password";
            bx1Password.Size = new Size(152, 29);
            bx1Password.TabIndex = 4;
            bx1Password.KeyPress += bx1Password_KeyPress;
            // 
            // bx2Money
            // 
            bx2Money.Font = new Font("微軟正黑體", 12.0542984F, FontStyle.Regular, GraphicsUnit.Point, 136);
            bx2Money.ForeColor = Color.Gray;
            bx2Money.Location = new Point(152, 55);
            bx2Money.Margin = new Padding(1, 1, 1, 1);
            bx2Money.Name = "bx2Money";
            bx2Money.Size = new Size(152, 29);
            bx2Money.TabIndex = 5;
            bx2Money.Text = "NT$0";
            bx2Money.TextChanged += bx2Money_TextChanged_1;
            bx2Money.KeyPress += bx2Money_KeyPress;
            // 
            // bt3
            // 
            bt3.FlatStyle = FlatStyle.Popup;
            bt3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            bt3.Location = new Point(16, 133);
            bt3.Name = "bt3";
            bt3.Size = new Size(79, 30);
            bt3.TabIndex = 6;
            bt3.Text = "驗證密碼";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("微軟正黑體", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(152, 95);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 7;
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 199);
            Controls.Add(label3);
            Controls.Add(bt3);
            Controls.Add(bx2Money);
            Controls.Add(bx1Password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt2End);
            Controls.Add(bt1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt1;
        private Button bt2End;
        private Label label1;
        private Label label2;
        private TextBox bx1Password;
        private TextBox bx2Money;
        private Button bt3;
        private Label label3;
    }
}

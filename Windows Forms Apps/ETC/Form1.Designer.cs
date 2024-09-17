namespace etc
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("源雲明體 SB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 33);
            label1.TabIndex = 0;
            label1.Text = "請輸入里程數（小數點後1位）";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 53);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(200, 53);
            button1.Name = "button1";
            button1.Size = new Size(80, 27);
            button1.TabIndex = 2;
            button1.Text = "計算金額";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("源雲明體 SB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(268, 28);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 136);
            label3.Location = new Point(57, 141);
            label3.Name = "label3";
            label3.Size = new Size(223, 14);
            label3.TabIndex = 5;
            label3.Text = "*行駛200km以上，超出部分再享75折優惠。";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 163);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(24, 24, 24);
            Name = "Form1";
            Text = "ETC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}

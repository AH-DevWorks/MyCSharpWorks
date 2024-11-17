namespace BikeRentCalc
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
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("凝書體 3.1 Regular", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(29, 22);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(589, 51);
            label1.TabIndex = 0;
            label1.Text = "請輸入本次租用時間 (分鐘)：";
            // 
            // label2
            // 
            label2.BackColor = Color.Gainsboro;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("凝書體 3.1 Regular", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 274);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(838, 86);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 139);
            textBox1.Margin = new Padding(7, 7, 7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(580, 51);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(653, 139);
            button1.Margin = new Padding(7, 7, 7, 7);
            button1.Name = "button1";
            button1.Size = new Size(214, 62);
            button1.TabIndex = 3;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 136);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(437, 391);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(409, 36);
            label3.TabIndex = 4;
            label3.Text = "共享單車月～前30分鐘免費～";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(899, 446);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(7, 7, 7, 7);
            Name = "Form1";
            Text = "RentCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
    }
}

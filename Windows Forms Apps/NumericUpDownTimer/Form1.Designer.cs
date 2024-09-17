namespace NumericUpDownTimer
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
            components = new System.ComponentModel.Container();
            label1BigNum = new Label();
            numericUpDown1 = new NumericUpDown();
            label2Fixed = new Label();
            checkBox1 = new CheckBox();
            button1Start = new Button();
            label3Fixed2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1BigNum
            // 
            label1BigNum.Anchor = AnchorStyles.None;
            label1BigNum.BackColor = Color.FromArgb(255, 255, 192);
            label1BigNum.BorderStyle = BorderStyle.Fixed3D;
            label1BigNum.Font = new Font("Century Gothic", 36.1628952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1BigNum.ForeColor = Color.Navy;
            label1BigNum.Location = new Point(12, 9);
            label1BigNum.Name = "label1BigNum";
            label1BigNum.Size = new Size(245, 255);
            label1BigNum.TabIndex = 0;
            label1BigNum.Text = "000";
            label1BigNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Microsoft JhengHei UI", 11.0769234F);
            numericUpDown1.Location = new Point(393, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(149, 51);
            numericUpDown1.TabIndex = 1;
            // 
            // label2Fixed
            // 
            label2Fixed.AutoSize = true;
            label2Fixed.Font = new Font("Microsoft JhengHei UI", 12.0542984F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2Fixed.Location = new Point(259, 35);
            label2Fixed.Name = "label2Fixed";
            label2Fixed.Size = new Size(131, 47);
            label2Fixed.TabIndex = 2;
            label2Fixed.Text = "倒數：";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft JhengHei UI", 9.122172F, FontStyle.Regular, GraphicsUnit.Point, 136);
            checkBox1.Location = new Point(346, 131);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(196, 41);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "設定到秒(s)";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1Start
            // 
            button1Start.Font = new Font("Microsoft JhengHei UI", 11.0769234F);
            button1Start.Location = new Point(369, 211);
            button1Start.Name = "button1Start";
            button1Start.Size = new Size(173, 53);
            button1Start.TabIndex = 4;
            button1Start.Text = "開始倒數";
            button1Start.UseVisualStyleBackColor = true;
            button1Start.Click += button1Start_Click;
            // 
            // label3Fixed2
            // 
            label3Fixed2.AutoSize = true;
            label3Fixed2.Font = new Font("Microsoft JhengHei UI", 6.841629F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3Fixed2.Location = new Point(263, 91);
            label3Fixed2.Name = "label3Fixed2";
            label3Fixed2.Size = new Size(105, 26);
            label3Fixed2.TabIndex = 5;
            label3Fixed2.Text = "(分鐘min)";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 293);
            Controls.Add(label3Fixed2);
            Controls.Add(button1Start);
            Controls.Add(checkBox1);
            Controls.Add(label2Fixed);
            Controls.Add(numericUpDown1);
            Controls.Add(label1BigNum);
            Name = "Form1";
            Text = "Timer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1BigNum;
        private NumericUpDown numericUpDown1;
        private Label label2Fixed;
        private CheckBox checkBox1;
        private Button button1Start;
        private Label label3Fixed2;
        private System.Windows.Forms.Timer timer1;
    }
}

namespace BMICalc
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
            groupBox1 = new GroupBox();
            rBt2Female = new RadioButton();
            rBt1Male = new RadioButton();
            lb3Gender = new Label();
            groupBox2 = new GroupBox();
            txBoxWeight = new TextBox();
            txBoxHeight = new TextBox();
            lb2Weight = new Label();
            lb1Height = new Label();
            button1 = new Button();
            lb4BMIShow = new Label();
            lb5BMIRange = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBt2Female);
            groupBox1.Controls.Add(rBt1Male);
            groupBox1.Controls.Add(lb3Gender);
            groupBox1.Location = new Point(183, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rBt2Female
            // 
            rBt2Female.AutoSize = true;
            rBt2Female.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            rBt2Female.Location = new Point(84, 53);
            rBt2Female.Name = "rBt2Female";
            rBt2Female.Size = new Size(50, 21);
            rBt2Female.TabIndex = 2;
            rBt2Female.Text = "&2 女";
            rBt2Female.TextAlign = ContentAlignment.MiddleCenter;
            rBt2Female.UseVisualStyleBackColor = true;
            // 
            // rBt1Male
            // 
            rBt1Male.AutoSize = true;
            rBt1Male.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            rBt1Male.Location = new Point(15, 53);
            rBt1Male.Name = "rBt1Male";
            rBt1Male.Size = new Size(50, 21);
            rBt1Male.TabIndex = 1;
            rBt1Male.Text = "&1 男";
            rBt1Male.TextAlign = ContentAlignment.MiddleCenter;
            rBt1Male.UseVisualStyleBackColor = true;
            // 
            // lb3Gender
            // 
            lb3Gender.AutoSize = true;
            lb3Gender.Font = new Font("思源黑體 Medium", 11.249999F);
            lb3Gender.Location = new Point(6, 19);
            lb3Gender.Name = "lb3Gender";
            lb3Gender.Size = new Size(115, 22);
            lb3Gender.TabIndex = 0;
            lb3Gender.Text = "您的生理性別：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txBoxWeight);
            groupBox2.Controls.Add(txBoxHeight);
            groupBox2.Controls.Add(lb2Weight);
            groupBox2.Controls.Add(lb1Height);
            groupBox2.Location = new Point(12, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 162);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txBoxWeight
            // 
            txBoxWeight.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txBoxWeight.Location = new Point(10, 122);
            txBoxWeight.MaxLength = 6;
            txBoxWeight.Name = "txBoxWeight";
            txBoxWeight.Size = new Size(133, 23);
            txBoxWeight.TabIndex = 5;
            txBoxWeight.TextAlign = HorizontalAlignment.Right;
            txBoxWeight.TextChanged += txBoxWeight_TextChanged;
            txBoxWeight.KeyPress += PressEnter;
            // 
            // txBoxHeight
            // 
            txBoxHeight.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txBoxHeight.Location = new Point(10, 50);
            txBoxHeight.MaxLength = 6;
            txBoxHeight.Name = "txBoxHeight";
            txBoxHeight.Size = new Size(133, 23);
            txBoxHeight.TabIndex = 4;
            txBoxHeight.TextAlign = HorizontalAlignment.Right;
            txBoxHeight.TextChanged += txBoxHeight_TextChanged;
            txBoxHeight.KeyPress += PressEnter;
            // 
            // lb2Weight
            // 
            lb2Weight.AutoSize = true;
            lb2Weight.Font = new Font("思源黑體 Medium", 11.249999F);
            lb2Weight.Location = new Point(6, 92);
            lb2Weight.Name = "lb2Weight";
            lb2Weight.Size = new Size(128, 22);
            lb2Weight.TabIndex = 3;
            lb2Weight.Text = "您的體重 (公斤)：";
            // 
            // lb1Height
            // 
            lb1Height.AutoSize = true;
            lb1Height.Font = new Font("思源黑體 Medium", 11.249999F);
            lb1Height.Location = new Point(6, 19);
            lb1Height.Name = "lb1Height";
            lb1Height.Size = new Size(128, 22);
            lb1Height.TabIndex = 2;
            lb1Height.Text = "您的身高 (公分)：";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(262, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 2;
            button1.Text = "計算BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb4BMIShow
            // 
            lb4BMIShow.BackColor = Color.FromArgb(224, 224, 224);
            lb4BMIShow.BorderStyle = BorderStyle.Fixed3D;
            lb4BMIShow.Font = new Font("思源黑體 Medium", 10.5F);
            lb4BMIShow.Location = new Point(183, 103);
            lb4BMIShow.Name = "lb4BMIShow";
            lb4BMIShow.Size = new Size(154, 30);
            lb4BMIShow.TabIndex = 3;
            lb4BMIShow.Text = "　";
            lb4BMIShow.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb5BMIRange
            // 
            lb5BMIRange.BackColor = Color.FromArgb(224, 224, 224);
            lb5BMIRange.BorderStyle = BorderStyle.Fixed3D;
            lb5BMIRange.Font = new Font("思源黑體 Medium", 10.5F);
            lb5BMIRange.Location = new Point(183, 139);
            lb5BMIRange.Name = "lb5BMIRange";
            lb5BMIRange.Size = new Size(59, 32);
            lb5BMIRange.TabIndex = 4;
            lb5BMIRange.Text = "　";
            lb5BMIRange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 192);
            Controls.Add(lb5BMIRange);
            Controls.Add(lb4BMIShow);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BMI Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton rBt1Male;
        private Label lb3Gender;
        private RadioButton rBt2Female;
        private GroupBox groupBox2;
        private Label lb1Height;
        private Label lb2Weight;
        private TextBox txBoxHeight;
        private TextBox txBoxWeight;
        private Button button1;
        private Label lb4BMIShow;
        private Label lb5BMIRange;
    }
}

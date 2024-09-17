namespace RaamenOrder
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
            gpBox1Size = new GroupBox();
            rBt3Small = new RadioButton();
            rBt2Standard = new RadioButton();
            rBt1Big = new RadioButton();
            gpBox2Soup = new GroupBox();
            rBt4VaryThick = new RadioButton();
            rBt7Bland = new RadioButton();
            rBt6Normal = new RadioButton();
            rBt5Thick = new RadioButton();
            gpBox3Noodle = new GroupBox();
            rBt10Soft = new RadioButton();
            rBt9NormalN = new RadioButton();
            rBt8Hard = new RadioButton();
            panel1Bonus = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            gpBox1Size.SuspendLayout();
            gpBox2Soup.SuspendLayout();
            gpBox3Noodle.SuspendLayout();
            panel1Bonus.SuspendLayout();
            SuspendLayout();
            // 
            // gpBox1Size
            // 
            gpBox1Size.Controls.Add(rBt3Small);
            gpBox1Size.Controls.Add(rBt2Standard);
            gpBox1Size.Controls.Add(rBt1Big);
            gpBox1Size.Font = new Font("源雲明體 SB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            gpBox1Size.Location = new Point(10, 16);
            gpBox1Size.Name = "gpBox1Size";
            gpBox1Size.Size = new Size(368, 72);
            gpBox1Size.TabIndex = 0;
            gpBox1Size.TabStop = false;
            gpBox1Size.Text = "份量";
            // 
            // rBt3Small
            // 
            rBt3Small.AutoSize = true;
            rBt3Small.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt3Small.Location = new Point(252, 34);
            rBt3Small.Name = "rBt3Small";
            rBt3Small.Size = new Size(111, 18);
            rBt3Small.TabIndex = 2;
            rBt3Small.TabStop = true;
            rBt3Small.Text = "迷你碗 (270元)";
            rBt3Small.UseVisualStyleBackColor = true;
            rBt3Small.CheckedChanged += rBt3Small_CheckedChanged;
            // 
            // rBt2Standard
            // 
            rBt2Standard.AutoSize = true;
            rBt2Standard.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt2Standard.Location = new Point(137, 34);
            rBt2Standard.Name = "rBt2Standard";
            rBt2Standard.Size = new Size(98, 18);
            rBt2Standard.TabIndex = 1;
            rBt2Standard.TabStop = true;
            rBt2Standard.Text = "中碗 (310元)";
            rBt2Standard.UseVisualStyleBackColor = true;
            rBt2Standard.CheckedChanged += rBt2Standard_CheckedChanged;
            // 
            // rBt1Big
            // 
            rBt1Big.AutoSize = true;
            rBt1Big.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt1Big.Location = new Point(10, 34);
            rBt1Big.Name = "rBt1Big";
            rBt1Big.Size = new Size(111, 18);
            rBt1Big.TabIndex = 0;
            rBt1Big.TabStop = true;
            rBt1Big.Text = "超值碗 (390元)";
            rBt1Big.UseVisualStyleBackColor = true;
            rBt1Big.CheckedChanged += rBt1Big_CheckedChanged;
            // 
            // gpBox2Soup
            // 
            gpBox2Soup.Controls.Add(rBt4VaryThick);
            gpBox2Soup.Controls.Add(rBt7Bland);
            gpBox2Soup.Controls.Add(rBt6Normal);
            gpBox2Soup.Controls.Add(rBt5Thick);
            gpBox2Soup.Enabled = false;
            gpBox2Soup.Font = new Font("源雲明體 SB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            gpBox2Soup.Location = new Point(10, 102);
            gpBox2Soup.Name = "gpBox2Soup";
            gpBox2Soup.Size = new Size(299, 72);
            gpBox2Soup.TabIndex = 3;
            gpBox2Soup.TabStop = false;
            gpBox2Soup.Text = "湯頭濃淡";
            // 
            // rBt4VaryThick
            // 
            rBt4VaryThick.AutoSize = true;
            rBt4VaryThick.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt4VaryThick.Location = new Point(10, 34);
            rBt4VaryThick.Name = "rBt4VaryThick";
            rBt4VaryThick.Size = new Size(92, 18);
            rBt4VaryThick.TabIndex = 3;
            rBt4VaryThick.TabStop = true;
            rBt4VaryThick.Text = "超濃 (+5元)";
            rBt4VaryThick.UseVisualStyleBackColor = true;
            // 
            // rBt7Bland
            // 
            rBt7Bland.AutoSize = true;
            rBt7Bland.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt7Bland.Location = new Point(242, 34);
            rBt7Bland.Name = "rBt7Bland";
            rBt7Bland.Size = new Size(51, 18);
            rBt7Bland.TabIndex = 2;
            rBt7Bland.TabStop = true;
            rBt7Bland.Text = "偏淡";
            rBt7Bland.UseVisualStyleBackColor = true;
            // 
            // rBt6Normal
            // 
            rBt6Normal.AutoSize = true;
            rBt6Normal.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt6Normal.Location = new Point(181, 34);
            rBt6Normal.Name = "rBt6Normal";
            rBt6Normal.Size = new Size(51, 18);
            rBt6Normal.TabIndex = 1;
            rBt6Normal.TabStop = true;
            rBt6Normal.Text = "正常";
            rBt6Normal.UseVisualStyleBackColor = true;
            // 
            // rBt5Thick
            // 
            rBt5Thick.AutoSize = true;
            rBt5Thick.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt5Thick.Location = new Point(116, 34);
            rBt5Thick.Name = "rBt5Thick";
            rBt5Thick.Size = new Size(51, 18);
            rBt5Thick.TabIndex = 0;
            rBt5Thick.TabStop = true;
            rBt5Thick.Text = "特濃";
            rBt5Thick.UseVisualStyleBackColor = true;
            // 
            // gpBox3Noodle
            // 
            gpBox3Noodle.Controls.Add(rBt10Soft);
            gpBox3Noodle.Controls.Add(rBt9NormalN);
            gpBox3Noodle.Controls.Add(rBt8Hard);
            gpBox3Noodle.Enabled = false;
            gpBox3Noodle.Font = new Font("源雲明體 SB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            gpBox3Noodle.Location = new Point(10, 186);
            gpBox3Noodle.Name = "gpBox3Noodle";
            gpBox3Noodle.Size = new Size(185, 72);
            gpBox3Noodle.TabIndex = 4;
            gpBox3Noodle.TabStop = false;
            gpBox3Noodle.Text = "麵條軟硬";
            // 
            // rBt10Soft
            // 
            rBt10Soft.AutoSize = true;
            rBt10Soft.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt10Soft.Location = new Point(137, 34);
            rBt10Soft.Name = "rBt10Soft";
            rBt10Soft.Size = new Size(38, 18);
            rBt10Soft.TabIndex = 2;
            rBt10Soft.TabStop = true;
            rBt10Soft.Text = "軟";
            rBt10Soft.UseVisualStyleBackColor = true;
            // 
            // rBt9NormalN
            // 
            rBt9NormalN.AutoSize = true;
            rBt9NormalN.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt9NormalN.Location = new Point(70, 34);
            rBt9NormalN.Name = "rBt9NormalN";
            rBt9NormalN.Size = new Size(51, 18);
            rBt9NormalN.TabIndex = 1;
            rBt9NormalN.TabStop = true;
            rBt9NormalN.Text = "普通";
            rBt9NormalN.UseVisualStyleBackColor = true;
            // 
            // rBt8Hard
            // 
            rBt8Hard.AutoSize = true;
            rBt8Hard.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 136);
            rBt8Hard.Location = new Point(10, 34);
            rBt8Hard.Name = "rBt8Hard";
            rBt8Hard.Size = new Size(38, 18);
            rBt8Hard.TabIndex = 0;
            rBt8Hard.TabStop = true;
            rBt8Hard.Text = "硬";
            rBt8Hard.UseVisualStyleBackColor = true;
            // 
            // panel1Bonus
            // 
            panel1Bonus.AutoScroll = true;
            panel1Bonus.Controls.Add(checkBox2);
            panel1Bonus.Controls.Add(checkBox1);
            panel1Bonus.Enabled = false;
            panel1Bonus.Location = new Point(201, 200);
            panel1Bonus.Name = "panel1Bonus";
            panel1Bonus.Size = new Size(181, 58);
            panel1Bonus.TabIndex = 5;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 33);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(132, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "+黯然叉燒飯 (70元)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 8);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "+水逆唐揚雞 (60元)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("凝書體 3.1 Regular", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(272, 282);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 6;
            button1.Text = "確認訂單";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 337);
            Controls.Add(button1);
            Controls.Add(panel1Bonus);
            Controls.Add(gpBox3Noodle);
            Controls.Add(gpBox2Soup);
            Controls.Add(gpBox1Size);
            Name = "Form1";
            Text = "～匠人．脂肪肝拉麵～點餐系統";
            gpBox1Size.ResumeLayout(false);
            gpBox1Size.PerformLayout();
            gpBox2Soup.ResumeLayout(false);
            gpBox2Soup.PerformLayout();
            gpBox3Noodle.ResumeLayout(false);
            gpBox3Noodle.PerformLayout();
            panel1Bonus.ResumeLayout(false);
            panel1Bonus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpBox1Size;
        private RadioButton rBt2Standard;
        private RadioButton rBt1Big;
        private RadioButton rBt3Small;
        private GroupBox gpBox2Soup;
        private RadioButton rBt7Bland;
        private RadioButton rBt6Normal;
        private RadioButton rBt5Thick;
        private RadioButton rBt4VaryThick;
        private GroupBox gpBox3Noodle;
        private RadioButton rBt10Soft;
        private RadioButton rBt9NormalN;
        private RadioButton rBt8Hard;
        private Panel panel1Bonus;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
    }
}

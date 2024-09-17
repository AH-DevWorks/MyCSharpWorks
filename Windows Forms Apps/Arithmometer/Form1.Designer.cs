namespace Arithmometer
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
            textBox1 = new TextBox();
            txBoxOper = new TextBox();
            textBox2 = new TextBox();
            lb4Msg = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(42, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "數字1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F);
            label2.Location = new Point(140, 13);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "運算子";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F);
            label3.Location = new Point(253, 13);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "數字2";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 32);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox_KeyPress;
            // 
            // txBoxOper
            // 
            txBoxOper.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txBoxOper.Location = new Point(149, 45);
            txBoxOper.MaxLength = 1;
            txBoxOper.Name = "txBoxOper";
            txBoxOper.Size = new Size(39, 32);
            txBoxOper.TabIndex = 4;
            txBoxOper.TextAlign = HorizontalAlignment.Center;
            txBoxOper.TextChanged += txBoxOper_TextChanged;
            txBoxOper.KeyPress += textBox_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(223, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 32);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox_KeyPress;
            // 
            // lb4Msg
            // 
            lb4Msg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lb4Msg.BackColor = Color.LightGray;
            lb4Msg.BorderStyle = BorderStyle.Fixed3D;
            lb4Msg.Font = new Font("微軟正黑體", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lb4Msg.ForeColor = SystemColors.ControlDarkDark;
            lb4Msg.Location = new Point(12, 98);
            lb4Msg.Name = "lb4Msg";
            lb4Msg.Size = new Size(436, 38);
            lb4Msg.TabIndex = 6;
            lb4Msg.Text = "(運算結果)";
            lb4Msg.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("微軟正黑體", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(358, 45);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 7;
            button1.Text = "運算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 158);
            Controls.Add(button1);
            Controls.Add(lb4Msg);
            Controls.Add(textBox2);
            Controls.Add(txBoxOper);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Arithmometer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txBoxOper;
        private TextBox textBox2;
        private Label lb4Msg;
        private Button button1;
    }
}

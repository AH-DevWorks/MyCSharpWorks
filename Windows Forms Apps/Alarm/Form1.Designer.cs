namespace Alarm
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1Set = new Button();
            bt2Reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3TimeNow = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            bt3Snooze = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy年MM月dd日(ddd) HH : mm : ss";
            dateTimePicker1.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(32, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(621, 47);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(22, 139);
            label1.Name = "label1";
            label1.Size = new Size(189, 43);
            label1.TabIndex = 1;
            label1.Text = "鬧鈴時間：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(22, 298);
            label2.Name = "label2";
            label2.Size = new Size(189, 43);
            label2.TabIndex = 2;
            label2.Text = "提醒訊息：";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(32, 359);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(621, 47);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1Set
            // 
            button1Set.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1Set.Location = new Point(480, 463);
            button1Set.Name = "button1Set";
            button1Set.Size = new Size(173, 53);
            button1Set.TabIndex = 4;
            button1Set.Text = "設定鬧鈴";
            button1Set.UseVisualStyleBackColor = true;
            button1Set.Click += button1Set_Click;
            // 
            // bt2Reset
            // 
            bt2Reset.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            bt2Reset.ForeColor = Color.FromArgb(64, 64, 64);
            bt2Reset.Location = new Point(281, 463);
            bt2Reset.Name = "bt2Reset";
            bt2Reset.Size = new Size(129, 53);
            bt2Reset.TabIndex = 5;
            bt2Reset.Text = "重置";
            bt2Reset.UseVisualStyleBackColor = true;
            bt2Reset.Click += bt2Reset_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3TimeNow
            // 
            label3TimeNow.AutoSize = true;
            label3TimeNow.Font = new Font("源樣明體 TTF Medium", 10.0995474F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3TimeNow.ForeColor = Color.Navy;
            label3TimeNow.Location = new Point(22, 51);
            label3TimeNow.Name = "label3TimeNow";
            label3TimeNow.Size = new Size(175, 35);
            label3TimeNow.TabIndex = 6;
            label3TimeNow.Text = "現在時間：";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // bt3Snooze
            // 
            bt3Snooze.Enabled = false;
            bt3Snooze.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            bt3Snooze.ForeColor = Color.Gray;
            bt3Snooze.Location = new Point(32, 463);
            bt3Snooze.Name = "bt3Snooze";
            bt3Snooze.Size = new Size(173, 53);
            bt3Snooze.TabIndex = 7;
            bt3Snooze.Text = "延後提醒";
            bt3Snooze.UseVisualStyleBackColor = true;
            bt3Snooze.Click += bt3Postpone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 553);
            Controls.Add(bt3Snooze);
            Controls.Add(label3TimeNow);
            Controls.Add(bt2Reset);
            Controls.Add(button1Set);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Alarm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1Set;
        private Button bt2Reset;
        private System.Windows.Forms.Timer timer1;
        private Label label3TimeNow;
        private System.Windows.Forms.Timer timer2;
        private Button bt3Snooze;
    }
}

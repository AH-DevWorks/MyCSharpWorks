namespace RandomPoker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1Start = new Button();
            button2Stop = new Button();
            label4ReferenceInfo = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "0_Poker1.png");
            imageList1.Images.SetKeyName(1, "1_Poker2.png");
            imageList1.Images.SetKeyName(2, "2_Poker3.png");
            imageList1.Images.SetKeyName(3, "3_Poker4.png");
            imageList1.Images.SetKeyName(4, "4_Poker5.png");
            imageList1.Images.SetKeyName(5, "5_Poker6.png");
            imageList1.Images.SetKeyName(6, "6_Poker7.png");
            imageList1.Images.SetKeyName(7, "7_Poker8.png");
            imageList1.Images.SetKeyName(8, "8_Poker9.png");
            imageList1.Images.SetKeyName(9, "9_Poker10.png");
            imageList1.Images.SetKeyName(10, "10_Poker11.png");
            imageList1.Images.SetKeyName(11, "11_Poker12.png");
            imageList1.Images.SetKeyName(12, "12_Poker13.png");
            imageList1.Images.SetKeyName(13, "13_Poker0.png");
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(435, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 531);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("源樣明體 TTF Medium", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(104, 629);
            label1.Name = "label1";
            label1.Size = new Size(550, 86);
            label1.TabIndex = 1;
            label1.Text = "—撲克牌比大小—";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1Start
            // 
            button1Start.Location = new Point(173, 717);
            button1Start.Name = "button1Start";
            button1Start.Size = new Size(157, 63);
            button1Start.TabIndex = 2;
            button1Start.Text = "開始遊戲";
            button1Start.UseVisualStyleBackColor = true;
            button1Start.Click += button1Start_Click;
            // 
            // button2Stop
            // 
            button2Stop.Location = new Point(435, 717);
            button2Stop.Name = "button2Stop";
            button2Stop.Size = new Size(157, 63);
            button2Stop.TabIndex = 3;
            button2Stop.Text = "抽牌";
            button2Stop.UseVisualStyleBackColor = true;
            button2Stop.Click += button2Stop_Click;
            // 
            // label4ReferenceInfo
            // 
            label4ReferenceInfo.AutoSize = true;
            label4ReferenceInfo.Font = new Font("Cascadia Code", 5.86425352F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4ReferenceInfo.ForeColor = SystemColors.ControlDarkDark;
            label4ReferenceInfo.Location = new Point(466, 813);
            label4ReferenceInfo.Name = "label4ReferenceInfo";
            label4ReferenceInfo.Size = new Size(285, 24);
            label4ReferenceInfo.TabIndex = 4;
            label4ReferenceInfo.Text = "Image by brgfx on Freepik";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(45, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 531);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("源樣明體 TTF Medium", 10.0995474F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(45, 32);
            label2.Name = "label2";
            label2.Size = new Size(285, 59);
            label2.TabIndex = 6;
            label2.Text = "電腦";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("源樣明體 TTF Medium", 10.0995474F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(435, 32);
            label3.Name = "label3";
            label3.Size = new Size(285, 59);
            label3.TabIndex = 7;
            label3.Text = "玩家";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 857);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label4ReferenceInfo);
            Controls.Add(button2Stop);
            Controls.Add(button1Start);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "撲克牌遊戲";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1Start;
        private Button button2Stop;
        private Label label4ReferenceInfo;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}

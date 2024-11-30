namespace Blackjack
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
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1Hit = new Button();
            button2Restart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(68, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 525);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "13_Poker0.png");
            imageList1.Images.SetKeyName(1, "0_Poker1.png");
            imageList1.Images.SetKeyName(2, "1_Poker2.png");
            imageList1.Images.SetKeyName(3, "2_Poker3.png");
            imageList1.Images.SetKeyName(4, "3_Poker4.png");
            imageList1.Images.SetKeyName(5, "4_Poker5.png");
            imageList1.Images.SetKeyName(6, "5_Poker6.png");
            imageList1.Images.SetKeyName(7, "6_Poker7.png");
            imageList1.Images.SetKeyName(8, "7_Poker8.png");
            imageList1.Images.SetKeyName(9, "8_Poker9.png");
            imageList1.Images.SetKeyName(10, "9_Poker10.png");
            imageList1.Images.SetKeyName(11, "10_Poker11.png");
            imageList1.Images.SetKeyName(12, "11_Poker12.png");
            imageList1.Images.SetKeyName(13, "12_Poker13.png");
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(426, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 525);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(784, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(285, 525);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1142, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(285, 525);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(1500, 60);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(285, 525);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // button1Hit
            // 
            button1Hit.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1Hit.Location = new Point(68, 625);
            button1Hit.Name = "button1Hit";
            button1Hit.Size = new Size(226, 66);
            button1Hit.TabIndex = 5;
            button1Hit.Text = "要牌(Hit)";
            button1Hit.UseVisualStyleBackColor = true;
            button1Hit.Click += button1Hit_Click;
            // 
            // button2Restart
            // 
            button2Restart.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2Restart.ForeColor = Color.FromArgb(64, 64, 64);
            button2Restart.Location = new Point(68, 757);
            button2Restart.Name = "button2Restart";
            button2Restart.Size = new Size(226, 66);
            button2Restart.TabIndex = 6;
            button2Restart.Text = "重新開始";
            button2Restart.UseVisualStyleBackColor = true;
            button2Restart.Click += button2Restart_Click;
            // 
            // label1
            // 
            label1.Font = new Font("源樣明體 TTF Medium", 12.0542984F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(378, 625);
            label1.Name = "label1";
            label1.Size = new Size(1407, 94);
            label1.TabIndex = 7;
            label1.Text = "21點——過五關遊戲";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 8.144796F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(1430, 790);
            label2.Name = "label2";
            label2.Size = new Size(390, 33);
            label2.TabIndex = 8;
            label2.Text = "Image by brgfx on Freepik";
            // 
            // label3
            // 
            label3.Font = new Font("源樣明體 TTF Medium", 12.0542984F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.ForeColor = Color.FromArgb(237, 84, 102);
            label3.Location = new Point(378, 707);
            label3.Name = "label3";
            label3.Size = new Size(1001, 94);
            label3.TabIndex = 9;
            label3.Text = "【點數總和】";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1832, 851);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2Restart);
            Controls.Add(button1Hit);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Blackjack - Five Card Charlie";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1Hit;
        private Button button2Restart;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

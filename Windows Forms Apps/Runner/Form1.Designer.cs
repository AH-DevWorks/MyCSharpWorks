namespace Runner
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
            PicRun = new System.Windows.Forms.Timer(components);
            PicMove = new System.Windows.Forms.Timer(components);
            imageList2 = new ImageList(components);
            bt1Start = new Button();
            bt2Stop = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(259, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "man1.gif");
            imageList1.Images.SetKeyName(1, "man2.gif");
            imageList1.Images.SetKeyName(2, "man3.gif");
            imageList1.Images.SetKeyName(3, "man4.gif");
            // 
            // PicRun
            // 
            PicRun.Tick += PicRun_Tick;
            // 
            // PicMove
            // 
            PicMove.Tick += PicMove_Tick;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "start.bmp");
            imageList2.Images.SetKeyName(1, "stop.bmp");
            // 
            // bt1Start
            // 
            bt1Start.BackColor = SystemColors.Control;
            bt1Start.BackgroundImageLayout = ImageLayout.None;
            bt1Start.Cursor = Cursors.Hand;
            bt1Start.FlatStyle = FlatStyle.Popup;
            bt1Start.Location = new Point(207, 179);
            bt1Start.Name = "bt1Start";
            bt1Start.Size = new Size(50, 50);
            bt1Start.TabIndex = 1;
            bt1Start.UseVisualStyleBackColor = false;
            bt1Start.Click += bt1Start_Click;
            // 
            // bt2Stop
            // 
            bt2Stop.BackColor = SystemColors.Control;
            bt2Stop.BackgroundImageLayout = ImageLayout.None;
            bt2Stop.Cursor = Cursors.Hand;
            bt2Stop.FlatStyle = FlatStyle.Popup;
            bt2Stop.Location = new Point(349, 179);
            bt2Stop.Name = "bt2Stop";
            bt2Stop.Size = new Size(50, 50);
            bt2Stop.TabIndex = 2;
            bt2Stop.UseVisualStyleBackColor = false;
            bt2Stop.Click += bt2Stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 267);
            Controls.Add(bt2Stop);
            Controls.Add(bt1Start);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ImageList imageList1;
        private System.Windows.Forms.Timer PicRun;
        private System.Windows.Forms.Timer PicMove;
        private ImageList imageList2;
        private Button bt1Start;
        private Button bt2Stop;
    }
}

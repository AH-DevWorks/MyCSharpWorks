namespace Runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int imgNum = 0;
        public bool go = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            bt1Start.Image = imageList2.Images[0];
            bt2Stop.Image = imageList2.Images[1];
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            PicRun.Interval = 200;
            PicRun.Enabled = true;
        }

        private void PicRun_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[imgNum];
            if (imgNum == 3)
            {
                imgNum = 0;
            }
            else
            {
                imgNum++;
            }
        }

        private void PicMove_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 10;
            if (pictureBox1.Left <= (-pictureBox1.Width)) pictureBox1.Left = this.ClientSize.Width;
        }

        private void bt1Start_Click(object sender, EventArgs e)
        {
            go = true;
            PicMove.Interval = 100;
            PicMove.Enabled = true;
        }

        private void bt2Stop_Click(object sender, EventArgs e)
        {
            if(go) PicMove.Enabled = false;
        }
    }
}

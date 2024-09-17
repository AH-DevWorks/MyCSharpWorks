namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int clickTimes = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = Image.FromFile("C:\\Users\\alext\\source\\repos\\Picture\\Resources\\pic3.png");
            pictureBox4.Image = new Bitmap(@"C:\Users\alext\source\repos\Picture\Resources\pic4.png");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImgClick(0);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ImgClick(1);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ImgClick(2);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ImgClick(3);
        }
        private void ImgClick(int picNum)
        {
            clickTimes ++;
            DateTime clickTime = DateTime.Now;
            pictureBox5.Image = imageList1.Images[picNum];
            pictureBox5.SizeMode = PictureBoxSizeMode.Normal;
            for (int h = 0; h <= 240; h += 10)
            {
                pictureBox5.Height = h;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - clickTime).TotalSeconds < 0.1);
            }
        }
    }
}

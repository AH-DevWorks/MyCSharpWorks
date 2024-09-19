namespace RandomPoker
{
    public partial class Form1 : Form
    {
        int pokerChosen = 13;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(285, 526);
            pictureBox1.Image = imageList1.Images[13];
            button2Stop.Enabled = false;
            button2Stop.ForeColor = Color.DarkGray;
            timer1.Interval = 75;
            timer1.Enabled = false;
        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkBlue;
            label1.Text = "—亂數撲克—";
            timer1.Enabled = true;
            button2Stop.Enabled = true;
            button2Stop.ForeColor = Color.Black;
            button1Start.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random poker = new Random();
            pokerChosen = poker.Next(0, 13);
            pictureBox1.Image = imageList1.Images[pokerChosen];
        }

        private void button2Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            label1.Text = $"抽到 {pokerChosen + 1} 點！";
            button1Start.Enabled = true;
            button1Start.Text = "重新開始";
            button2Stop.Enabled = false;
        }
    }
}

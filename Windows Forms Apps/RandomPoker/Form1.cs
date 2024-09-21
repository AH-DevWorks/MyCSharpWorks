namespace RandomPoker
{
    public partial class Form1 : Form
    {
        int pokerChosen = 13;
        int comPokerNum = 13;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(285, 526);
            pictureBox2.Size = new Size(285, 526);
            pictureBox1.Image = imageList1.Images[13];
            pictureBox2.Image = imageList1.Images[13];
            button2Stop.Enabled = false;
            button2Stop.ForeColor = Color.DarkGray;
            timer1.Interval = 75;
            timer1.Enabled = false;
        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            comPokerNum = random.Next(0, 13);
            pictureBox2.Image = imageList1.Images[comPokerNum];
            label2.Text = $"電腦抽到 {comPokerNum + 1} 點";
            label1.ForeColor = Color.DarkBlue;
            label1.Text = "—撲克牌比大小—";
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
            label3.Text = $"你抽到 {pokerChosen + 1} 點";
            label3.ForeColor = Color.DarkBlue ;
            timer1.Enabled = false;
            if (comPokerNum > pokerChosen)
            {
                label1.Text = "電腦獲勝！";
            }
            else if (comPokerNum < pokerChosen)
            {
                label1.Text = "恭喜你獲勝！";
            }
            else
            {
                label1.Text = "平手！";
            }
            button1Start.Enabled = true;
            button1Start.Text = "重新開始";
            button2Stop.Enabled = false;
        }
    }
}

/*
 * Card Images:
 * Image by brgfx on Freepik
 * Source: https://www.freepik.com/free-vector/poker-cards-set-club-with-back-design_1169226.htm
 */
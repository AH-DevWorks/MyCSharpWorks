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
            label2.Text = $"�q����� {comPokerNum + 1} �I";
            label1.ForeColor = Color.DarkBlue;
            label1.Text = "�X���J�P��j�p�X";
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
            label3.Text = $"�A��� {pokerChosen + 1} �I";
            label3.ForeColor = Color.DarkBlue ;
            timer1.Enabled = false;
            if (comPokerNum > pokerChosen)
            {
                label1.Text = "�q����ӡI";
            }
            else if (comPokerNum < pokerChosen)
            {
                label1.Text = "���ߧA��ӡI";
            }
            else
            {
                label1.Text = "����I";
            }
            button1Start.Enabled = true;
            button1Start.Text = "���s�}�l";
            button2Stop.Enabled = false;
        }
    }
}

/*
 * Card Images:
 * Image by brgfx on Freepik
 * Source: https://www.freepik.com/free-vector/poker-cards-set-club-with-back-design_1169226.htm
 */
namespace Blackjack
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        PictureBox[] pokerpic = new PictureBox[5];
        int[] cardNumber = { 0, 0, 0, 0, 0 };
        int numSum = 0;
        int times = 0;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            pokerpic[0] = pictureBox1; pokerpic[1] = pictureBox2; pokerpic[2] = pictureBox3;
            pokerpic[3] = pictureBox4; pokerpic[4] = pictureBox5;
            button2Restart.Enabled = true;
            button1Hit.Text = "要牌(Hit)";
            InitializeOrResetCards();
        }

        private void button1Hit_Click(object sender, EventArgs e)
        {
            if (times < 3)
            {
                DealCard(times + 2);
                times++;

                if (times == 3 && numSum <= 21)
                {
                    label1.Text += "　恭喜過五關！";
                    button1Hit.Enabled = false;
                }
            }
        }

        public void Calculate()
        {
            numSum = 0;
            for (int i = 0; i < cardNumber.Length; i++)
            {
                if (cardNumber[i] > 10)
                {
                    numSum += 10;
                }
                else
                {
                    numSum += cardNumber[i];
                }
            }
            if (numSum > 21)
            {
                label1.Text = $"總和{numSum}點，Bust！";
                button1Hit.Enabled = false;
                times = 0;
            }
            else
            {
                label1.Text = $"目前總和：{numSum}點";
            }
        }

        private void button2Restart_Click(object sender, EventArgs e)
        {
            InitializeOrResetCards();
        }

        private void InitializeOrResetCards()
        {
            button1Hit.Enabled = true;
            Array.Clear(cardNumber);
            cardNumber[0] = random.Next(1, 14);
            cardNumber[1] = random.Next(1, 14);
            pokerpic[0].Image = imageList1.Images[cardNumber[0]];
            pokerpic[1].Image = imageList1.Images[cardNumber[1]];
            numSum = cardNumber[0] + cardNumber[1];
            for (int i = 2; i < pokerpic.Length; i++) pokerpic[i].Image = imageList1.Images[0];
            label1.Text = $"目前總和：{numSum}點";
            times = 0;
        }

        private void DealCard(int cardIndex)
        {
            cardNumber[cardIndex] = random.Next(1, 14);
            pokerpic[cardIndex].Image = imageList1.Images[cardNumber[cardIndex]];
            Calculate();
        }
    }
}

/*
 * Card Images:
 * Image by brgfx on Freepik
 * Source: https://www.freepik.com/free-vector/poker-cards-set-club-with-back-design_1169226.htm
 */

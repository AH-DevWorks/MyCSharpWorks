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
        int[] cardArray = { 0, 0, 0, 0, 0 };
        int numSum = 0;
        int times = 0;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            pokerpic[0] = pictureBox1; pokerpic[1] = pictureBox2; pokerpic[2] = pictureBox3;
            pokerpic[3] = pictureBox4; pokerpic[4] = pictureBox5;
            button2Restart.Enabled = true;
            button1Hit.Text = "�n�P(Hit)";
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
                    label3.Text += "�@���߹L�����I";
                    button1Hit.Enabled = false;
                }
            }
        }

        public void Calculate()
        {
            int aces = cardArray.Count(c => c == 1);  //�p��A���i��
            numSum = cardArray.Sum(s => Math.Min(s, 10));  //���NA��1�I
            //�Y��A�A�BA��p��11�I�����|bust�A�h�֥[�C
            while (aces > 0 && numSum + 10 <= 21)
            {
                numSum += 10;
                aces--;
            }

            if (numSum > 21)
            {
                Console.Beep();
                label3.Text = $"�`�M{numSum}�I�ABust�I";
                button1Hit.Enabled = false;
                times = 0;
            }
            else
            {
                label3.Text = $"�ثe�`�M�G{numSum}�I";
            }
        }

        private void button2Restart_Click(object sender, EventArgs e)
        {
            InitializeOrResetCards();
        }

        private void InitializeOrResetCards()
        {
            label3.Text = " ";
            numSum = 0;
            button1Hit.Enabled = true;
            Array.Clear(cardArray);
            cardArray[0] = random.Next(1, 14);
            cardArray[1] = random.Next(1, 14);
            pokerpic[0].Image = imageList1.Images[cardArray[0]];
            pokerpic[1].Image = imageList1.Images[cardArray[1]];
            Calculate();
            for (int i = 2; i < pokerpic.Length; i++) pokerpic[i].Image = imageList1.Images[0];
            times = 0;
        }

        private void DealCard(int cardIndex)
        {
            cardArray[cardIndex] = random.Next(1, 14);
            pokerpic[cardIndex].Image = imageList1.Images[cardArray[cardIndex]];
            Calculate();
        }
    }
}

/*
 * Card Images:
 * Image by brgfx on Freepik
 * Source: https://www.freepik.com/free-vector/poker-cards-set-club-with-back-design_1169226.htm
 */

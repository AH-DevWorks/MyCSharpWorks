namespace BikeRentCalc
{
    public partial class Form1 : Form
    {
        public const int rentWithin240min = 10;             //<=240min - $10/ 30min
        public const int rentDuring241to480min = 20;   //241~480min - $20/ 30min
        public const int rentOver481min = 40;                //481~900min - $40/30min
        public const int basicRateTime = 240;
        public const int standardRateTime = 480;
        public const int maxRentTime = 900;
        public const int rentTimeUnit = 30;
        public const int bonusTimeUnit = 30;
        public decimal rentCost = 0M;
        public Form1()
        {
            InitializeComponent();
            this.Text = "�樮����O�ΧU��UBike Rental Fee Assistant";
            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void RentCalculation(decimal rentTime)
        {
            if (rentTime <= bonusTimeUnit)
            {
                label2.ForeColor = Color.Blue;
                label2.Text = $"�������ɮɶ�30�������A�K�O�I";
            }
            else if (rentTime <= basicRateTime && rentTime > bonusTimeUnit)
            {
                rentCost = Math.Ceiling((rentTime - bonusTimeUnit) / rentTimeUnit) * rentWithin240min;
                lb2Show();
            }
            else if (rentTime > basicRateTime && rentTime <= standardRateTime)
            {
                rentCost = (basicRateTime - bonusTimeUnit) / rentTimeUnit * rentWithin240min + Math.Ceiling((rentTime - basicRateTime) / rentTimeUnit) * rentDuring241to480min;
                lb2Show();
            }
            else if (rentTime > standardRateTime && rentTime <= maxRentTime)
            {
                rentCost = (basicRateTime - bonusTimeUnit) / rentTimeUnit * rentWithin240min + (standardRateTime - basicRateTime) / rentTimeUnit * rentDuring241to480min + Math.Ceiling((rentTime - standardRateTime) / rentTimeUnit) * rentOver481min;
                lb2Show();
            }
            else
            {
                ShowMessage("���~�G�W��(15hr)�A�Ь��ȪA�H���C");
            }
        }
        private void lb2Show()
        {
            label2.ForeColor = Color.Blue;
            label2.Text = $"�������ɶO�ά��G{rentCost.ToString("C0")} ";
            textBox1.Focus();
            textBox1.SelectAll();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = true;
                button1.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal rentTime = 0;
            if (decimal.TryParse(textBox1.Text, out rentTime))
            {
                if (rentTime > 0)
                {
                    RentCalculation(rentTime);
                }
                else
                {
                    ShowMessage("���~�G�ȭ���J�j��0����ơC");
                }
            }
            else
            {
                ShowMessage("���~�G�ȭ���J�j��0����ơC");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal rentTime = 0;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (decimal.TryParse(textBox1.Text, out rentTime))
                {
                    if (rentTime > 0)
                    {
                        RentCalculation(rentTime);
                    }
                    else
                    {
                        ShowMessage("���~�G�ȭ���J�j��0����ơC");
                    }
                }
                else
                {
                    ShowMessage("���~�G�ȭ���J�j��0����ơC");
                }
            }
        }
        private void ShowMessage(string msg)
        {
            label2.ForeColor = Color.Red;
            label2.Text = msg;
            textBox1.Focus();
            textBox1.SelectAll();
        }
    }
}

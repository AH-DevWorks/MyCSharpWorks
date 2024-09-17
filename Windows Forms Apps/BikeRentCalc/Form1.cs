namespace BikeRentCalc
{
    public partial class Form1 : Form
    {
        public const int rentWithin240min = 10;
        public const int rentDuring241to480min = 20;
        public const int rentOver481min = 30;
        public const int basicRateTime = 240;
        public const int standardRateTime = 480;
        public const int rentTimeUnit = 30;
        public const int bonusTimeUnit = 30;
        public int rentTime = 0;
        public decimal rentCost = 0M;
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void RentCalculation()
        {
            decimal tt = (rentTime - bonusTimeUnit) / rentTimeUnit;
            if (rentTime < basicRateTime && rentTime > bonusTimeUnit)
            {
                if (rentTime % 30 != 0) tt++;
                rentCost = tt * rentWithin240min;
                lb3Show();
            }
            else if (rentTime <= standardRateTime && rentTime > basicRateTime)
            {
                if (rentTime % 30 != 0) tt++;
                rentCost = tt * rentDuring241to480min;
                lb3Show();
            }
            else if (rentTime < 0)
            {
                ShowError("數值不可小於0 ");
            }
            else if(rentTime > standardRateTime && rentTime <= 900)
            {
                if (rentTime % 30 != 0) tt++;
                rentCost = tt * rentOver481min;
                lb3Show();
            }
            else if(rentTime >= 0 && rentTime <= bonusTimeUnit)
            {
                tt = 0;
                rentCost = tt * rentWithin240min;
                lb3Show();
            }
            else
            {
                ShowError("超時(15hr)，請洽客服人員。");
            }
        }
        private void lb3Show()
        {
            label2.Text = $"本次租借費用為：{rentCost.ToString("C0")} ";
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
            if (int.TryParse(textBox1.Text, out rentTime))
            {
                RentCalculation();
            }
            else
            {
                ShowError("僅限輸入大於0的整數。");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (int.TryParse(textBox1.Text, out rentTime))
                {
                    RentCalculation();
                }
                else
                {
                    ShowError("僅限輸入大於0的整數。");
                }
            }
        }
        private void ShowError(string errorText)
        {
            label2.ForeColor = Color.Red;
            label2.Text = $"錯誤：{errorText}";
            textBox1.Focus();
            textBox1.SelectAll();
        }
    }
}

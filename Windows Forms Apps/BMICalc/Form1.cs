namespace BMICalc
{
    public partial class Form1 : Form
    {
        private const decimal UnderweightThreshold = 18.5M;
        private const decimal NormalWeightThreshold = 24M;
        private const decimal OverweightThreshold = 27M;
        public decimal height = 0M;
        public decimal weight = 0M;
        public decimal BMI = 0M;
        public Form1()
        {
            InitializeComponent();
        }

        private void txBoxHeight_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }
        private void txBoxWeight_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BMICalculate(height, weight);
        }
        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                BMICalculate(height, weight);
            }
        }
        private void BMICalculate(decimal numHeight, decimal numWeight)
        {
            if (numHeight <= 0 || numWeight <= 0)
            {
                ShowError("身高或體重不可小於1");
            }
            else
            {
                BMI = numWeight / ((numHeight / 100) * (numHeight / 100));
                lb4BMIShow.ForeColor = Color.BlueViolet;
                lb4BMIShow.Text = $"BMI = {BMI.ToString("F1")}";
                lb5BMIRange.ForeColor = Color.DarkRed;
                switch (BMI)
                {
                    case >= OverweightThreshold:
                        lb5BMIRange.Text = "肥胖";
                        break;
                    case >= NormalWeightThreshold:
                        lb5BMIRange.Text = "過重";
                        break;
                    case >= UnderweightThreshold:
                        lb5BMIRange.ForeColor = Color.DarkGreen;
                        lb5BMIRange.Text = "正常";
                        break;
                    default:
                        lb5BMIRange.Text = "過輕";
                        break;
                }
                txBoxHeight.Focus();
                txBoxHeight.SelectAll();
            }
        }
        private void ShowError(string msg)
        {
            lb4BMIShow.ForeColor = Color.Red;
            lb4BMIShow.Text = msg;
            lb5BMIRange.ForeColor = Color.Red;
            lb5BMIRange.Text = "錯誤";
            txBoxHeight.Focus();
            txBoxHeight.SelectAll();
        }
        private void CheckInput()
        {
            if (!string.IsNullOrWhiteSpace(txBoxWeight.Text) && decimal.TryParse(txBoxWeight.Text, out weight) && !string.IsNullOrWhiteSpace(txBoxHeight.Text) && decimal.TryParse(txBoxHeight.Text, out height))
            {
                button1.Enabled = true;
                button1.ForeColor = Color.Black;
            }
        }
    }
}

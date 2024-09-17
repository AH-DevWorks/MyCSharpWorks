namespace TaxCalc_3Oper
{
    public partial class Form1 : Form
    {
        public const decimal lowRateThreshold = 1000000M;
        public const decimal highRateThreshold = 3000000M;
        public decimal income = 0M;
        public const decimal lowRate = 0.1M;
        public const decimal standardRate = 0.2M;
        public const decimal highRate = 0.4M;
        public decimal rate = 0M;
        public decimal tax = 0M;
        public Form1()
        {
            InitializeComponent();
        }

        private void txBoxIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                RateAndTexClac();
            }
        }
        private void RateAndTexClac()
        {
            if (!string.IsNullOrWhiteSpace(txBoxIncome.Text))
            {
                if(decimal.TryParse(txBoxIncome.Text, out decimal income))
                {
                    if (income < 0)
                    {
                        ShowError("���J���o�C�� 0 �C");
                    }
                    else
                    {
                        rate = (income < lowRateThreshold ? lowRate : (income < highRateThreshold ? standardRate : highRate));
                        lbTaxRate.ForeColor = Color.Black;
                        lbTaxRate.Text = $" {rate * 100 :F0} %";
                        tax = income * rate;
                        lbTax.ForeColor = Color.Blue;
                        lbTax.Text = tax.ToString("C0");
                        label4.Text = "";
                        txBoxIncome.Focus();
                        txBoxIncome.SelectAll();
                    }
                }
                else
                {
                    ShowError("�п�J���T�ƭȡC");
                }
            }
            else
            {
                ShowError("��줣�i�ťաI");
            }
        }
        private void ShowError(string msg)
        {
            label4.ForeColor = Color.Red;
            label4.Text = $"���~�G {msg} ";
            lbTaxRate.Text = "";
            lbTax.Text = "";
            txBoxIncome.Focus();
            txBoxIncome.SelectAll();
        }

        private void txBoxIncome_TextChanged(object sender, EventArgs e)
        {
            lbTaxRate.Text = "";
            lbTax.Text = "";
            label4.ForeColor = Color.BlueViolet;
            label4.Text = "��J������A�Ы� Enter ��}�l�p��C";
        }
    }
}

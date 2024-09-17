namespace etc
{
    public partial class Form1 : Form
    {
        // 定義為常量，增加代碼可讀性，且利於後續調整。
        private const decimal FREE_MILEAGE = 20m;
        private const decimal RATE_PER_KM = 1.2m;
        private const decimal DISCOUNT_THRESHOLD = 200m;
        private const decimal DISCOUNT_RATE = 0.75m;

        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_KeyPress;
        }
        private void UpdateMileAge()
        {
            if (decimal.TryParse(textBox1.Text, out decimal mileage))
            {
                if (mileage < 0)
                {
                    ShowError("里程數不可小於0！");
                    return;
                }

                //金錢計算，使用 decimal 以避免float/ double精度問題
                decimal payment = CalculatePayment(mileage);
                if (payment == 0)
                {
                    label2.ForeColor = Color.Black;
                    label2.Text = $"里程數低於{FREE_MILEAGE}公里，無須繳納用路費。";
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                else
                {
                    label2.ForeColor = Color.Black;
                    label2.Text = $"應繳納用路費：{payment:C0} ";  //四捨五入到整數
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
            }
            else
            {
                ShowError("僅限輸入數字及小數點。");
            }
        }

        // 以單獨Method整合計費方式，提升維護性
        private decimal CalculatePayment(decimal mileage)
        {
            if (mileage <= FREE_MILEAGE) return 0;
            if (mileage <= DISCOUNT_THRESHOLD) return (mileage - FREE_MILEAGE) * RATE_PER_KM;
            return (mileage - DISCOUNT_THRESHOLD) * RATE_PER_KM * DISCOUNT_RATE + (DISCOUNT_THRESHOLD - FREE_MILEAGE) * RATE_PER_KM;
        }

        // 統一處理錯誤訊息
        private void ShowError(string message)
        {
            label2.ForeColor = Color.Red;
            label2.Text = $"錯誤：{message}";
            textBox1.Focus();
            textBox1.SelectAll();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.ForeColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMileAge();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                UpdateMileAge();
            }
        }
    }
}

namespace movie
{
    public partial class Form1 : Form
    {
        int sumFA;
        int sumCT;
        public Form1()
        {
            InitializeComponent();
            STNumBox.Enter += FANumBox_Enter;   //無論第幾次focus到都能觸發Enter方法
            DTNumBox.Enter += CTNumBox_Enter;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            STNumBox.Text = "0";
            DTNumBox.Text = "0";
            STNumBox.Focus();
            Lb6STTC.Text = "Standard";
            Lb6STTC.ForeColor = Color.DarkGray;
            Lb7DTTC.Text = "Discounted";
            Lb7DTTC.ForeColor = Color.DarkGray;
            LB8TtCt.Text = "(Total Cost)";
            LB8TtCt.ForeColor = Color.DarkGray;
        }
        private void FANumBox_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.SelectAll();
            }
        }
        private void FANumBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sumFA = Convert.ToInt32(STNumBox.Text) * Convert.ToInt32(STPrice.Text);
                Lb6STTC.ForeColor = Color.Black;
                Lb6STTC.Text = sumFA.ToString("C0");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number! Please Try Again!");
                STNumBox.Text = "0";
                Lb6STTC.ForeColor = Color.DarkGray;
            }
            UpdateTotalCost();
        }
        private void CTNumBox_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.SelectAll();
            }
        }
        private void CTNumBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sumCT = Convert.ToInt32(DTNumBox.Text) * Convert.ToInt32(DTPrice.Text);
                Lb7DTTC.ForeColor = Color.Black;
                Lb7DTTC.Text = sumCT.ToString("C0");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number! Please Try Again!");
                DTNumBox.Text = "0";
                Lb7DTTC.ForeColor = Color.DarkGray;
            }
            UpdateTotalCost();
        }
        private void UpdateTotalCost()
        {
            int sumTT = sumCT + sumFA;
            LB8TtCt.Text = sumTT.ToString("C0");
            LB8TtCt.ForeColor = sumTT > 0 ? Color.Black : Color.DarkGray;
        }
    }
}

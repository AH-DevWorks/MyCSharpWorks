namespace etc
{
    public partial class Form1 : Form
    {
        // �w�q���`�q�A�W�[�N�X�iŪ�ʡA�B�Q�����վ�C
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
                    ShowError("���{�Ƥ��i�p��0�I");
                    return;
                }

                //�����p��A�ϥ� decimal �H�קKfloat/ double��װ��D
                decimal payment = CalculatePayment(mileage);
                if (payment == 0)
                {
                    label2.ForeColor = Color.Black;
                    label2.Text = $"���{�ƧC��{FREE_MILEAGE}�����A�L��ú�ǥθ��O�C";
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                else
                {
                    label2.ForeColor = Color.Black;
                    label2.Text = $"��ú�ǥθ��O�G{payment:C0} ";  //�|�ˤ��J����
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
            }
            else
            {
                ShowError("�ȭ���J�Ʀr�Τp���I�C");
            }
        }

        // �H��WMethod��X�p�O�覡�A���ɺ��@��
        private decimal CalculatePayment(decimal mileage)
        {
            if (mileage <= FREE_MILEAGE) return 0;
            if (mileage <= DISCOUNT_THRESHOLD) return (mileage - FREE_MILEAGE) * RATE_PER_KM;
            return (mileage - DISCOUNT_THRESHOLD) * RATE_PER_KM * DISCOUNT_RATE + (DISCOUNT_THRESHOLD - FREE_MILEAGE) * RATE_PER_KM;
        }

        // �Τ@�B�z���~�T��
        private void ShowError(string message)
        {
            label2.ForeColor = Color.Red;
            label2.Text = $"���~�G{message}";
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

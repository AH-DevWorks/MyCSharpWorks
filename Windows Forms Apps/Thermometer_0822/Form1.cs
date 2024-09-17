namespace Thermometer_0822
{
    // ¢K = ¢J * 9/5 + 32
    // ¢J = (¢K - 32) * 5/9
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(1030, 765);
            txtCelsius.MaxLength = 6;
            txtFahrenheit.MaxLength = 6;
            txtCelsius.Focus();
        }
        private void btnCtoF_Click(object sender, EventArgs e)
        {
            try
            {
                txtFahrenheit.Clear();
                double Celsius = double.Parse(txtCelsius.Text);
                double Fahrenheit = Celsius * 5 / 9 + 32;
                txtFahrenheit.Text = Fahrenheit.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Keyin! Please try again.");
                txtCelsius.Clear();
            }
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            try
            {
                txtCelsius.Clear();
                double Fahrenheit = double.Parse(txtFahrenheit.Text);
                double Celsius = (Fahrenheit- 32) * 9 / 5;
                txtCelsius.Text = Celsius.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Keyin! Please try again.");
                txtFahrenheit.Clear();
            }
        }
    }
}

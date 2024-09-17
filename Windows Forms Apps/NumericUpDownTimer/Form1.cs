namespace NumericUpDownTimer
{
    public partial class Form1 : Form
    {
        int decidedTimes = 1;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Focus();
            timer1.Enabled = false;
            checkBox1.Checked = false;
            numericUpDown1.DecimalPlaces = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.DecimalPlaces = 2;
                numericUpDown1.Increment = 0.05M;
            }
            else
            {
                numericUpDown1.DecimalPlaces = 0;
                numericUpDown1.Increment = 1;
            }
        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 0)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("時間不可為0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!checkBox1.Checked)
                {
                    if (numericUpDown1.Value % 1 != 0)
                    {
                        MessageBox.Show("若要以秒為單位，請勾選上方「設定到秒(s)」框", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        decidedTimes = (int)numericUpDown1.Value * 60;
                        CheckAndTimerOn();
                    }
                }
                else
                {
                    decidedTimes = (int)(numericUpDown1.Value * 60);
                    CheckAndTimerOn();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tag = (int)timer1.Tag - 1;
            label1BigNum.Text = $"{timer1.Tag}";
            if ((int)timer1.Tag <= 0)
            {
                System.Media.SystemSounds.Beep.Play();
                timer1.Enabled = false;
                label1BigNum.Font = new Font("Century Gothic", 36, FontStyle.Bold);
                return;
            }
        }

        private void CheckAndTimerOn()
        {
            if (decidedTimes / 1000 > 0) label1BigNum.Font = new Font("Century Gothic", 32, FontStyle.Bold);
            timer1.Tag = decidedTimes;
            timer1.Enabled = true;
        }
    }
}

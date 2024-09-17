namespace Arithmometer
{
    public partial class Form1 : Form
    {
        public double num1;
        public double num2;
        public string oper;
        public double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) button1.Enabled = true;
            button1.ForeColor = button1.Enabled ? Color.Black : Color.DarkGray;
        }
        private void txBoxOper_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txBoxOper.Text)) button1.Enabled = true;
            button1.ForeColor = button1.Enabled ? Color.Black : Color.DarkGray;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)) button1.Enabled = true;
            button1.ForeColor = button1.Enabled ? Color.Black : Color.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoArithmomet();
        }
        private void DoArithmomet()
        {
            bool num1ok = Number1Check();
            bool operok = OperatorCheck();
            bool num2ok = Number2Check();
            if (num1ok && operok && num2ok)
            {
                switch (oper)
                {
                    case "+":
                        result = num1 + num2;
                        ShowResult(num1,num2,"+",result);
                        break;
                    case "-":
                        result = num1 - num2;
                        ShowResult(num1, num2, "-", result);
                        break;
                    case "*":
                        result = num1 * num2;
                        ShowResult(num1, num2, "*", result);
                        break;
                    default:
                        result = num1 / num2;
                        ShowResult(num1, num2, "/", result);
                        break;
                }
            }
        }
        private bool Number1Check()
        {
            if (!double.TryParse(textBox1.Text, out num1))
            {
                ShowError("计1计岿粇");
                textBox1.Focus();
                textBox1.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool OperatorCheck()
        {
            oper = txBoxOper.Text;
            if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
            {
                return true;
            }
            else
            {
                ShowError("笲衡莱+ - * /");
                txBoxOper.Focus();
                txBoxOper.SelectAll();
                return false;
            }
        }
        private bool Number2Check()
        {
            if (!double.TryParse(textBox2.Text, out num2))
            {
                ShowError("计2计岿粇");
                textBox2.Focus();
                textBox2.SelectAll();
                return false;
            }
            else if(textBox2.Text == "0")
            {
                ShowError("埃计ぃ0");
                textBox2.Focus();
                textBox2.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ShowError(string msg)
        {
            lb4Msg.ForeColor = Color.Red;
            lb4Msg.Text = $"Error:{msg} ";
        }
        private void ShowResult(double n1, double n2, string op, double res)
        {
            lb4Msg.ForeColor = Color.Blue;
            lb4Msg.Text = $"{n1} {op} {n2} = {res} ";
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        /*private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txBoxOper_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }*/
        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                DoArithmomet();
            }
        }
    }
}

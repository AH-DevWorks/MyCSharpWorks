using System.ComponentModel;

namespace Login
{
    public partial class Form1 : Form
    {
        private int withdrawNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bx1Password.PasswordChar = '*';
            bx2Money.Enabled = false;
            bt1.Enabled = false;
            bt1.ForeColor = Color.DarkGray;
            string nameIPBox = Microsoft.VisualBasic.Interaction.InputBox("請輸入您的姓名：", "歡迎", "王小明", 550, 550);
            Text = nameIPBox + "的登入畫面";
            MessageBox.Show($"{nameIPBox}您好，歡迎使用本系統");
        }
        private void PerformLogin()
        {
            if (bx1Password.Text == "a123456")
            {
                bx2Money.Enabled = true;
                bx2Money.Text = "0";
                bx2Money.ForeColor = Color.Black;
                bx2Money.Focus();
                bx2Money.Select();
                bt1.Enabled = true;
                bt3.Enabled = false;
                bt1.ForeColor = Color.Black;
                bt1.FlatStyle = FlatStyle.Popup;
                label3.Text = "提款金額 (元)";
                label3.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("密碼錯誤，請再試一次。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bx1Password.Clear();
                bx1Password.Focus();
            }
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }
        private void bx1Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                PerformLogin();
            }
        }
        private void bx2Money_TextChanged_1(object sender, EventArgs e)
        {
            UpdateWithdraw();
        }
        private void UpdateWithdraw()
        {
            if (int.TryParse(bx2Money.Text, out withdrawNumber))
            {
                if (withdrawNumber <= 0)
                {
                    label3.ForeColor = Color.Gray;
                    label3.Text = "錯誤。請輸入大於1的金額。";
                }
                else
                {
                    label3.Text = withdrawNumber.ToString("C0");
                    label3.ForeColor = Color.Black;
                }
            }
            else
            {
                label3.ForeColor = Color.Gray;
                label3.Text = "錯誤。請輸入有效的提款金額。";
                withdrawNumber = 0;
            }
        }
        private void doWithdraw(object sender, EventArgs e)
        {
            if (withdrawNumber > 0)
            {
                DialogResult checkWithdraw = MessageBox.Show($"確認提領{withdrawNumber.ToString("C0")}嗎？", "提款確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (checkWithdraw == DialogResult.Yes)
                {
                    MessageBox.Show($"已提領{withdrawNumber.ToString("C0")}，歡迎再度光臨。");
                    Thread.Sleep(1000);
                    Application.Exit();
                }
                else
                {
                    bx2Money.Focus();
                    bx2Money.Select();
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的提款金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bx2Money.Focus();
                bx2Money.Select();
            }
        }
        private void bt1_Click_1(object sender, EventArgs e)
        {
            doWithdraw(sender, e);
        }
        private void bx2Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // 防止 Enter 鍵發出聲音
                doWithdraw(sender, e);
            }
        }
        private void bt2End_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("確定離開本系統？", "結束程式", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Thread.Sleep(250);
                Application.Exit();
            }
            else
            {
                bx2Money.Focus();
                bx2Money.Select();
            }
        }
    }
}

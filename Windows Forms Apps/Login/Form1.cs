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
            string nameIPBox = Microsoft.VisualBasic.Interaction.InputBox("�п�J�z���m�W�G", "�w��", "���p��", 550, 550);
            Text = nameIPBox + "���n�J�e��";
            MessageBox.Show($"{nameIPBox}�z�n�A�w��ϥΥ��t��");
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
                label3.Text = "���ڪ��B (��)";
                label3.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("�K�X���~�A�ЦA�դ@���C", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    label3.Text = "���~�C�п�J�j��1�����B�C";
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
                label3.Text = "���~�C�п�J���Ī����ڪ��B�C";
                withdrawNumber = 0;
            }
        }
        private void doWithdraw(object sender, EventArgs e)
        {
            if (withdrawNumber > 0)
            {
                DialogResult checkWithdraw = MessageBox.Show($"�T�{����{withdrawNumber.ToString("C0")}�ܡH", "���ڽT�{", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (checkWithdraw == DialogResult.Yes)
                {
                    MessageBox.Show($"�w����{withdrawNumber.ToString("C0")}�A�w��A�ץ��{�C");
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
                MessageBox.Show("�п�J���Ī����ڪ��B�C", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                e.Handled = true; // ���� Enter ��o�X�n��
                doWithdraw(sender, e);
            }
        }
        private void bt2End_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("�T�w���}���t�ΡH", "�����{��", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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

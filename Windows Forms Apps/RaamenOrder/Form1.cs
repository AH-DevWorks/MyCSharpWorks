namespace RaamenOrder
{
    public partial class Form1 : Form
    {
        public int cost = 0;
        public int orderNum = 0;
        public string orderMsg = "�q��T�{�G\n";
        public Form1()
        {
            InitializeComponent();
            string tableNum = Microsoft.VisualBasic.Interaction.InputBox("�п�J�ู�G", "�I�\�t��", "0", 300, 500);
            Text += $"�@�ู�G{tableNum} ";
        }

        private void rBt1Big_CheckedChanged(object sender, EventArgs e)
        {
            OrderStart();
            if(rBt10Soft.Checked == true)
            {
                orderNum = 1;
            }
        }
        private void rBt2Standard_CheckedChanged(object sender, EventArgs e)
        {
            OrderStart();
            if (rBt2Standard.Checked == true)
            {
                orderNum = 2;
            }
        }
        private void rBt3Small_CheckedChanged(object sender, EventArgs e)
        {
            OrderStart();
            if (rBt3Small.Checked == true)
            {
                orderNum = 3;
            }
        }

        private void OrderStart()
        {
            button1.ForeColor = Color.Black;
            button1.Enabled = true;
            gpBox2Soup.Enabled = true;
            gpBox3Noodle.Enabled = true;
            panel1Bonus.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostCalc();
            ShowOrderMsg();
        }
        private void CostCalc()
        {
            switch (orderNum)
            {
                case 1:
                    cost = 390;
                    orderMsg += "�W�ȸJ (390��)\n";
                    break;
                case 2:
                    cost = 310;
                    orderMsg += "���J (310��)\n";
                    break;
                case 3:
                    cost = 270;
                    orderMsg += "�g�A�J (270��)\n";
                    break;
            }
            if (rBt4VaryThick.Checked == true)
            {
                cost += 5;
                orderMsg += "���Y�G�W�@ (+5��)\n";
            }
            if (rBt5Thick.Checked == true) orderMsg += "���Y�G�S�@\n";
            if (rBt6Normal.Checked == true) orderMsg += "���Y�G���`\n";
            if (rBt7Bland.Checked == true) orderMsg += "���Y�G���H\n";
            if (checkBox1.Checked == true)
            {
                cost += 60;
                orderMsg += "�[�I�G���f���� (60��)\n";
            }
            if (checkBox2.Checked == true)
            {
                cost += 70;
                orderMsg += "�[�I�G�f�M�e�N�� (70��)\n";
            }
        }
        private void ShowOrderMsg()
        {
            MessageBox.Show($"{orderMsg}�`���B�G{cost}��\n\n���T�{�e�X�q��A���������s�I�\�C", "Order Check", MessageBoxButtons.OKCancel);
            if (DialogResult != DialogResult.OK)
            {
                cost = 0;
                return;
            }
            
        }
    }
}

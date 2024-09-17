namespace RaamenOrder
{
    public partial class Form1 : Form
    {
        public int cost = 0;
        public int orderNum = 0;
        public string orderMsg = "訂單確認：\n";
        public Form1()
        {
            InitializeComponent();
            string tableNum = Microsoft.VisualBasic.Interaction.InputBox("請輸入桌號：", "點餐系統", "0", 300, 500);
            Text += $"　桌號：{tableNum} ";
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
                    orderMsg += "超值碗 (390元)\n";
                    break;
                case 2:
                    cost = 310;
                    orderMsg += "中碗 (310元)\n";
                    break;
                case 3:
                    cost = 270;
                    orderMsg += "迷你碗 (270元)\n";
                    break;
            }
            if (rBt4VaryThick.Checked == true)
            {
                cost += 5;
                orderMsg += "湯頭：超濃 (+5元)\n";
            }
            if (rBt5Thick.Checked == true) orderMsg += "湯頭：特濃\n";
            if (rBt6Normal.Checked == true) orderMsg += "湯頭：正常\n";
            if (rBt7Bland.Checked == true) orderMsg += "湯頭：偏淡\n";
            if (checkBox1.Checked == true)
            {
                cost += 60;
                orderMsg += "加點：水逆唐揚雞 (60元)\n";
            }
            if (checkBox2.Checked == true)
            {
                cost += 70;
                orderMsg += "加點：黯然叉燒飯 (70元)\n";
            }
        }
        private void ShowOrderMsg()
        {
            MessageBox.Show($"{orderMsg}總金額：{cost}元\n\n按確認送出訂單，按取消重新點餐。", "Order Check", MessageBoxButtons.OKCancel);
            if (DialogResult != DialogResult.OK)
            {
                cost = 0;
                return;
            }
            
        }
    }
}

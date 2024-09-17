namespace ShoppingList
{
    // �ݳB�z�Ӹ` --- 
    // 1.Delete�����i�⪫�~�M����R���]�O�dDefault10�����~�H�^
    // 2.��J�s���~��Y�������U�s�W�A�s���~�W���|��ܡC

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            Text = "Living Technology - Shopping List";
        }

        const int maxGoodsNumber = 10;
        HashSet<string> goods = new HashSet<string> {
            "Arduino UNO R3", "LED", "�ѥ]�O" , "�����u�]��-���^",
            "�����u�]��-���^", "�����u�]��-���^", "LCD 1602", "DHT 11"
        };
        string[] numbers = new string[maxGoodsNumber];

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] goodsArray = goods.ToArray();
            for (int i = 0; i < maxGoodsNumber; i++) numbers[i] = $"{i + 1}";
            comboBox1Goods.Items.AddRange(goodsArray);
            comboBox1Goods.SelectedIndex = 0;
            comboBox2Number.Items.AddRange(numbers);
            comboBox2Number.SelectedIndex = 0;
            label1List.Text = "";
        }

        private void comboBox1Goods_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                comboBox1Goods.Text.ToLower();
                if (!goods.Contains(comboBox1Goods.Text))
                {
                    goods.Add(comboBox1Goods.Text);
                    comboBox1Goods.Items.Add(comboBox1Goods.Text);
                }
            }
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            label1List.Text += $"{comboBox1Goods.SelectedItem}�@�ѡ@{comboBox2Number.SelectedItem}\n";
        }

        private void button2Clear_Click(object sender, EventArgs e)
        {
            label1List.Text = "";
        }

        private void comboBox1Goods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (comboBox1Goods.SelectedItem != null)
                {
                    string itemToRemove = comboBox1Goods.SelectedItem.ToString();
                    goods.Remove(itemToRemove);
                    comboBox1Goods.Items.Remove(itemToRemove);

                    if (comboBox1Goods.Items.Count > 0)
                    {
                        comboBox1Goods.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox1Goods.Text = "";
                    }

                    e.Handled = true;
                }
            }
        }
    }
}

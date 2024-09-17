namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateSquares();
            Application.Exit();
        }

        private void CalculateSquares()
        {
            while (true)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("輸入任一數字後按下確定，可輸出其平方。\n輸入 'q' 退出程式。\n請輸入數值：", "求平方程式", "請輸入數字");

                if (string.IsNullOrEmpty(input) || input.ToLower() == "q")
                {
                    // 使用者取消了輸入或選擇退出
                    var confirm = MessageBox.Show("確定要結束程式嗎？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (confirm == DialogResult.OK) return;
                }

                try
                {
                    var number = decimal.Parse(input);
                    var square = number * number;
                    var result = MessageBox.Show($"{number} 的平方是：{square}\n\n是否要繼續計算？", "運算結果", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return; // 使用者選擇不繼續，結束程式
                    }
                    // 如果使用者選擇繼續，while 循環會重新開始
                }
                catch (FormatException)
                {
                    MessageBox.Show("請輸入有效的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
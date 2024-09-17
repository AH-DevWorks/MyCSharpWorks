namespace ScoreCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = $"座號：\t計算機概論：\t程式設計：\t\n";
            for (int i = 1; i <= 3; i++)
            {
                msg += $"{i}號\t";
                for (int j = 1; j <= 2; j++)
                {
                    string title = (j == 1) ? "計算機概論" : "程式設計";
                    float.TryParse(Microsoft.VisualBasic.Interaction.InputBox($"輸入你的【{title}】成績 : ", title, $"{i}號成績", 350, 350), out float scr);
                    if(scr >=0f && scr <=100f)
                    {
                        msg += $"{scr}\t\t";
                    }
                    else
                    {
                        msg += $"{scr}[※異常]\t\t";
                    }
                }
                msg += "\n";
            }
            MessageBox.Show($"{msg}", "成績單");
            Application.Exit();
        }
    }
}

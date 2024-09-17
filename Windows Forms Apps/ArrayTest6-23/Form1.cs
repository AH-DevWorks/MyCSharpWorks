namespace ArrayTest906
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] score = new double[0];
        string s = "";
        double sum = 0;
        double avg = 0;
        bool calcOrNot = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            ScoreInput();
            if (score.Length > 0)   ScoreCalc();
        }
        private void ScoreInput()
        {
            bool continueInput = true;
            do
            {
                s = Microsoft.VisualBasic.Interaction.InputBox("Type in your Score:\n\n*Type space or empty to Start Calculation*");

                if (s == null) // 按下取消鈕時
                {
                    CheckExit();
                    return;
                }

                if (string.IsNullOrWhiteSpace(s)) // 輸入空白或直接按enter
                {
                    if (score.Length > 0) // 至少輸入了一個數字
                    {
                        continueInput = false;
                    }
                    else
                    {
                        WarningMsg("Please enter at least one score before calculation.");
                    }
                }
                else if (double.TryParse(s, out double sc))
                {
                    if (sc >= 0 && sc <= 100)
                    {
                        Array.Resize(ref score, score.Length + 1);
                        score[score.Length - 1] = sc;
                    }
                    else
                    {
                        WarningMsg("Score can only be between 0 and 100.");
                    }
                }
                else
                {
                    WarningMsg("Invalid input. Please enter a number.");
                }
            } while (continueInput);
        }

        private void CheckExit()
        {
            DialogResult result = MessageBox.Show("Do you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                ScoreInput(); // 如果使用者不想退出，重新開始輸入
            }
        }
        private void WarningMsg(string msg)
        {
            MessageBox.Show($"Error: {msg}");
        }
        private void ScoreCalc()
        {
            foreach (double score in score) sum += score;
            avg = sum / score.Length;
            DialogResult dr = MessageBox.Show($"Total Score:\t {sum}\nAverage Score:\t {avg:F2}\n\nRestart?", "Score List", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Restart();
            }
            else
            {
                Thread.Sleep(400);
                Application.Exit();
            }
        }
        private void Restart()
        {
            Array.Resize<double>(ref score, 0);
            s = "";
            sum = 0;
            avg = 0;
            ScoreInput();
            ScoreCalc();
        }
    }
}

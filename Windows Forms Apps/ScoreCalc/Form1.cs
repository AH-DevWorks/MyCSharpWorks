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
            string msg = $"�y���G\t�p������סG\t�{���]�p�G\t\n";
            for (int i = 1; i <= 3; i++)
            {
                msg += $"{i}��\t";
                for (int j = 1; j <= 2; j++)
                {
                    string title = (j == 1) ? "�p�������" : "�{���]�p";
                    float.TryParse(Microsoft.VisualBasic.Interaction.InputBox($"��J�A���i{title}�j���Z : ", title, $"{i}�����Z", 350, 350), out float scr);
                    if(scr >=0f && scr <=100f)
                    {
                        msg += $"{scr}\t\t";
                    }
                    else
                    {
                        msg += $"{scr}[�����`]\t\t";
                    }
                }
                msg += "\n";
            }
            MessageBox.Show($"{msg}", "���Z��");
            Application.Exit();
        }
    }
}

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
                string input = Microsoft.VisualBasic.Interaction.InputBox("��J���@�Ʀr����U�T�w�A�i��X�䥭��C\n��J 'q' �h�X�{���C\n�п�J�ƭȡG", "�D����{��", "�п�J�Ʀr");

                if (string.IsNullOrEmpty(input) || input.ToLower() == "q")
                {
                    // �ϥΪ̨����F��J�ο�ܰh�X
                    var confirm = MessageBox.Show("�T�w�n�����{���ܡH", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (confirm == DialogResult.OK) return;
                }

                try
                {
                    var number = decimal.Parse(input);
                    var square = number * number;
                    var result = MessageBox.Show($"{number} ������O�G{square}\n\n�O�_�n�~��p��H", "�B�⵲�G", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return; // �ϥΪ̿�ܤ��~��A�����{��
                    }
                    // �p�G�ϥΪ̿���~��Awhile �`���|���s�}�l
                }
                catch (FormatException)
                {
                    MessageBox.Show("�п�J���Ī��Ʀr�C", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
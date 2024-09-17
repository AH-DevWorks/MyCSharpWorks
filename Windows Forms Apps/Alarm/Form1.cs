namespace Alarm
{
    public partial class Form1 : Form
    {
        string timeNow = "";

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now.AddMinutes(1);
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(7);
            dateTimePicker1.ShowUpDown = true;
            bt2Reset.Enabled = false;
            timer1.Enabled = false;
            timer1.Interval = 1000;   // 啟動後每秒判斷一次
            timer2.Enabled = true; //現在時間計時器（常開）
            timer2.Interval = 1000;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bt2Reset.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bt2Reset.Enabled = true;
        }

        private void button1Set_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            // 避免使用者重複選取
            button1Set.Enabled = false;
            bt2Reset.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void bt2Reset_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMinutes(1);
            textBox1.Clear();
            bt2Reset.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                timer1.Enabled = false;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show($"{textBox1.Text}", "Time's UP", MessageBoxButtons.OK);
                dateTimePicker1.Value = DateTime.Now.AddMinutes(1);
                dateTimePicker1.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeNow = DateTime.Now.ToString("yyyy年MM月dd日(ddd) HH:mm:ss");
            label3TimeNow.Text = $"現在時間：\t{timeNow}";
        }
    }
}

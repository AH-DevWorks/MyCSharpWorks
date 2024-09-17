namespace ResortStayDateSelector
{
    public partial class Form1 : Form
    {
        // 若程式不供「非會員」訂位，可一開始就不將其列入選項
        // 或設定須先輸入會員帳密才可使用
        // 但此處為練習題要求，故仍列入
        string[] membershipList = { "一般會員（5天）", "高級會員（12天）", "尊爵會員（21天）", "非會員（0天）" };
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbBox1MembershipLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace BookLending
{
    public partial class Form1 : Form
    {
        HashSet<string> bookList = new HashSet<string> {
            "Leo Tolstoy - War and Peace",
            "Gabriel G.Marquez - One Hundred Years of Solitude",
            "Jane Austen - Pride and Prejudice",
            "Fyodor Dostoevsky - Crime and Punishment",
            "Cao Xueqin - Dream of the Red Chamber",
            "Harper Lee - To Kill a Mockingbird",
            "Miguel de Cervantes - Don Quixote",
            "Virginia Woolf - Mrs Dalloway",
            "Murasaki Shikibu - The Tale of Genji",
            "Franz Kafka - The Metamorphosis",
            "Chinua Achebe - Things Fall Apart"
        };
        const int bookTotalNumber = 11;
        const int MaxLendNumber = 5;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            Text = "Book Lending System - ABC Library";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] bookArray = bookList.ToArray();
            Array.Sort(bookArray);
            checkedListBox1.Items.AddRange(bookArray);
            label1.Text = "*NOITCE*\nEveryone can ONLY lend up to 5 books each time.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) return;

            if (checkedListBox1.CheckedItems.Count + checkedListBox2.Items.Count > MaxLendNumber)
            {
                MessageBox.Show($"Lending over {MaxLendNumber} books!\nPlease remove some and try again :)","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SelectedBookMove(checkedListBox1, checkedListBox2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count == 0) return;
            SelectedBookMove(checkedListBox2, checkedListBox1);

            SortBookOnHand(checkedListBox1);
            
            if (checkedListBox2.Items.Count == 0)
            {
                button2.Enabled = false;
                button2.ForeColor = Color.DarkGray;
            }
         }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox2.Items.Count != 0)
            {
                button2.Enabled = true;
                button2.ForeColor = Color.Black;
            }
        }
        
        private void SelectedBookMove(CheckedListBox start, CheckedListBox destination)
        {
            //For迴圈從從列表的末尾開始向前遍歷，不從0開始 --- 避免因移除項目導致的索引變化問題
            for (int i = start.Items.Count - 1; i >= 0; i--)
            {
                if (start.GetItemChecked(i))
                {
                    destination.Items.Add(start.Items[i]);
                    start.Items.RemoveAt(i); // 已知要移除的項目的確切索引 --- 用 RemoveAt
                }
            }
        }
        private void SortBookOnHand(CheckedListBox boh)
        {
            string[] bookOnHand = new string[boh.Items.Count];
            boh.Items.CopyTo(bookOnHand, 0);
            Array.Sort(bookOnHand);
            boh.Items.Clear();
            boh.Items.AddRange(bookOnHand);
        }
    }
}

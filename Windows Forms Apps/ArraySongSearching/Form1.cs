namespace ArraySongSearching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        const int elementNum = 15;
        string[] singerNames = new string[elementNum]
        {
            "Emma Thompson", "Carlos Rodriguez", "Yuki Tanaka", "Sophie Dubois", "Ahmed Hassan",
            "Olivia Chen", "Ivan Petrov", "Maria Garcia", "Hans Schmidt", "Ava Johnson",
            "Liam O'Connor", "Zoe Nguyen", "Raj Patel", "Astrid Larsson", "Kwesi Mensah"
        };
        string[] songTitles = new string[elementNum]
        {
            "Midnight Whisper", "Sunflower Dreams", "Neon Heartbeat", "Ocean's Lullaby", "Electric Sky",
            "Velvet Moon", "Crimson Horizon", "Emerald Forest", "Silver Linings", "Golden Echoes",
            "Sapphire Waves", "Diamond Dust", "Ruby Sunset", "Amethyst Dawn", "Ivory Twilight"
        };
        int[] songRankings = { 3, 7, 12, 1, 9, 15, 6, 11, 2, 8, 4, 14, 5, 10, 13 };


        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Best Song Ranking";
            textBox1Search.Text = "Searching for Singers or Songs.";
            textBox1Search.ForeColor = Color.DarkGray;
            LabelsClear();
            SortByRanking();
            ShowList();
        }

        private void button2SortbyRank_Click(object sender, EventArgs e)
        {
            LabelsClear();
            SortByRanking();
            ShowList();
        }
        private void button2SortbyName_Click(object sender, EventArgs e)
        {
            LabelsClear();
            SortByName();
            ShowList();
        }

        private void button2SortbySong_Click(object sender, EventArgs e)
        {
            LabelsClear();
            SortByTitle();
            ShowList();
        }

        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            textBox1Search.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(textBox1Search.Text))
            {
                LabelsClear();
                SortByRanking();
                ShowList();
            }
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1Search.Text) || string.IsNullOrWhiteSpace(textBox1Search.Text))
            {
                ShowErrorMsg("Please type at least one word.");
            }
            else
            {
                DoSearch();
            }
        }

        private void LabelsClear()
        {
            label1Ranking.Text = "";
            label2Names.Text = "";
            label3Songs.Text = "";
        }
        private void SortByRanking()
        {
            int[] temp = new int[elementNum];
            Array.Copy(songRankings, temp, elementNum);
            Array.Sort(songRankings, singerNames);
            Array.Sort(temp, songTitles);
        }
        private void SortByName()
        {
            int[] oriNum = new int[elementNum];
            for (int i = 0; i < elementNum; i++) oriNum[i] = i;
            Array.Sort(singerNames, oriNum);

            string[] tempTitles = new string[elementNum];
            int[] tempRankings = new int[elementNum];
            for (int t = 0; t < elementNum; t++)
            {
                tempTitles[t] = songTitles[oriNum[t]];
                tempRankings[t] = songRankings[oriNum[t]];
            }
            Array.Copy(tempTitles, songTitles, elementNum);
            Array.Copy(tempRankings, songRankings, elementNum);
        }
        private void SortByTitle()
        {
            int[] oriNum = new int[elementNum];
            for (int i = 0; i < elementNum; i++) oriNum[i] = i;
            Array.Sort(songTitles, oriNum);

            string[] tempNames = new string[elementNum];
            int[] tempRankings = new int[elementNum];

            for (int t = 0; t < elementNum; t++)
            {
                tempNames[t] = singerNames[oriNum[t]];
                tempRankings[t] = songRankings[oriNum[t]];
            }
            Array.Copy(tempNames, singerNames, elementNum);
            Array.Copy(tempRankings, songRankings, elementNum);
        }
        private void ShowList()
        {
            for (int r = 0; r < songRankings.Length; r++) label1Ranking.Text += $"{songRankings[r],3}\n";
            for (int n = 0; n < singerNames.Length; n++) label2Names.Text += $"{singerNames[n],-15}\n";
            for (int t = 0; t < songTitles.Length; t++) label3Songs.Text += $"{songTitles[t]}\n";
        }

        private void ShowErrorMsg(string msg)
        {
            textBox1Search.Text = $"ERROR: {msg}";
        }

        private void DoSearch()
        {
            string searchText = textBox1Search.Text.ToLower();
            string rankResult = "";
            string singerResult = "";
            string songResult = "";
            HashSet<int> addedIndices = new HashSet<int>();

            for (int i = 0; i < elementNum; i++)
            {
                if ((singerNames[i].ToLower().Contains(searchText) ||
                     songTitles[i].ToLower().Contains(searchText)) &&
                    !addedIndices.Contains(i))
                {
                    addedIndices.Add(i);
                    rankResult += $"{songRankings[i],3}\n";
                    singerResult += $"{singerNames[i],-15}\n";
                    songResult += $"{songTitles[i]}\n";
                }
            }
            ShowSearchResult(rankResult, singerResult, songResult);
        }

        private void ShowSearchResult(string n0, string n1, string n2)
        {
            LabelsClear();
            label1Ranking.Text = n0;
            label2Names.Text = n1;
            label3Songs.Text = n2;
        }
    }
}

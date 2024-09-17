namespace ArraySongSearching
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1Ranking = new Label();
            label2Names = new Label();
            label3Songs = new Label();
            textBox1Search = new TextBox();
            button1Search = new Button();
            button2SortbyName = new Button();
            button2SortbySong = new Button();
            label4SortText = new Label();
            button2SortbyRank = new Button();
            SuspendLayout();
            // 
            // label1Ranking
            // 
            label1Ranking.BackColor = Color.FromArgb(224, 224, 224);
            label1Ranking.BorderStyle = BorderStyle.FixedSingle;
            label1Ranking.Font = new Font("Cascadia Code", 9.75F);
            label1Ranking.Location = new Point(11, 47);
            label1Ranking.Name = "label1Ranking";
            label1Ranking.Size = new Size(37, 272);
            label1Ranking.TabIndex = 0;
            label1Ranking.Text = "label1Rankings";
            // 
            // label2Names
            // 
            label2Names.BackColor = Color.FromArgb(224, 224, 224);
            label2Names.BorderStyle = BorderStyle.FixedSingle;
            label2Names.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2Names.Location = new Point(67, 47);
            label2Names.Name = "label2Names";
            label2Names.Size = new Size(176, 272);
            label2Names.TabIndex = 1;
            label2Names.Text = "label2SingerNames";
            // 
            // label3Songs
            // 
            label3Songs.BackColor = Color.FromArgb(224, 224, 224);
            label3Songs.BorderStyle = BorderStyle.FixedSingle;
            label3Songs.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3Songs.Location = new Point(262, 47);
            label3Songs.Name = "label3Songs";
            label3Songs.Size = new Size(225, 272);
            label3Songs.TabIndex = 2;
            label3Songs.Text = "label3Songs";
            // 
            // textBox1Search
            // 
            textBox1Search.Font = new Font("源雲明體 SB", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1Search.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1Search.Location = new Point(12, 12);
            textBox1Search.Name = "textBox1Search";
            textBox1Search.Size = new Size(372, 22);
            textBox1Search.TabIndex = 3;
            textBox1Search.TextChanged += textBox1Search_TextChanged;
            // 
            // button1Search
            // 
            button1Search.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1Search.Location = new Point(400, 11);
            button1Search.Name = "button1Search";
            button1Search.Size = new Size(90, 26);
            button1Search.TabIndex = 4;
            button1Search.Text = "Search";
            button1Search.UseVisualStyleBackColor = true;
            button1Search.Click += button1Search_Click;
            // 
            // button2SortbyName
            // 
            button2SortbyName.Font = new Font("Microsoft JhengHei UI", 9.75F);
            button2SortbyName.Location = new Point(505, 248);
            button2SortbyName.Name = "button2SortbyName";
            button2SortbyName.Size = new Size(69, 26);
            button2SortbyName.TabIndex = 5;
            button2SortbyName.Text = "Singer";
            button2SortbyName.UseVisualStyleBackColor = true;
            button2SortbyName.Click += button2SortbyName_Click;
            // 
            // button2SortbySong
            // 
            button2SortbySong.Font = new Font("Microsoft JhengHei UI", 9.75F);
            button2SortbySong.Location = new Point(505, 290);
            button2SortbySong.Name = "button2SortbySong";
            button2SortbySong.Size = new Size(69, 26);
            button2SortbySong.TabIndex = 6;
            button2SortbySong.Text = "Songs";
            button2SortbySong.UseVisualStyleBackColor = true;
            button2SortbySong.Click += button2SortbySong_Click;
            // 
            // label4SortText
            // 
            label4SortText.AutoSize = true;
            label4SortText.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4SortText.Location = new Point(505, 175);
            label4SortText.Name = "label4SortText";
            label4SortText.Size = new Size(58, 17);
            label4SortText.TabIndex = 7;
            label4SortText.Text = "Sort by :";
            // 
            // button2SortbyRank
            // 
            button2SortbyRank.Font = new Font("Microsoft JhengHei UI", 9.75F);
            button2SortbyRank.Location = new Point(505, 206);
            button2SortbyRank.Name = "button2SortbyRank";
            button2SortbyRank.Size = new Size(69, 26);
            button2SortbyRank.TabIndex = 8;
            button2SortbyRank.Text = "Rank";
            button2SortbyRank.UseVisualStyleBackColor = true;
            button2SortbyRank.Click += button2SortbyRank_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 328);
            Controls.Add(button2SortbyRank);
            Controls.Add(label4SortText);
            Controls.Add(button2SortbySong);
            Controls.Add(button2SortbyName);
            Controls.Add(button1Search);
            Controls.Add(textBox1Search);
            Controls.Add(label3Songs);
            Controls.Add(label2Names);
            Controls.Add(label1Ranking);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1Ranking;
        private Label label2Names;
        private Label label3Songs;
        private TextBox textBox1Search;
        private Button button1Search;
        private Button button2SortbyName;
        private Button button2SortbySong;
        private Label label4SortText;
        private Button button2SortbyRank;
    }
}

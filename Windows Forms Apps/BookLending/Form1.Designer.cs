namespace BookLending
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
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Lucida Sans", 11F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(29, 29);
            checkedListBox1.Margin = new Padding(7, 7, 7, 7);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(648, 488);
            checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.Font = new Font("Lucida Sans", 11F);
            checkedListBox2.ForeColor = Color.MidnightBlue;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.HorizontalScrollbar = true;
            checkedListBox2.Location = new Point(1107, 29);
            checkedListBox2.Margin = new Padding(7, 7, 7, 7);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(648, 488);
            checkedListBox2.TabIndex = 1;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(731, 247);
            button1.Margin = new Padding(7, 7, 7, 7);
            button1.Name = "button1";
            button1.Size = new Size(328, 86);
            button1.TabIndex = 2;
            button1.Text = "Bulk Lending >>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Microsoft JhengHei UI", 9.75F);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(731, 434);
            button2.Margin = new Padding(7, 7, 7, 7);
            button2.Name = "button2";
            button2.Size = new Size(328, 86);
            button2.TabIndex = 3;
            button2.Text = "<< Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(731, 53);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 134);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1792, 571);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Margin = new Padding(7, 7, 7, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}

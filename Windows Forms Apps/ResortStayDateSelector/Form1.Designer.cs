namespace ResortStayDateSelector
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
            lblRegisteredMembersOnly = new Label();
            lb2MembershipSelectMsg = new Label();
            cbBox1MembershipLevel = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            lb3DateSelectMsg = new Label();
            bt1Reset = new Button();
            bt2Confirm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblRegisteredMembersOnly
            // 
            lblRegisteredMembersOnly.Font = new Font("源樣明體 TTF Medium", 8.144796F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblRegisteredMembersOnly.Location = new Point(32, 218);
            lblRegisteredMembersOnly.Name = "lblRegisteredMembersOnly";
            lblRegisteredMembersOnly.Size = new Size(372, 67);
            lblRegisteredMembersOnly.TabIndex = 0;
            lblRegisteredMembersOnly.Text = "※本系統僅供註冊會員使用，若您尚未註冊，請洽客服人員";
            // 
            // lb2MembershipSelectMsg
            // 
            lb2MembershipSelectMsg.AutoSize = true;
            lb2MembershipSelectMsg.Font = new Font("源樣明體 TTF Medium", 10.0995474F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lb2MembershipSelectMsg.Location = new Point(32, 93);
            lb2MembershipSelectMsg.Name = "lb2MembershipSelectMsg";
            lb2MembershipSelectMsg.Size = new Size(335, 35);
            lb2MembershipSelectMsg.TabIndex = 1;
            lb2MembershipSelectMsg.Text = "請選擇您的會員等級：";
            lb2MembershipSelectMsg.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbBox1MembershipLevel
            // 
            cbBox1MembershipLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBox1MembershipLevel.Font = new Font("Microsoft JhengHei UI", 10.0995474F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cbBox1MembershipLevel.FormattingEnabled = true;
            cbBox1MembershipLevel.Location = new Point(32, 145);
            cbBox1MembershipLevel.Name = "cbBox1MembershipLevel";
            cbBox1MembershipLevel.Size = new Size(335, 48);
            cbBox1MembershipLevel.TabIndex = 2;
            cbBox1MembershipLevel.SelectedIndexChanged += cbBox1MembershipLevel_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Window;
            monthCalendar1.Font = new Font("Microsoft JhengHei UI", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point, 136);
            monthCalendar1.Location = new Point(432, 145);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // lb3DateSelectMsg
            // 
            lb3DateSelectMsg.AutoSize = true;
            lb3DateSelectMsg.Font = new Font("源樣明體 TTF Medium", 10.0995474F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lb3DateSelectMsg.Location = new Point(432, 93);
            lb3DateSelectMsg.Name = "lb3DateSelectMsg";
            lb3DateSelectMsg.Size = new Size(399, 35);
            lb3DateSelectMsg.TabIndex = 4;
            lb3DateSelectMsg.Text = "請選擇您的入住起訖日期：";
            lb3DateSelectMsg.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bt1Reset
            // 
            bt1Reset.ForeColor = Color.FromArgb(64, 64, 64);
            bt1Reset.Location = new Point(32, 446);
            bt1Reset.Name = "bt1Reset";
            bt1Reset.Size = new Size(149, 53);
            bt1Reset.TabIndex = 5;
            bt1Reset.Text = "重置";
            bt1Reset.UseVisualStyleBackColor = true;
            // 
            // bt2Confirm
            // 
            bt2Confirm.Font = new Font("Microsoft JhengHei UI", 9.122172F, FontStyle.Bold, GraphicsUnit.Point, 136);
            bt2Confirm.ForeColor = Color.Black;
            bt2Confirm.Location = new Point(218, 446);
            bt2Confirm.Name = "bt2Confirm";
            bt2Confirm.Size = new Size(149, 53);
            bt2Confirm.TabIndex = 6;
            bt2Confirm.Text = "確認預定";
            bt2Confirm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("凝書體 3.1 Regular", 13.0316744F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(580, 46);
            label1.TabIndex = 7;
            label1.Text = "天天都渡假村——會員預定系統";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(915, 538);
            Controls.Add(label1);
            Controls.Add(bt2Confirm);
            Controls.Add(bt1Reset);
            Controls.Add(lb3DateSelectMsg);
            Controls.Add(monthCalendar1);
            Controls.Add(cbBox1MembershipLevel);
            Controls.Add(lb2MembershipSelectMsg);
            Controls.Add(lblRegisteredMembersOnly);
            Name = "Form1";
            Text = "Resort Membership Date Booking";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisteredMembersOnly;
        private Label lb2MembershipSelectMsg;
        private ComboBox cbBox1MembershipLevel;
        private MonthCalendar monthCalendar1;
        private Label lb3DateSelectMsg;
        private Button bt1Reset;
        private Button bt2Confirm;
        private Label label1;
    }
}

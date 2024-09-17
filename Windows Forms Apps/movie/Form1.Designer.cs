namespace movie
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
            Lb1ST = new Label();
            Lb2DT = new Label();
            Lb3UP = new Label();
            Lb4Num = new Label();
            Lb5Total = new Label();
            STPrice = new Label();
            Lb6STTC = new Label();
            STNumBox = new TextBox();
            DTNumBox = new TextBox();
            DTPrice = new Label();
            Lb7DTTC = new Label();
            LB8TtCt = new Label();
            SuspendLayout();
            // 
            // Lb1ST
            // 
            Lb1ST.AutoSize = true;
            Lb1ST.BackColor = Color.FromArgb(255, 255, 192);
            Lb1ST.Font = new Font("Cascadia Code SemiLight", 12F);
            Lb1ST.Location = new Point(29, 156);
            Lb1ST.Margin = new Padding(7, 0, 7, 0);
            Lb1ST.Name = "Lb1ST";
            Lb1ST.Size = new Size(352, 49);
            Lb1ST.TabIndex = 0;
            Lb1ST.Text = "Standard Ticket";
            // 
            // Lb2DT
            // 
            Lb2DT.AutoSize = true;
            Lb2DT.BackColor = Color.FromArgb(255, 255, 192);
            Lb2DT.Font = new Font("Cascadia Code SemiLight", 12F);
            Lb2DT.Location = new Point(29, 259);
            Lb2DT.Margin = new Padding(7, 0, 7, 0);
            Lb2DT.Name = "Lb2DT";
            Lb2DT.Size = new Size(396, 49);
            Lb2DT.TabIndex = 1;
            Lb2DT.Text = "Discounted Ticket";
            // 
            // Lb3UP
            // 
            Lb3UP.AutoSize = true;
            Lb3UP.BackColor = Color.FromArgb(255, 255, 192);
            Lb3UP.Font = new Font("Cascadia Code SemiLight", 11.25F);
            Lb3UP.Location = new Point(406, 65);
            Lb3UP.Margin = new Padding(7, 0, 7, 0);
            Lb3UP.Name = "Lb3UP";
            Lb3UP.Size = new Size(230, 46);
            Lb3UP.TabIndex = 2;
            Lb3UP.Text = "Unit Price";
            // 
            // Lb4Num
            // 
            Lb4Num.AutoSize = true;
            Lb4Num.BackColor = Color.FromArgb(255, 255, 192);
            Lb4Num.Font = new Font("Cascadia Code SemiLight", 11.25F);
            Lb4Num.Location = new Point(753, 65);
            Lb4Num.Margin = new Padding(7, 0, 7, 0);
            Lb4Num.Name = "Lb4Num";
            Lb4Num.Size = new Size(146, 46);
            Lb4Num.TabIndex = 3;
            Lb4Num.Text = "Pieces";
            // 
            // Lb5Total
            // 
            Lb5Total.AutoSize = true;
            Lb5Total.BackColor = Color.FromArgb(255, 255, 192);
            Lb5Total.Font = new Font("Cascadia Code SemiLight", 11.25F);
            Lb5Total.Location = new Point(1037, 65);
            Lb5Total.Margin = new Padding(7, 0, 7, 0);
            Lb5Total.Name = "Lb5Total";
            Lb5Total.Size = new Size(230, 46);
            Lb5Total.TabIndex = 4;
            Lb5Total.Text = "Total Cost";
            // 
            // STPrice
            // 
            STPrice.AutoSize = true;
            STPrice.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            STPrice.Location = new Point(471, 163);
            STPrice.Margin = new Padding(7, 0, 7, 0);
            STPrice.Name = "STPrice";
            STPrice.Size = new Size(71, 40);
            STPrice.TabIndex = 5;
            STPrice.Text = "250";
            STPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb6STTC
            // 
            Lb6STTC.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Lb6STTC.BorderStyle = BorderStyle.FixedSingle;
            Lb6STTC.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb6STTC.ForeColor = SystemColors.ControlDarkDark;
            Lb6STTC.Location = new Point(1015, 158);
            Lb6STTC.Margin = new Padding(7, 0, 7, 0);
            Lb6STTC.Name = "Lb6STTC";
            Lb6STTC.Size = new Size(259, 43);
            Lb6STTC.TabIndex = 6;
            Lb6STTC.Text = "Full Admis.";
            Lb6STTC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // STNumBox
            // 
            STNumBox.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            STNumBox.Location = new Point(709, 151);
            STNumBox.Margin = new Padding(7);
            STNumBox.Name = "STNumBox";
            STNumBox.Size = new Size(237, 48);
            STNumBox.TabIndex = 7;
            STNumBox.TextAlign = HorizontalAlignment.Center;
            STNumBox.TextChanged += FANumBox_TextChanged;
            // 
            // DTNumBox
            // 
            DTNumBox.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTNumBox.Location = new Point(709, 259);
            DTNumBox.Margin = new Padding(7);
            DTNumBox.Name = "DTNumBox";
            DTNumBox.Size = new Size(237, 48);
            DTNumBox.TabIndex = 8;
            DTNumBox.TextAlign = HorizontalAlignment.Center;
            DTNumBox.TextChanged += CTNumBox_TextChanged;
            // 
            // DTPrice
            // 
            DTPrice.AutoSize = true;
            DTPrice.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPrice.Location = new Point(471, 264);
            DTPrice.Margin = new Padding(7, 0, 7, 0);
            DTPrice.Name = "DTPrice";
            DTPrice.Size = new Size(71, 40);
            DTPrice.TabIndex = 9;
            DTPrice.Text = "200";
            DTPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb7DTTC
            // 
            Lb7DTTC.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Lb7DTTC.BorderStyle = BorderStyle.FixedSingle;
            Lb7DTTC.Font = new Font("Cascadia Code SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb7DTTC.ForeColor = SystemColors.ControlDarkDark;
            Lb7DTTC.Location = new Point(1015, 269);
            Lb7DTTC.Margin = new Padding(7, 0, 7, 0);
            Lb7DTTC.Name = "Lb7DTTC";
            Lb7DTTC.Size = new Size(259, 43);
            Lb7DTTC.TabIndex = 10;
            Lb7DTTC.Text = "Conces. Cost";
            Lb7DTTC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LB8TtCt
            // 
            LB8TtCt.BackColor = Color.FromArgb(192, 192, 255);
            LB8TtCt.BorderStyle = BorderStyle.Fixed3D;
            LB8TtCt.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB8TtCt.ForeColor = Color.FromArgb(64, 64, 64);
            LB8TtCt.Location = new Point(709, 338);
            LB8TtCt.Margin = new Padding(7, 0, 7, 0);
            LB8TtCt.Name = "LB8TtCt";
            LB8TtCt.Size = new Size(568, 72);
            LB8TtCt.TabIndex = 11;
            LB8TtCt.Text = "(Total Cost)";
            LB8TtCt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 432);
            Controls.Add(LB8TtCt);
            Controls.Add(Lb7DTTC);
            Controls.Add(DTPrice);
            Controls.Add(DTNumBox);
            Controls.Add(STNumBox);
            Controls.Add(Lb6STTC);
            Controls.Add(STPrice);
            Controls.Add(Lb5Total);
            Controls.Add(Lb4Num);
            Controls.Add(Lb3UP);
            Controls.Add(Lb2DT);
            Controls.Add(Lb1ST);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Ticket Cost Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb1ST;
        private Label Lb2DT;
        private Label Lb3UP;
        private Label Lb4Num;
        private Label Lb5Total;
        private Label STPrice;
        private Label Lb6STTC;
        private TextBox STNumBox;
        private TextBox DTNumBox;
        private Label DTPrice;
        private Label Lb7DTTC;
        private Label LB8TtCt;
    }
}

namespace ShoppingList
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
            comboBox1Goods = new ComboBox();
            label1List = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2Number = new ComboBox();
            button1Add = new Button();
            button2Clear = new Button();
            SuspendLayout();
            // 
            // comboBox1Goods
            // 
            comboBox1Goods.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox1Goods.FormattingEnabled = true;
            comboBox1Goods.Location = new Point(177, 29);
            comboBox1Goods.Margin = new Padding(7, 7, 7, 7);
            comboBox1Goods.MaxDropDownItems = 5;
            comboBox1Goods.Name = "comboBox1Goods";
            comboBox1Goods.Size = new Size(320, 46);
            comboBox1Goods.TabIndex = 0;
            comboBox1Goods.KeyDown += comboBox1Goods_KeyDown;
            comboBox1Goods.KeyPress += comboBox1Goods_KeyPress;
            // 
            // label1List
            // 
            label1List.BackColor = Color.FromArgb(230, 230, 230);
            label1List.BorderStyle = BorderStyle.Fixed3D;
            label1List.Font = new Font("微軟正黑體", 9.5F);
            label1List.Location = new Point(551, 29);
            label1List.Margin = new Padding(7, 0, 7, 0);
            label1List.Name = "label1List";
            label1List.Size = new Size(590, 319);
            label1List.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(39, 41);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 39);
            label2.TabIndex = 2;
            label2.Text = "品項：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(39, 166);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 39);
            label3.TabIndex = 3;
            label3.Text = "數量：";
            // 
            // comboBox2Number
            // 
            comboBox2Number.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2Number.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox2Number.FormattingEnabled = true;
            comboBox2Number.Location = new Point(177, 154);
            comboBox2Number.Margin = new Padding(7, 7, 7, 7);
            comboBox2Number.MaxDropDownItems = 5;
            comboBox2Number.Name = "comboBox2Number";
            comboBox2Number.Size = new Size(320, 46);
            comboBox2Number.TabIndex = 4;
            // 
            // button1Add
            // 
            button1Add.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1Add.Location = new Point(61, 274);
            button1Add.Margin = new Padding(7, 7, 7, 7);
            button1Add.Name = "button1Add";
            button1Add.Size = new Size(182, 74);
            button1Add.TabIndex = 5;
            button1Add.Text = "確認添加";
            button1Add.UseVisualStyleBackColor = true;
            button1Add.Click += button1Add_Click;
            // 
            // button2Clear
            // 
            button2Clear.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2Clear.Location = new Point(304, 274);
            button2Clear.Margin = new Padding(7, 7, 7, 7);
            button2Clear.Name = "button2Clear";
            button2Clear.Size = new Size(182, 74);
            button2Clear.TabIndex = 6;
            button2Clear.Text = "清空列表";
            button2Clear.UseVisualStyleBackColor = true;
            button2Clear.Click += button2Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 386);
            Controls.Add(button2Clear);
            Controls.Add(button1Add);
            Controls.Add(comboBox2Number);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1List);
            Controls.Add(comboBox1Goods);
            Margin = new Padding(7, 7, 7, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1Goods;
        private Label label1List;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2Number;
        private Button button1Add;
        private Button button2Clear;
    }
}

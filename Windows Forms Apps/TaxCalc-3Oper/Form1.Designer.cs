namespace TaxCalc_3Oper
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
            label1 = new Label();
            txBoxIncome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbTaxRate = new Label();
            lbTax = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("源雲明體 SB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(232, 18);
            label1.TabIndex = 0;
            label1.Text = "請輸入您的年度總收入（元）：";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txBoxIncome
            // 
            txBoxIncome.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txBoxIncome.Location = new Point(18, 50);
            txBoxIncome.MaxLength = 15;
            txBoxIncome.Name = "txBoxIncome";
            txBoxIncome.Size = new Size(343, 30);
            txBoxIncome.TabIndex = 1;
            txBoxIncome.TextAlign = HorizontalAlignment.Right;
            txBoxIncome.TextChanged += txBoxIncome_TextChanged;
            txBoxIncome.KeyPress += txBoxIncome_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("源雲明體 SB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(18, 139);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 2;
            label2.Text = "您的稅率：";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("源雲明體 SB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(18, 183);
            label3.Name = "label3";
            label3.Size = new Size(104, 18);
            label3.TabIndex = 3;
            label3.Text = "應繳納稅金：";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTaxRate
            // 
            lbTaxRate.BackColor = Color.FromArgb(224, 224, 224);
            lbTaxRate.BorderStyle = BorderStyle.Fixed3D;
            lbTaxRate.Font = new Font("源雲明體 SB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbTaxRate.ForeColor = Color.FromArgb(64, 64, 64);
            lbTaxRate.Location = new Point(141, 132);
            lbTaxRate.Name = "lbTaxRate";
            lbTaxRate.Size = new Size(220, 31);
            lbTaxRate.TabIndex = 4;
            lbTaxRate.Text = "(百分比)";
            lbTaxRate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTax
            // 
            lbTax.BackColor = Color.FromArgb(224, 224, 224);
            lbTax.BorderStyle = BorderStyle.Fixed3D;
            lbTax.Font = new Font("源雲明體 SB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lbTax.ForeColor = Color.FromArgb(64, 64, 64);
            lbTax.Location = new Point(141, 176);
            lbTax.Name = "lbTax";
            lbTax.Size = new Size(220, 31);
            lbTax.TabIndex = 5;
            lbTax.Text = "(元)";
            lbTax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 97);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 225);
            Controls.Add(label4);
            Controls.Add(lbTax);
            Controls.Add(lbTaxRate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txBoxIncome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TaxCalculator - With Ternary Operator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txBoxIncome;
        private Label label2;
        private Label label3;
        private Label lbTaxRate;
        private Label lbTax;
        private Label label4;
    }
}

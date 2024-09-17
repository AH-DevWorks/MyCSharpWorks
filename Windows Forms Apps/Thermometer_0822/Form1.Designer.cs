namespace Thermometer_0822
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
            btnFtoC = new Button();
            btnCtoF = new Button();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            lb1equal = new Label();
            lb2f = new Label();
            SuspendLayout();
            // 
            // btnFtoC
            // 
            btnFtoC.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnFtoC.Location = new Point(225, 108);
            btnFtoC.Name = "btnFtoC";
            btnFtoC.Size = new Size(85, 37);
            btnFtoC.TabIndex = 0;
            btnFtoC.Text = "F to C";
            btnFtoC.UseVisualStyleBackColor = true;
            btnFtoC.Click += btnFtoC_Click;
            // 
            // btnCtoF
            // 
            btnCtoF.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCtoF.Location = new Point(35, 108);
            btnCtoF.Name = "btnCtoF";
            btnCtoF.Size = new Size(85, 37);
            btnCtoF.TabIndex = 1;
            btnCtoF.Text = "C to F";
            btnCtoF.UseVisualStyleBackColor = true;
            btnCtoF.Click += btnCtoF_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCelsius.Location = new Point(21, 41);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(113, 25);
            txtCelsius.TabIndex = 2;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFahrenheit.Location = new Point(213, 41);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(113, 25);
            txtFahrenheit.TabIndex = 3;
            // 
            // lb1equal
            // 
            lb1equal.AutoSize = true;
            lb1equal.Font = new Font("Consolas", 12F);
            lb1equal.Location = new Point(144, 44);
            lb1equal.Name = "lb1equal";
            lb1equal.Size = new Size(63, 19);
            lb1equal.TabIndex = 4;
            lb1equal.Text = ".C  = ";
            // 
            // lb2f
            // 
            lb2f.AutoSize = true;
            lb2f.Font = new Font("Consolas", 12F);
            lb2f.Location = new Point(341, 44);
            lb2f.Name = "lb2f";
            lb2f.Size = new Size(27, 19);
            lb2f.TabIndex = 5;
            lb2f.Text = ".F";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 225);
            Controls.Add(lb2f);
            Controls.Add(lb1equal);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(btnCtoF);
            Controls.Add(btnFtoC);
            Name = "Form1";
            Text = "Degree Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFtoC;
        private Button btnCtoF;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private Label lb1equal;
        private Label lb2f;
    }
}

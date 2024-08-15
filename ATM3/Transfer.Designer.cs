namespace ATM3
{
    partial class Transfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.savBalanceText = new System.Windows.Forms.TextBox();
            this.billPaymentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButtonDeposit = new System.Windows.Forms.Button();
            this.goButtonDeposit = new System.Windows.Forms.Button();
            this.textWithdrawal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chqBalanceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Savings Balance";
            // 
            // savBalanceText
            // 
            this.savBalanceText.Location = new System.Drawing.Point(411, 249);
            this.savBalanceText.Name = "savBalanceText";
            this.savBalanceText.Size = new System.Drawing.Size(275, 20);
            this.savBalanceText.TabIndex = 24;
            // 
            // billPaymentLabel
            // 
            this.billPaymentLabel.AutoSize = true;
            this.billPaymentLabel.Location = new System.Drawing.Point(277, 182);
            this.billPaymentLabel.Name = "billPaymentLabel";
            this.billPaymentLabel.Size = new System.Drawing.Size(265, 13);
            this.billPaymentLabel.TabIndex = 23;
            this.billPaymentLabel.Text = "Enter amount to transfer from CHEQUING to SAVINGS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "TRANSFER  DETAILS";
            // 
            // exitButtonDeposit
            // 
            this.exitButtonDeposit.Location = new System.Drawing.Point(421, 286);
            this.exitButtonDeposit.Name = "exitButtonDeposit";
            this.exitButtonDeposit.Size = new System.Drawing.Size(124, 46);
            this.exitButtonDeposit.TabIndex = 21;
            this.exitButtonDeposit.Text = "EXIT";
            this.exitButtonDeposit.UseVisualStyleBackColor = true;
            this.exitButtonDeposit.Click += new System.EventHandler(this.exitButtonDeposit_Click);
            // 
            // goButtonDeposit
            // 
            this.goButtonDeposit.Location = new System.Drawing.Point(267, 286);
            this.goButtonDeposit.Name = "goButtonDeposit";
            this.goButtonDeposit.Size = new System.Drawing.Size(124, 46);
            this.goButtonDeposit.TabIndex = 20;
            this.goButtonDeposit.Text = "GO";
            this.goButtonDeposit.UseVisualStyleBackColor = true;
            this.goButtonDeposit.Click += new System.EventHandler(this.goButtonDeposit_Click);
            // 
            // textWithdrawal
            // 
            this.textWithdrawal.Location = new System.Drawing.Point(267, 198);
            this.textWithdrawal.Name = "textWithdrawal";
            this.textWithdrawal.Size = new System.Drawing.Size(278, 20);
            this.textWithdrawal.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Chequing Balance";
            // 
            // chqBalanceText
            // 
            this.chqBalanceText.Location = new System.Drawing.Point(130, 249);
            this.chqBalanceText.Name = "chqBalanceText";
            this.chqBalanceText.Size = new System.Drawing.Size(275, 20);
            this.chqBalanceText.TabIndex = 26;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chqBalanceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savBalanceText);
            this.Controls.Add(this.billPaymentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButtonDeposit);
            this.Controls.Add(this.goButtonDeposit);
            this.Controls.Add(this.textWithdrawal);
            this.Name = "Transfer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox savBalanceText;
        private System.Windows.Forms.Label billPaymentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButtonDeposit;
        private System.Windows.Forms.Button goButtonDeposit;
        private System.Windows.Forms.TextBox textWithdrawal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chqBalanceText;
    }
}
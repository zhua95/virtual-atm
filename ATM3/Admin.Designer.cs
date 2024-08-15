namespace ATM3
{
    partial class Admin
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
            this.outOfServiceButton = new System.Windows.Forms.Button();
            this.refillButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.payInterestButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.billPaymentLabel = new System.Windows.Forms.Label();
            this.textRefill = new System.Windows.Forms.TextBox();
            this.accountsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outOfServiceButton
            // 
            this.outOfServiceButton.Location = new System.Drawing.Point(565, 169);
            this.outOfServiceButton.Name = "outOfServiceButton";
            this.outOfServiceButton.Size = new System.Drawing.Size(171, 88);
            this.outOfServiceButton.TabIndex = 15;
            this.outOfServiceButton.Text = "OUT OF SERVICE";
            this.outOfServiceButton.UseVisualStyleBackColor = true;
            this.outOfServiceButton.Click += new System.EventHandler(this.outOfServiceButton_Click);
            // 
            // refillButton
            // 
            this.refillButton.Location = new System.Drawing.Point(388, 169);
            this.refillButton.Name = "refillButton";
            this.refillButton.Size = new System.Drawing.Size(171, 88);
            this.refillButton.TabIndex = 13;
            this.refillButton.Text = "REFILL ATM";
            this.refillButton.UseVisualStyleBackColor = true;
            this.refillButton.Click += new System.EventHandler(this.refillButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(476, 263);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(171, 88);
            this.transferButton.TabIndex = 12;
            this.transferButton.Text = "ACCOUNTS REPORT";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // payInterestButton
            // 
            this.payInterestButton.Location = new System.Drawing.Point(476, 75);
            this.payInterestButton.Name = "payInterestButton";
            this.payInterestButton.Size = new System.Drawing.Size(171, 88);
            this.payInterestButton.TabIndex = 10;
            this.payInterestButton.Text = "PAY INTEREST";
            this.payInterestButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Balance";
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(169, 132);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(275, 20);
            this.textBalance.TabIndex = 21;
            // 
            // billPaymentLabel
            // 
            this.billPaymentLabel.AutoSize = true;
            this.billPaymentLabel.Location = new System.Drawing.Point(182, 69);
            this.billPaymentLabel.Name = "billPaymentLabel";
            this.billPaymentLabel.Size = new System.Drawing.Size(262, 13);
            this.billPaymentLabel.TabIndex = 20;
            this.billPaymentLabel.Text = "Enter an amount to refill the ATM (Increments of 5000)";
            // 
            // textRefill
            // 
            this.textRefill.Location = new System.Drawing.Point(169, 85);
            this.textRefill.Name = "textRefill";
            this.textRefill.Size = new System.Drawing.Size(278, 20);
            this.textRefill.TabIndex = 19;
            // 
            // accountsBox
            // 
            this.accountsBox.Location = new System.Drawing.Point(56, 193);
            this.accountsBox.Name = "accountsBox";
            this.accountsBox.Size = new System.Drawing.Size(279, 20);
            this.accountsBox.TabIndex = 23;
            this.accountsBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.billPaymentLabel);
            this.Controls.Add(this.textRefill);
            this.Controls.Add(this.outOfServiceButton);
            this.Controls.Add(this.refillButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.payInterestButton);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button outOfServiceButton;
        private System.Windows.Forms.Button refillButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button payInterestButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label billPaymentLabel;
        private System.Windows.Forms.TextBox textRefill;
        private System.Windows.Forms.TextBox accountsBox;
    }
}
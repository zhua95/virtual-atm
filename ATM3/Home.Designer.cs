namespace ATM3
{
    partial class balanceButton
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
            this.withdrawButton = new System.Windows.Forms.Button();
            this.billPaymentButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.savButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(12, 100);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(171, 88);
            this.withdrawButton.TabIndex = 0;
            this.withdrawButton.Text = "WITHDRAW CHEQUINGS";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // billPaymentButton
            // 
            this.billPaymentButton.Location = new System.Drawing.Point(510, 54);
            this.billPaymentButton.Name = "billPaymentButton";
            this.billPaymentButton.Size = new System.Drawing.Size(171, 88);
            this.billPaymentButton.TabIndex = 1;
            this.billPaymentButton.Text = "BILL PAYMENT";
            this.billPaymentButton.UseVisualStyleBackColor = true;
            this.billPaymentButton.Click += new System.EventHandler(this.billPaymentButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(12, 194);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(171, 88);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "DEPOSIT CHEQUINGS";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(510, 242);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(171, 88);
            this.transferButton.TabIndex = 3;
            this.transferButton.Text = "TRANSFER (C TO S)";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(422, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 88);
            this.button5.TabIndex = 4;
            this.button5.Text = "BALANCE CHEQUING";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(308, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 88);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // savButton
            // 
            this.savButton.Location = new System.Drawing.Point(599, 148);
            this.savButton.Name = "savButton";
            this.savButton.Size = new System.Drawing.Size(171, 88);
            this.savButton.TabIndex = 6;
            this.savButton.Text = "BALANCE SAVINGS";
            this.savButton.UseVisualStyleBackColor = true;
            this.savButton.Click += new System.EventHandler(this.savButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 88);
            this.button1.TabIndex = 7;
            this.button1.Text = "DEPOSIT SAVINGS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 88);
            this.button2.TabIndex = 8;
            this.button2.Text = "WITHDRAW SAVINGS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // balanceButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.billPaymentButton);
            this.Controls.Add(this.withdrawButton);
            this.Name = "balanceButton";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button billPaymentButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button savButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
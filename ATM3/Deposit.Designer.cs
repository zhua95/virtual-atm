namespace ATM3
{
    partial class Deposit
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
            this.depositLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButtonDeposit = new System.Windows.Forms.Button();
            this.goButtonDeposit = new System.Windows.Forms.Button();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(297, 186);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(171, 13);
            this.depositLabel.TabIndex = 11;
            this.depositLabel.Text = "Enter deposit amount and press go";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "DEPOSIT  DETAILS";
            // 
            // exitButtonDeposit
            // 
            this.exitButtonDeposit.Location = new System.Drawing.Point(408, 290);
            this.exitButtonDeposit.Name = "exitButtonDeposit";
            this.exitButtonDeposit.Size = new System.Drawing.Size(124, 46);
            this.exitButtonDeposit.TabIndex = 9;
            this.exitButtonDeposit.Text = "EXIT";
            this.exitButtonDeposit.UseVisualStyleBackColor = true;
            this.exitButtonDeposit.Click += new System.EventHandler(this.exitButtonDeposit_Click);
            // 
            // goButtonDeposit
            // 
            this.goButtonDeposit.Location = new System.Drawing.Point(254, 290);
            this.goButtonDeposit.Name = "goButtonDeposit";
            this.goButtonDeposit.Size = new System.Drawing.Size(124, 46);
            this.goButtonDeposit.TabIndex = 8;
            this.goButtonDeposit.Text = "GO";
            this.goButtonDeposit.UseVisualStyleBackColor = true;
            this.goButtonDeposit.Click += new System.EventHandler(this.goButtonDeposit_Click);
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(254, 202);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(278, 20);
            this.textDeposit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance";
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(255, 250);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(275, 20);
            this.textBalance.TabIndex = 12;
            this.textBalance.TextChanged += new System.EventHandler(this.textBalance_TextChanged);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButtonDeposit);
            this.Controls.Add(this.goButtonDeposit);
            this.Controls.Add(this.textDeposit);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButtonDeposit;
        private System.Windows.Forms.Button goButtonDeposit;
        private System.Windows.Forms.TextBox textDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBalance;
    }
}
namespace ATM3
{
    partial class DepositSav
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
            this.textBalance = new System.Windows.Forms.TextBox();
            this.depositLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButtonDeposit = new System.Windows.Forms.Button();
            this.goButtonDeposit = new System.Windows.Forms.Button();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Balance";
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(262, 245);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(275, 20);
            this.textBalance.TabIndex = 19;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(304, 181);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(171, 13);
            this.depositLabel.TabIndex = 18;
            this.depositLabel.Text = "Enter deposit amount and press go";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "DEPOSIT  DETAILS";
            // 
            // exitButtonDeposit
            // 
            this.exitButtonDeposit.Location = new System.Drawing.Point(415, 285);
            this.exitButtonDeposit.Name = "exitButtonDeposit";
            this.exitButtonDeposit.Size = new System.Drawing.Size(124, 46);
            this.exitButtonDeposit.TabIndex = 16;
            this.exitButtonDeposit.Text = "EXIT";
            this.exitButtonDeposit.UseVisualStyleBackColor = true;
            this.exitButtonDeposit.Click += new System.EventHandler(this.exitButtonDeposit_Click);
            // 
            // goButtonDeposit
            // 
            this.goButtonDeposit.Location = new System.Drawing.Point(261, 285);
            this.goButtonDeposit.Name = "goButtonDeposit";
            this.goButtonDeposit.Size = new System.Drawing.Size(124, 46);
            this.goButtonDeposit.TabIndex = 15;
            this.goButtonDeposit.Text = "GO";
            this.goButtonDeposit.UseVisualStyleBackColor = true;
            this.goButtonDeposit.Click += new System.EventHandler(this.goButtonDeposit_Click);
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(261, 197);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(278, 20);
            this.textDeposit.TabIndex = 14;
            // 
            // DepositSav
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
            this.Name = "DepositSav";
            this.Text = "DepositSav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButtonDeposit;
        private System.Windows.Forms.Button goButtonDeposit;
        private System.Windows.Forms.TextBox textDeposit;
    }
}
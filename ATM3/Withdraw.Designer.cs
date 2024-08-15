namespace ATM3
{
    partial class Withdraw
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
            this.textWithdrawal = new System.Windows.Forms.TextBox();
            this.goButtonWithdrawal = new System.Windows.Forms.Button();
            this.exitButtonWithdrawal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textWithdrawal
            // 
            this.textWithdrawal.Location = new System.Drawing.Point(257, 153);
            this.textWithdrawal.Name = "textWithdrawal";
            this.textWithdrawal.Size = new System.Drawing.Size(278, 20);
            this.textWithdrawal.TabIndex = 0;
            this.textWithdrawal.TextChanged += new System.EventHandler(this.textWithdrawal_TextChanged);
            // 
            // goButtonWithdrawal
            // 
            this.goButtonWithdrawal.Location = new System.Drawing.Point(257, 241);
            this.goButtonWithdrawal.Name = "goButtonWithdrawal";
            this.goButtonWithdrawal.Size = new System.Drawing.Size(124, 46);
            this.goButtonWithdrawal.TabIndex = 1;
            this.goButtonWithdrawal.Text = "GO";
            this.goButtonWithdrawal.UseVisualStyleBackColor = true;
            this.goButtonWithdrawal.Click += new System.EventHandler(this.goButtonWithdrawal_Click);
            // 
            // exitButtonWithdrawal
            // 
            this.exitButtonWithdrawal.Location = new System.Drawing.Point(411, 241);
            this.exitButtonWithdrawal.Name = "exitButtonWithdrawal";
            this.exitButtonWithdrawal.Size = new System.Drawing.Size(124, 46);
            this.exitButtonWithdrawal.TabIndex = 2;
            this.exitButtonWithdrawal.Text = "EXIT";
            this.exitButtonWithdrawal.UseVisualStyleBackColor = true;
            this.exitButtonWithdrawal.Click += new System.EventHandler(this.exitButtonWithdrawal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "WITHDRAWAL DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter withdrawal amount and press go";
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(259, 199);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(275, 20);
            this.textBalance.TabIndex = 5;
            this.textBalance.TextChanged += new System.EventHandler(this.textBalance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Balance";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButtonWithdrawal);
            this.Controls.Add(this.goButtonWithdrawal);
            this.Controls.Add(this.textWithdrawal);
            this.Name = "Withdraw";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textWithdrawal;
        private System.Windows.Forms.Button goButtonWithdrawal;
        private System.Windows.Forms.Button exitButtonWithdrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Label label3;
    }
}
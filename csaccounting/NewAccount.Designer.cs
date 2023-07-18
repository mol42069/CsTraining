namespace csaccounting
{
    partial class NewAccount
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
            this.UsernameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordEntry = new System.Windows.Forms.TextBox();
            this.StartingBalanceText = new System.Windows.Forms.Label();
            this.StartingBalanceEntry = new System.Windows.Forms.TextBox();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.CreditAccountCheck = new System.Windows.Forms.CheckBox();
            this.DebitAccountCheck = new System.Windows.Forms.CheckBox();
            this.RePwTB = new System.Windows.Forms.TextBox();
            this.ReenterPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameEntry
            // 
            this.UsernameEntry.Location = new System.Drawing.Point(267, 81);
            this.UsernameEntry.Name = "UsernameEntry";
            this.UsernameEntry.Size = new System.Drawing.Size(276, 20);
            this.UsernameEntry.TabIndex = 0;
            this.UsernameEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.Location = new System.Drawing.Point(266, 131);
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.Size = new System.Drawing.Size(276, 20);
            this.PasswordEntry.TabIndex = 4;
            this.PasswordEntry.TextChanged += new System.EventHandler(this.PasswordEntry_TextChanged);
            // 
            // StartingBalanceText
            // 
            this.StartingBalanceText.AutoSize = true;
            this.StartingBalanceText.Location = new System.Drawing.Point(263, 211);
            this.StartingBalanceText.Name = "StartingBalanceText";
            this.StartingBalanceText.Size = new System.Drawing.Size(88, 13);
            this.StartingBalanceText.TabIndex = 5;
            this.StartingBalanceText.Text = "Starting Balance:";
            this.StartingBalanceText.Click += new System.EventHandler(this.StartingBalance_Click);
            // 
            // StartingBalanceEntry
            // 
            this.StartingBalanceEntry.Location = new System.Drawing.Point(266, 227);
            this.StartingBalanceEntry.Name = "StartingBalanceEntry";
            this.StartingBalanceEntry.Size = new System.Drawing.Size(276, 20);
            this.StartingBalanceEntry.TabIndex = 6;
            this.StartingBalanceEntry.TextChanged += new System.EventHandler(this.StartingBalanceEntry_TextChanged);
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.SystemColors.ControlText;
            this.CreateAccount.ForeColor = System.Drawing.Color.Cornsilk;
            this.CreateAccount.Location = new System.Drawing.Point(276, 297);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(235, 56);
            this.CreateAccount.TabIndex = 7;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = false;
            this.CreateAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreditAccountCheck
            // 
            this.CreditAccountCheck.AutoSize = true;
            this.CreditAccountCheck.Location = new System.Drawing.Point(267, 13);
            this.CreditAccountCheck.Name = "CreditAccountCheck";
            this.CreditAccountCheck.Size = new System.Drawing.Size(96, 17);
            this.CreditAccountCheck.TabIndex = 8;
            this.CreditAccountCheck.Text = "Credit-Account";
            this.CreditAccountCheck.UseVisualStyleBackColor = true;
            this.CreditAccountCheck.CheckedChanged += new System.EventHandler(this.CreditAccountCheck_CheckedChanged);
            // 
            // DebitAccountCheck
            // 
            this.DebitAccountCheck.AutoSize = true;
            this.DebitAccountCheck.Location = new System.Drawing.Point(266, 37);
            this.DebitAccountCheck.Name = "DebitAccountCheck";
            this.DebitAccountCheck.Size = new System.Drawing.Size(94, 17);
            this.DebitAccountCheck.TabIndex = 9;
            this.DebitAccountCheck.Text = "Debit-Account";
            this.DebitAccountCheck.UseVisualStyleBackColor = true;
            this.DebitAccountCheck.CheckedChanged += new System.EventHandler(this.DebitAccountCheck_CheckedChanged);
            // 
            // RePwTB
            // 
            this.RePwTB.Location = new System.Drawing.Point(266, 179);
            this.RePwTB.Name = "RePwTB";
            this.RePwTB.Size = new System.Drawing.Size(276, 20);
            this.RePwTB.TabIndex = 11;
            this.RePwTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ReenterPassword
            // 
            this.ReenterPassword.AutoSize = true;
            this.ReenterPassword.Location = new System.Drawing.Point(263, 163);
            this.ReenterPassword.Name = "ReenterPassword";
            this.ReenterPassword.Size = new System.Drawing.Size(101, 13);
            this.ReenterPassword.TabIndex = 10;
            this.ReenterPassword.Text = "Re-Enter Password:";
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RePwTB);
            this.Controls.Add(this.ReenterPassword);
            this.Controls.Add(this.DebitAccountCheck);
            this.Controls.Add(this.CreditAccountCheck);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.StartingBalanceEntry);
            this.Controls.Add(this.StartingBalanceText);
            this.Controls.Add(this.PasswordEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameEntry);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "NewAccount";
            this.Text = "Create new Account";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordEntry;
        private System.Windows.Forms.Label StartingBalanceText;
        private System.Windows.Forms.TextBox StartingBalanceEntry;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.CheckBox CreditAccountCheck;
        private System.Windows.Forms.CheckBox DebitAccountCheck;
        private System.Windows.Forms.Label ReenterPassword;
        private System.Windows.Forms.TextBox RePwTB;
    }
}
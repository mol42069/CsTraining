namespace csaccounting.DebitAccounts
{
    partial class DebitControll
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
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(28, 51);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(201, 69);
            this.WithdrawButton.TabIndex = 0;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(30, 135);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(198, 69);
            this.DepositButton.TabIndex = 1;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance:";
            // 
            // BalanceBox
            // 
            this.BalanceBox.Location = new System.Drawing.Point(555, 61);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.Size = new System.Drawing.Size(233, 24);
            this.BalanceBox.TabIndex = 3;
            this.BalanceBox.Text = "";
            this.BalanceBox.TextChanged += new System.EventHandler(this.BalanceBox_TextChanged);
            // 
            // DebitControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BalanceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawButton);
            this.Name = "DebitControll";
            this.Text = "DebitControll";
            this.Load += new System.EventHandler(this.DebitControll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox BalanceBox;
    }
}
namespace csaccounting.DebitAccounts
{
    partial class DebitDeposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.DepositingAmmount = new System.Windows.Forms.TextBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depositing:";
            // 
            // DepositingAmmount
            // 
            this.DepositingAmmount.Location = new System.Drawing.Point(84, 78);
            this.DepositingAmmount.Name = "DepositingAmmount";
            this.DepositingAmmount.Size = new System.Drawing.Size(211, 20);
            this.DepositingAmmount.TabIndex = 1;
            this.DepositingAmmount.TextChanged += new System.EventHandler(this.DepositingAmmount_TextChanged);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(84, 139);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(192, 58);
            this.DepositButton.TabIndex = 2;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // DebitDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.DepositingAmmount);
            this.Controls.Add(this.label1);
            this.Name = "DebitDeposit";
            this.Text = "DebitDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepositingAmmount;
        private System.Windows.Forms.Button DepositButton;
    }
}
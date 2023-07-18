namespace csaccounting.DebitAccounts
{
    partial class DebitWithdraw
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
            this.WithdrawTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WithdrawTextBox
            // 
            this.WithdrawTextBox.Location = new System.Drawing.Point(156, 134);
            this.WithdrawTextBox.Name = "WithdrawTextBox";
            this.WithdrawTextBox.Size = new System.Drawing.Size(293, 20);
            this.WithdrawTextBox.TabIndex = 0;
            this.WithdrawTextBox.TextChanged += new System.EventHandler(this.WithdrawTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Withdraw ammount:";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(156, 241);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(229, 54);
            this.WithdrawButton.TabIndex = 2;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // DebitWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WithdrawTextBox);
            this.Name = "DebitWithdraw";
            this.Text = "DebitWithdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WithdrawTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WithdrawButton;
    }
}
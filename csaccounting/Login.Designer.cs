namespace csaccounting
{
    partial class Login
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
            this.debit_button = new System.Windows.Forms.Button();
            this.CreditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debit_button
            // 
            this.debit_button.Location = new System.Drawing.Point(140, 133);
            this.debit_button.Name = "debit_button";
            this.debit_button.Size = new System.Drawing.Size(215, 86);
            this.debit_button.TabIndex = 0;
            this.debit_button.Text = "Debit";
            this.debit_button.UseVisualStyleBackColor = true;
            this.debit_button.Click += new System.EventHandler(this.debit_button_Click);
            // 
            // CreditButton
            // 
            this.CreditButton.Location = new System.Drawing.Point(426, 136);
            this.CreditButton.Name = "CreditButton";
            this.CreditButton.Size = new System.Drawing.Size(228, 80);
            this.CreditButton.TabIndex = 1;
            this.CreditButton.Text = "Credit";
            this.CreditButton.UseVisualStyleBackColor = true;
            this.CreditButton.Click += new System.EventHandler(this.CreditButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreditButton);
            this.Controls.Add(this.debit_button);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button debit_button;
        private System.Windows.Forms.Button CreditButton;
    }
}
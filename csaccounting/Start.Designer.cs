namespace csaccounting
{
    partial class Start
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
            this.CreateNewAccountButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewAccountButton
            // 
            this.CreateNewAccountButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.CreateNewAccountButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.CreateNewAccountButton.Location = new System.Drawing.Point(302, 93);
            this.CreateNewAccountButton.Name = "CreateNewAccountButton";
            this.CreateNewAccountButton.Size = new System.Drawing.Size(202, 74);
            this.CreateNewAccountButton.TabIndex = 0;
            this.CreateNewAccountButton.Text = "Create new Account";
            this.CreateNewAccountButton.UseVisualStyleBackColor = false;
            this.CreateNewAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(302, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateNewAccountButton);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewAccountButton;
        private System.Windows.Forms.Button button2;
    }
}


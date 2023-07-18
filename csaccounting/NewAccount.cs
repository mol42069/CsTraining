using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using accounting;

namespace csaccounting
{
    public partial class NewAccount : Form
    {
        private bool debit = false, credit = false;
        private int password, rPassword;
        private float startingBalance;
        private string Username;
        public SaveHandler sh;

        public NewAccount(SaveHandler sh)
        {
            this.sh = sh;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)                           // USERNAME
        {
            this.Username = UsernameEntry.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartingBalance_Click(object sender, EventArgs e)                          
        {

        }

        private void StartingBalanceEntry_TextChanged(object sender, EventArgs e)               // STARTING BALANCE
        {
            try
            {
                this.startingBalance = float.Parse(StartingBalanceEntry.Text);

            }
            catch {                                                     // we make sure that the user cant enter char here
                if (StartingBalanceEntry.Text.Length == 0 || StartingBalanceEntry.Text.Length == 1)
                {
                    StartingBalanceEntry.Text = "";

                }
                else
                {
                    StartingBalanceEntry.Text = this.startingBalance.ToString();

                }
            }
        }

        private void PasswordEntry_TextChanged(object sender, EventArgs e)                      // PASSWORD ENTRY
        {
            
            try
            {
                this.password = int.Parse(PasswordEntry.Text);
            }

            catch {                                                        // we make sure that the user cant enter char here

                if (PasswordEntry.Text.Length == 0 || PasswordEntry.Text.Length == 1)
                {
                    PasswordEntry.Text = "";
                
                }
                else {
                    PasswordEntry.Text = this.password.ToString();
                
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.password == this.rPassword)
            {
                if (debit) {
                    Debit account = new Debit(this.password, this.startingBalance, this.Username);
                    sh.NewDebit(account);
                    sh.SaveToFile();
                    this.Close();
                }
            }
            else {
                RePwTB.BackColor = Color.FromArgb(200, 0, 0);
            }

        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void DebitAccountCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.debit = !this.debit;
            if (credit && debit) {                                      // we uncheck the credit checkbox if debit is checked
                CreditAccountCheck.Checked = false;
                credit = false;
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)                             // reentered password "RePwTB"
        {
            try
            {
                this.rPassword = int.Parse(RePwTB.Text);

            }
            catch                                                       // we make sure that the user cant enter char here
            {
                if (RePwTB.Text.Length == 0 || RePwTB.Text.Length == 1)
                {
                    RePwTB.Text = "";

                }
                else
                {
                    RePwTB.Text = this.rPassword.ToString();

                }
            }
        }

        private void CreditAccountCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.credit = !this.credit;
            if (debit && credit){                                      // we uncheck the debit checkbox if credit is checked
                DebitAccountCheck.Checked = false;
                debit = false;
            }
        }
    }
}

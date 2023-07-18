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

namespace csaccounting.DebitAccounts
{
    public partial class DebitWithdraw : Form
    {
        private SaveHandler sh;
        private Debit account;
        private int a;
        public DebitWithdraw(SaveHandler sh, Debit account)
        {
            this.sh = sh;
            this.account = account;
            InitializeComponent();
        }

        private void WithdrawTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.a = int.Parse(WithdrawTextBox.Text);

            }
            catch
            {                                                     // we make sure that the user cant enter char here
                if (WithdrawTextBox.Text.Length == 0 || WithdrawTextBox.Text.Length == 1)
                {
                    WithdrawTextBox.Text = "";

                }
                else
                {
                    WithdrawTextBox.Text = this.a.ToString();

                }
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (this.account.Withdraw(int.Parse(WithdrawTextBox.Text)))
            {
                sh.SaveToFile();
                this.Close();
            }
            else {
                WithdrawTextBox.BackColor = Color.Red;
            }
        }
    }
}

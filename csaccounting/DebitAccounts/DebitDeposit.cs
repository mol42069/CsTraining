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
    public partial class DebitDeposit : Form
    {
        private Debit account;
        private SaveHandler sh;
        private int a;
        public DebitDeposit(SaveHandler sh, Debit account)
        {
            this.sh = sh;
            this.account = account;
            InitializeComponent();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            account.Deposit(int.Parse(DepositingAmmount.Text));
            sh.SaveToFile();
            this.Close();
        }

        private void DepositingAmmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    this.a = int.Parse(DepositingAmmount.Text);

            }
            catch
            {                                                     // we make sure that the user cant enter char here
                if (DepositingAmmount.Text.Length == 0 || DepositingAmmount.Text.Length == 1)
                {
                    DepositingAmmount.Text = "";

                }
                else
                {
                    DepositingAmmount.Text = this.a.ToString();

                }
            }
        }
    }
}

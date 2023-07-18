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
    public partial class DebitControll : Form
    {
        private Debit account;
        private SaveHandler sh;
        public DebitControll(SaveHandler sh, Debit account)
        {
            this.sh = sh;
            this.account = account;
            InitializeComponent();
            BalanceBox.Text = this.account.balance.ToString() + "€";
        }

        private void DebitControll_Load(object sender, EventArgs e)
        {
            BalanceBox.Text = this.account.balance.ToString() + "€";
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            DebitWithdraw debwd = new DebitWithdraw(this.sh, this.account);
            this.Hide();
            debwd.ShowDialog();
            this.Show();
            BalanceBox.Text = this.account.balance.ToString() + "€";
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            DebitDeposit debdp = new DebitDeposit(this.sh, this.account);
            this.Hide();
            debdp.ShowDialog();
            this.Show();
            BalanceBox.Text = this.account.balance.ToString() + "€";
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {

        }

        private void BalanceBox_TextChanged(object sender, EventArgs e)
        {
            BalanceBox.Text = this.account.balance.ToString() + "€";
        }
    }
}

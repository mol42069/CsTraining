using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csaccounting
{
    public partial class DebitLIPw : Form
    {
        private SaveHandler sh;
        private string username;
        public DebitLIPw(SaveHandler sh, string username)
        {
            this.username = username;
            this.sh = sh;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (sh.Login(this.username, int.Parse(PasswordEntry.Text))) {
                DebitAccounts.DebitControll debc = new DebitAccounts.DebitControll(this.sh, this.sh.GetDebAcc(this.username, int.Parse(PasswordEntry.Text)));
                this.Hide();
                debc.ShowDialog();
                this.Close();
            }

        }

        private void PasswordEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

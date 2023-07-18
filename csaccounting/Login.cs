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
    public partial class Login : Form
    {
        private SaveHandler sh;
        public Login(SaveHandler sh)
        {
            this.sh = sh;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void debit_button_Click(object sender, EventArgs e)
        {
            DebitLogIn debli = new DebitLogIn(sh);
            this.Hide();
            debli.ShowDialog();
            this.Close();

        }

        private void CreditButton_Click(object sender, EventArgs e)
        {

        }
    }
}

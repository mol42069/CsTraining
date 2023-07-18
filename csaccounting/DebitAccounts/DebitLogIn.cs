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
    public partial class DebitLogIn : Form
    {
        private SaveHandler sh;
        private string username;
        public DebitLogIn(SaveHandler sh)
        {
            this.sh = sh;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(UsernameTb.Text);
            if (sh.DebitAccountXsts(UsernameTb.Text))
            {
                DebitLIPw deblp = new DebitLIPw(this.sh, UsernameTb.Text);
                this.Hide();
                deblp.ShowDialog();
                this.Close();
            }
            else { 
                UsernameTb.BackColor = Color.Red;
            }


        }
    }
}

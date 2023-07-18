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
    public partial class Start : Form
    {
        private SaveHandler sh;
        public Start()
        {
            this.sh = new SaveHandler();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAccount f2 = new NewAccount(sh);
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login li = new Login(sh);
            this.Hide();
            li.ShowDialog();
            this.Show();
        }
    }
}

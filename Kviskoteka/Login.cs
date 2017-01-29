using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Unesi korisničko ime i lozinku");
                return;
            }

            if (username.Text == "admin" && pass.Text == "admin")
            {
                Napredne ni = new Napredne();
                ni.ShowDialog();
                this.Close();

            }
        }
    }
}

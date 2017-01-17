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
    public partial class Postavke : Form
    {
        public Postavke()
        {
            InitializeComponent();
        }
        

        private void napredne_Click(object sender, EventArgs e)
        {
            Login ni = new Login();
            ni.ShowDialog();

        }

        private void spremi_Click(object sender, EventArgs e)
        {

        }
        
    }
}

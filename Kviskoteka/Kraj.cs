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
    public partial class Kraj : Form
    {
        public Kraj(int bodovi, int bodovi1, int bodovi2)
        {
            InitializeComponent();

            label1.Text = "Vaši bodovi: " + bodovi.ToString();
            label2.Text = "Igrač1: " + bodovi1.ToString();
            label3.Text = "Igrač2: " + bodovi2.ToString();

            if (bodovi >= bodovi1 && bodovi >= bodovi2)
            {
                pobjednik.Text = "Čestitamo! Pobjedili ste!";
            }
            else if (bodovi1 >= bodovi2)
            {
                pobjednik.Text = "Pobjedio je igrač1!";
            }
            else
            {
                pobjednik.Text = "Pobjedio je igrač2!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Napredne : Form
    {
        public Napredne()
        {
            InitializeComponent();
        }

        private void ABC_Click(object sender, EventArgs e)
        {
            ABCPitanje ni = new ABCPitanje();
            this.Hide();
            ni.ShowDialog();
            this.Close();
        }

        private void Asocijacije_Click(object sender, EventArgs e)
        {
            AsocijacijePitanje ni = new AsocijacijePitanje();
            this.Hide();
            ni.ShowDialog();
            this.Close();
        }

        private void Završna_Click(object sender, EventArgs e)
        {
            ZavršnaPitanje ni = new ZavršnaPitanje();
            this.Hide();
            ni.ShowDialog();
            this.Close();

        }
    }
}

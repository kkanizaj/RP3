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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovaIgra_Click(object sender, EventArgs e)
        {
            NovaIgra ni = new NovaIgra();
            this.Hide();
            ni.ShowDialog();
            this.Close();
        }

        private void Postavke_Click(object sender, EventArgs e)
        {
            Postavke p = new Postavke();
            p.ShowDialog();
        }
    }
}

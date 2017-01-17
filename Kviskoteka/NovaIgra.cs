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
    public partial class NovaIgra : Form
    {

        public NovaIgra()
        {
            InitializeComponent();
        }

        private void startABC_Click(object sender, EventArgs e)
        {
            ABCPitalicaForm ni = new ABCPitalicaForm();
            this.Hide();
            ni.ShowDialog();
            this.Close();

        }
    }
}

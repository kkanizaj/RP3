using Kviskoteka.Objects;
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
    public partial class ABCPitanje : Form
    {
        public ABCPitanje()
        {
            InitializeComponent();
        }

        private void spremi_Click(object sender, EventArgs e)
        {
            if (pitanje.Text.Length > 0 && tocan.Text.Length > 0 && drugi.Text.Length > 0 && treci.Text.Length > 0)
            {
                ABCPitalica nova = new ABCPitalica(pitanje.Text, tocan.Text, drugi.Text, treci.Text);
                //spremiti u bazu
                pitanje.Text = "";
                tocan.Text = "";
                drugi.Text = "";
                treci.Text = "";
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }

        private void natrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

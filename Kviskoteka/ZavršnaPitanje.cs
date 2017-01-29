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
    public partial class ZavršnaPitanje : Form
    {
        public ZavršnaPitanje()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Pitanje.Text.Length > 0  && Odgovor.Text.Length > 0)
            {
                ZavrsnaIgra nova = new ZavrsnaIgra(Pitanje.Text, Odgovor.Text);
                //spremiti u bazu
                Pitanje.Text = "";
                Odgovor.Text = "";
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }

        }

        private void Natrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

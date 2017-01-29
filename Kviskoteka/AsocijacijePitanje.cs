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
    public partial class AsocijacijePitanje : Form
    {
        public AsocijacijePitanje()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool flag = false; 

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Text == String.Empty)
                    {
                        flag = true;
                    }      
                }
            }

            if (!flag) 
            {
                Asocijacije nova = new Asocijacije(t11.Text, t12.Text, t13.Text, t14.Text, t1o.Text, t21.Text, t22.Text, t23.Text, t24.Text, t2o.Text, t31.Text, t32.Text, t33.Text, t34.Text, t3o.Text, t41.Text, t42.Text, t43.Text, t44.Text, t4o.Text, rjesenje.Text);
                //spremiti u bazu
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        x.Text = String.Empty;    
                    }
                }
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

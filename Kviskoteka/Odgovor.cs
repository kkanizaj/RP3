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
    public partial class Odgovor : Form
    {
        public string result;
        public Odgovor()
        {
            InitializeComponent();
        }

        public string GetMyResult {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = textBox1.Text;
            this.Close();
        }
    
    }
}

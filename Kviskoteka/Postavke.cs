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

        static public int[] postavke = new int[] { 2, 2, 2, 2, 2, 2 };

        public Postavke()
        {
            InitializeComponent();
            if (postavke[0] == 1)
            {
                ABC1s.Checked = true;
            }
            else if (postavke[0] == 2)
            {
                ABC1d.Checked = true;
            }
            else if (postavke[0] == 3)
            {
                ABC1p.Checked = true;
            }

            if (postavke[1] == 1)
            {
                ASOC1s.Checked = true;
            }
            else if (postavke[1] == 2)
            {
                ASOC1d.Checked = true;
            }
            else if (postavke[1] == 3)
            {
                ASOC1p.Checked = true;
            }

            if (postavke[2] == 1)
            {
                ZAV1s.Checked = true;
            }
            else if (postavke[2] == 2)
            {
                ZAV1d.Checked = true;
            }
            else if (postavke[2] == 3)
            {
                ZAV1p.Checked = true;
            }

            if (postavke[3] == 1)
            {
                ABC2s.Checked = true;
            }
            else if (postavke[3] == 2)
            {
                ABC2d.Checked = true;
            }
            else if (postavke[3] == 3)
            {
                ABC2p.Checked = true;
            }

            if (postavke[4] == 1)
            {
                ASOC2s.Checked = true;
            }
            else if (postavke[4] == 2)
            {
                ASOC2d.Checked = true;
            }
            else if (postavke[4] == 3)
            {
                ASOC2p.Checked = true;
            }

            if (postavke[5] == 1)
            {
                ZAV2s.Checked = true;
            }
            else if (postavke[5] == 2)
            {
                ZAV2d.Checked = true;
            }
            else if (postavke[5] == 3)
            {
                ZAV2p.Checked = true;
            }
        }
        

        private void napredne_Click(object sender, EventArgs e)
        {
            Login ni = new Login();
            ni.ShowDialog();

        }

        private void spremi_Click(object sender, EventArgs e)
        {

            if (ABC1s.Checked == true)
            {
                postavke[0] = 1;
            }
            else if (ABC1d.Checked == true)
            {
                postavke[0] = 2;
            }
            else if (ABC1p.Checked == true)
            {
                postavke[0] = 3;
            }

            if (ASOC1s.Checked == true)
            {
                postavke[1] = 1;
            }
            else if (ASOC1d.Checked == true)
            {
                postavke[1] = 2;
            }
            else if (ASOC1p.Checked == true)
            {
                postavke[1] = 3;
            }

            if (ZAV1s.Checked == true)
            {
                postavke[2] = 1;
            }
            else if (ZAV1d.Checked == true)
            {
                postavke[2] = 2;
            }
            else if (ZAV1p.Checked == true)
            {
                postavke[2] = 3;
            }

            if (ABC2s.Checked == true)
            {
                postavke[3] = 1;
            }
            else if (ABC2d.Checked == true)
            {
                postavke[3] = 2;
            }
            else if (ABC2p.Checked == true)
            {
                postavke[3] = 3;
            }

            if (ASOC2s.Checked == true)
            {
                postavke[4] = 1;
            }
            else if (ASOC2d.Checked == true)
            {
                postavke[4] = 2;
            }
            else if (ASOC2p.Checked == true)
            {
                postavke[4] = 3;
            }

            if (ZAV2s.Checked == true)
            {
                postavke[5] = 1;
            }
            else if (ZAV2d.Checked == true)
            {
                postavke[5] = 2;
            }
            else if (ZAV2p.Checked == true)
            {
                postavke[5] = 3;
            }

            this.Close();
        }
        
    }
}

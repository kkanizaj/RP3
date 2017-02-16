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
    public partial class KviskoForm : Form
    {
        int kviskoBodovi;
        int kviskoBodovi1;
        int kviskoBodovi2;
        int player;
        int player1;
        int player2;
        int ulozio=0;
        int ulozio1=0;
        int ulozio2=0;

        public KviskoForm(int skviskoBodovi, int skviskoBodovi1, int skviskoBodovi2, int player, int player1, int player2)
        {
            InitializeComponent();
            this.kviskoBodovi = skviskoBodovi;
            this.kviskoBodovi1 = skviskoBodovi1;
            this.kviskoBodovi2 = skviskoBodovi2;
            this.player = player;
            this.player1 = player1;
            this.player2 = player2;

            if(kviskoBodovi1 > 0)
            {
                if(Postavke.postavke[1] >= Postavke.postavke[2])
                {
                    Random rnd = new Random();
                    if(rnd.NextDouble() < 0.8)
                    {
                        kviskoBodovi1 -= 1;
                        ulozio1 = 1;
                        label1.Text = "Igrač1 je uložio kvisko!";
                    }
                }
                else
                {
                    Random rnd = new Random();
                    if (rnd.NextDouble() < 0.2)
                    {
                        kviskoBodovi1 -= 1;
                        ulozio1 = 1;
                        label1.Text = "Igrač1 je uložio kvisko!";
                    }

                }
            }

            if (kviskoBodovi2 > 0)
            {
                if (Postavke.postavke[4] >= Postavke.postavke[5])
                {
                    Random rnd = new Random();
                    if (rnd.NextDouble() < 0.8)
                    {
                        kviskoBodovi2 -= 1;
                        ulozio2 = 1;
                        label2.Text = "Igrač2 je uložio kvisko!";
                    }
                }
                else
                {
                    Random rnd = new Random();
                    if (rnd.NextDouble() < 0.2)
                    {
                        kviskoBodovi2 -= 1;
                        ulozio2 = 1;
                        label2.Text = "Igrač2 je uložio kvisko!";
                    }

                }
            }
        }

        private void kvisko_Click(object sender, EventArgs e)
        {
            if(kviskoBodovi == 0)
            {
                MessageBox.Show("Nemate kvisko bodova!");
                return;
            }
            else
            {
                kviskoBodovi -= 1;
                ulozio = 1;
                MessageBox.Show("Uložili ste kvisko!");
                return;
            }
        }

        private void startAsocijacije_Click(object sender, EventArgs e)
        {
            AsocijacijeForm ni = new AsocijacijeForm(kviskoBodovi, kviskoBodovi1, kviskoBodovi2, player, player1, player2, ulozio, ulozio1, ulozio2);
            this.Hide();
            ni.ShowDialog();
            this.Close();

        }
    }
}

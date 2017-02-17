using Kviskoteka.Model.Extras;
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
    public partial class ZavršnaIgraForm : Form
    {
        List<ZavrsnaIgra> svaPitanja = new List<ZavrsnaIgra>();

        int player = 0;
        int player1 = 0;
        int player2 = 0;
        double player1Tezina = Postavke.postavke[2] * 0.3;
        double player2Tezina = Postavke.postavke[5] * 0.3;
        int brojPitanja = 0;
        int kviskoBodovi;
        int kviskoBodovi1;
        int kviskoBodovi2;
        int ulozio;
        int ulozio1;
        int ulozio2;
        DateTime start;
        DateTime naseVrijeme;

        public ZavršnaIgraForm(int kviskoBodovi, int kviskoBodovi1, int kviskoBodovi2, int player, int player1, int player2, int ulozio, int ulozio1, int ulozio2)
        {
            InitializeComponent();

            this.kviskoBodovi = kviskoBodovi;
            this.kviskoBodovi1 = kviskoBodovi1;
            this.kviskoBodovi2 = kviskoBodovi2;
            this.player = player;
            this.player1 = player1;
            this.player2 = player2;
            this.ulozio = ulozio;
            this.ulozio1 = ulozio1;
            this.ulozio2 = ulozio2;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            pictureBox2.Region = rg;

            if (ulozio == 1)
            {
                label1.Text = "Uložen kvisko!";
            }
            if (ulozio1 == 1)
            {
                kvisko1.Text = "Uložen kvisko!";
            }
            if (ulozio2 == 1)
            {
                kvisko2.Text = "Uložen kvisko!";
            }
            label2.Text = "Bodovi: " + player.ToString();
            bodovi1.Text = "Bodovi: " + player1.ToString();
            bodovi2.Text = "Bodovi: " + player2.ToString();

            svaPitanja = ZavrsnaIgraAccess.getAll();

            postaviPitanje();

        }

        async public void postaviPitanje()
        {
            if (brojPitanja < 5)
            {

                prijava.Image = Kviskoteka.Properties.Resources.gumb;
                Random rand = new Random();
                ZavrsnaIgra prva = svaPitanja[rand.Next(0, svaPitanja.Count)];
                svaPitanja.Remove(prva);

                timer.Text = "";
                await Task.Delay(1000);
                pictureBox1.BackColor = Color.Transparent;
                pictureBox2.BackColor = Color.Transparent;

                pitanje.Text = prva.Pitanje;
                List<KeyValuePair<int, double>> vrijemeNaTasteru = new List<KeyValuePair<int, double>>();
                prijava.Enabled = true;

                start = DateTime.Now;
                naseVrijeme = DateTime.Now.AddSeconds(3);

                Random rnd = new Random();
                double vrijemeIgraca1 = rnd.NextDouble() * 3;

                double vrijemeIgraca2 = rnd.NextDouble() * 3;

                double trazenoVrijeme = rnd.NextDouble() * 3;
                for (int i = 3; i >= 1; i--)
                {
                    timer.Text = i.ToString();
                    await Task.Delay(1000);
                }
                timer.Text = "0";
                await Task.Delay(3000); // u ovom vremenu se ocekuje nas eventualni klik na taster
                timer.Text = "";
                prijava.Enabled = false;
                double vrijemeIgraca = naseVrijeme.Second + (double)naseVrijeme.Millisecond / 1000 - start.Second - (double)start.Millisecond / 1000;
                
                vrijemeNaTasteru.Add(new KeyValuePair<int, double>(1, Math.Abs(vrijemeIgraca1 - trazenoVrijeme)));
                vrijemeNaTasteru.Add(new KeyValuePair<int, double>(2, Math.Abs(vrijemeIgraca2 - trazenoVrijeme)));
                vrijemeNaTasteru.Add(new KeyValuePair<int, double>(0, Math.Abs(vrijemeIgraca - trazenoVrijeme)));

                vrijemeNaTasteru.Sort(
                    delegate (KeyValuePair<int, double> pair1,
                     KeyValuePair<int, double> pair2)
                    {
                        return pair1.Value.CompareTo(pair2.Value);
                       }
                   );

                while (true)
                {
                    if (vrijemeNaTasteru.Count == 0)
                    {
                        ++brojPitanja;
                        postaviPitanje();
                        break;
                    }
                    else if(vrijemeNaTasteru.First().Key == 0)
                    {
                        vrijemeNaTasteru.Remove(vrijemeNaTasteru.First());

                        DateTime sad = DateTime.Now;
                        string odgovor;
                        using (Odgovor formOptions = new Odgovor())
                        {
                            formOptions.ShowDialog();
                            odgovor = formOptions.GetMyResult;
                        }
                        if (odgovor!=null && odgovor.ToLower() == prva.Odgovor.ToLower())
                        {
                            player += 2 * (ulozio + 1);
                            label2.Text = "Bodovi: " + player.ToString();
                            ++brojPitanja;
                            postaviPitanje();
                            break;
                        }
                    }
                    else if(vrijemeNaTasteru.First().Key == 1)
                    {
                        vrijemeNaTasteru.Remove(vrijemeNaTasteru.First());
                        pictureBox1.BackColor = Color.SteelBlue;
                        await Task.Delay(1000);
                        Random random = new Random();
                        if (random.NextDouble() < player1Tezina)
                        {
                            player1 += 2*(ulozio1+1);
                            bodovi1.Text = "Bodovi: " + player1.ToString();
                            pictureBox1.BackColor = Color.SeaGreen;
                            label3.Text = prva.Odgovor;
                            await Task.Delay(1000);
                            label3.Text = "";
                            ++brojPitanja; postaviPitanje(); break;
                        }
                        else
                        {
                            pictureBox1.BackColor = Color.Maroon;
                            await Task.Delay(500);
                        }
                    }
                    else if(vrijemeNaTasteru.First().Key == 2)
                    {
                        vrijemeNaTasteru.Remove(vrijemeNaTasteru.First());
                        pictureBox2.BackColor = Color.SteelBlue;
                        await Task.Delay(1000);
                        Random random = new Random();
                        if (random.NextDouble() < player1Tezina)
                        {
                            player2 += 2 * (ulozio1 + 1);
                            bodovi2.Text = "Bodovi: " + player2.ToString();
                            pictureBox2.BackColor = Color.SeaGreen;
                            label4.Text = prva.Odgovor;
                            await Task.Delay(1000);
                            label4.Text = "";
                            ++brojPitanja; postaviPitanje(); break;
                        }
                        else
                        {
                            pictureBox2.BackColor = Color.Maroon;
                            await Task.Delay(500);
                        }
                    }
                }
            }
            else
            {
                await Task.Delay(700);
                Kraj ni = new Kraj(player, player1, player2);
                this.Hide();
                ni.ShowDialog();
                this.Close();
            }

        }
        

        private void ZavršnaIgraForm_Load(object sender, EventArgs e)
        {

        }

        private void prijava_Click_1(object sender, EventArgs e)
        {
            naseVrijeme = DateTime.Now;
            prijava.Image = Kviskoteka.Properties.Resources.gumb2;
            prijava.Enabled = false;

        }
    }
}

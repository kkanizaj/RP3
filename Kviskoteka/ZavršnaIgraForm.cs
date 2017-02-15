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

//TODO: location prozora, textBox-> label, baza, font, size, usporiti igre, dodati brojPitanja = 5;
namespace Kviskoteka
{
    public partial class ZavršnaIgraForm : Form
    {
        IEnumerable<int> iskoristenaPitanja = new SortedSet<int>();

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
        bool kliknut = false;

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

            postaviPitanje();

        }

        async public void postaviPitanje()
        {
            if (brojPitanja < 5)
            {
                ZavrsnaIgra prva = new ZavrsnaIgra("pitanje", "odgovor");
                pitanje.Text = "";
                await Task.Delay(1000);
                pictureBox1.BackColor = Color.White;
                pictureBox2.BackColor = Color.White;

                pitanje.Text = prva.Pitanje;
                Dictionary<int, double> vrijemeNaTasteru = new Dictionary<int, double>();
                prijava.Enabled = true;

                start = DateTime.Now;
                naseVrijeme = DateTime.Now.AddSeconds(3);

                Random rnd = new Random();
                double vrijemeIgraca1 = rnd.NextDouble() * 3;

                double vrijemeIgraca2 = rnd.NextDouble() * 3;

                double trazenoVrijeme = rnd.NextDouble() * 3;
                //TODO
                //for (int i = 0; i <= 15 ; i++)
                //{
                //    await Task.Delay(200);
                //    progressBar1.Increment(2);
                //}
                await Task.Delay(3000); // u ovom vremenu se ocekuje nas eventualni klik na taster
                prijava.Enabled = false;
                double vrijemeIgraca = naseVrijeme.Second + (double)naseVrijeme.Millisecond / 1000 - start.Second - (double)start.Millisecond / 1000;

                //TODO: provjeriti zasto ne dolazimo na red
                vrijemeNaTasteru.Add(1, Math.Abs(vrijemeIgraca1 - trazenoVrijeme));
                vrijemeNaTasteru.Add(2, Math.Abs(vrijemeIgraca2 - trazenoVrijeme));
                vrijemeNaTasteru.Add(0, Math.Abs(vrijemeIgraca - trazenoVrijeme));
                vrijemeNaTasteru.OrderBy(pair => pair.Value);

                while (true)
                {
                    button1.Enabled = false;
                    label4.Visible = false;
                    button1.Visible = false;
                    odgovor.Visible = false;

                    if (vrijemeNaTasteru.Count == 0)
                    {
                        ++brojPitanja;
                        postaviPitanje();
                        break;
                    }
                    else if(vrijemeNaTasteru.First().Key == 0)
                    {
                        vrijemeNaTasteru.Remove(vrijemeNaTasteru.First().Key);
                        label4.Visible = true;
                        button1.Visible = true;
                        button1.Enabled = true;
                        odgovor.Visible = true;
                        odgovor.Enabled = true;

                        DateTime sad = DateTime.Now;
                        while (!kliknut && (DateTime.Now.Second-sad.Second)<10 )
                        {
                        }
                        if(odgovor.Text == prva.Odgovor)
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
                        vrijemeNaTasteru.Remove(vrijemeNaTasteru.First().Key);
                        pictureBox1.BackColor = Color.Blue;
                        await Task.Delay(1000);
                        Random random = new Random();
                        if (random.NextDouble() < player1Tezina)
                        {
                            player1 += 2*(ulozio1+1);
                            bodovi1.Text = "Bodovi: " + player1.ToString();
                            pictureBox1.BackColor = Color.Green;
                            ++brojPitanja; postaviPitanje(); break;
                        }
                        else
                        {
                            pictureBox1.BackColor = Color.Red;
                            await Task.Delay(500);
                        }
                    }
                    else if(vrijemeNaTasteru.First().Key == 2)
                    {
                        vrijemeNaTasteru.Remove(vrijemeNaTasteru.First().Key);
                        pictureBox2.BackColor = Color.Blue;
                        await Task.Delay(1000);
                        Random random = new Random();
                        if (random.NextDouble() < player1Tezina)
                        {
                            player2 += 2 * (ulozio1 + 1);
                            bodovi2.Text = "Bodovi: " + player2.ToString();
                            pictureBox2.BackColor = Color.Green;
                            ++brojPitanja; postaviPitanje(); break;
                        }
                        else
                        {
                            pictureBox2.BackColor = Color.Red;
                            await Task.Delay(500);
                        }
                    }
                }
            }
            else
            {
                Kraj ni = new Kraj(player, player1, player2);
                this.Hide();
                ni.ShowDialog();
                this.Close();
            }

        }

        private void prijava_Click(object sender, EventArgs e)
        {
            naseVrijeme = DateTime.Now;
            prijava.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kliknut = true;
        }
    }
}

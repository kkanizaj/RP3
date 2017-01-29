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
    public partial class AsocijacijeForm : Form
    {

        int player;
        int player1;
        int player2;
        int kviskoBodovi;
        int kviskoBodovi1;
        int kviskoBodovi2;
        double player1Tezina = Postavke.postavke[1];
        double player2Tezina = Postavke.postavke[4];
        int brojPitanja = 0;
        int ulozio;
        int ulozio1;
        int ulozio2;
        int pog1 = 0;
        int pog2 = 0;
        int pog3 = 0;
        int pog4 = 0;

        string[] rjesenja = new string[5];



        public AsocijacijeForm(int kviskoBodovi, int kviskoBodovi1, int kviskoBodovi2, int player, int player1, int player2, int ulozio, int ulozio1, int ulozio2)
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
            label3.Text = "Kvisko: " + kviskoBodovi.ToString();

            pokreniIgru();
        }

        public void pokreniIgru()
        {

            Asocijacije prva = new Asocijacije("kuhinja", "slano", "natrij", "klor", "sol", "žeđ", "čaša", "led", "para", "voda", "udovica", "humor", "zlato", "boja", "crno", "odbojka", "obala", "suncobran", "pijesak", "plaža", "more");

            button1.Tag = prva.P11.ToString();
            button2.Tag = prva.P12.ToString();
            button3.Tag = prva.P13.ToString();
            button4.Tag = prva.P14.ToString();

            button5.Tag = prva.P21.ToString();
            button6.Tag = prva.P22.ToString();
            button7.Tag = prva.P23.ToString();
            button8.Tag = prva.P24.ToString();

            button9.Tag = prva.P31.ToString();
            button10.Tag = prva.P32.ToString();
            button11.Tag = prva.P33.ToString();
            button12.Tag = prva.P34.ToString();

            button13.Tag = prva.P41.ToString();
            button14.Tag = prva.P42.ToString();
            button15.Tag = prva.P43.ToString();
            button16.Tag = prva.P44.ToString();

            rjesenja[0] = prva.P1o.ToString();
            rjesenja[1] = prva.P2o.ToString();
            rjesenja[2] = prva.P3o.ToString();
            rjesenja[3] = prva.P4o.ToString();
            rjesenja[4] = prva.Rjesenje.ToString();
        }
        
        public async void drugiIgrac()
        {   
            pictureBox1.BackColor = Color.Blue;
            while (true)
            {
                await Task.Delay(200);
                List<Button> buttoni = new List<Button>();

                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text != "")
                    {
                        buttoni.Add((Button)x);
                    }
                }

                Random rnd = new Random();
                Button btn = buttoni[rnd.Next(1, buttoni.Count)];
                btn.Text = btn.Tag.ToString();
                btn.Enabled = false;

                await Task.Delay(500);
                Dictionary<TextBox, int> l = new Dictionary<TextBox, int> { { textBox1, pog1 }, { textBox2, pog2 }, { textBox3, pog3 }, { textBox4, pog4 } };
                l.OrderByDescending(pair => pair.Value);
                while (true)
                {
                    //if prazna
                    if (l.First().Key.Text != "")
                    {
                        l.Remove(l.First().Key);
                    }
                    else
                    {
                        break;
                    }

                }

                double postotak;

                if (player1Tezina == 1)
                {
                    postotak = -5;
                }
                else if (player1Tezina == 2)
                {
                    postotak = 15;
                }
                else
                {
                    postotak = 35;
                }
                postotak += 20 * l.First().Value;
                if (postotak < 0)
                {
                    postotak = 0;
                }
                int temp = Int32.Parse(l.First().Key.Name.Substring(3, l.First().Key.Name.Length));
                if (rnd.NextDouble() < postotak / 100)
                {
                    l.First().Key.Text = rjesenja[temp];

                }
                else break;
            }
            
            pictureBox1.BackColor = Color.White;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = btn.Tag.ToString();

            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Text!="?")
                {
                    x.Enabled = false;
                }
            }
            int temp = Int32.Parse(btn.Name.Substring(6, btn.Name.Length));
            if (temp < 5) pog1++;
            else if (temp < 9) pog2++;
            else if (temp < 13) pog3++;
            else pog3++;
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == rjesenja[0])
            {
                textBox1.Enabled = false;

                button17.BackColor = Color.Green;
                await Task.Delay(500);
                button17.BackColor = Color.White;

                button1.Text = button1.Tag.ToString();
                button2.Text = button2.Tag.ToString();
                button3.Text = button3.Tag.ToString();
                button4.Text = button4.Tag.ToString();

                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text != "?" && x.Text == "")
                    {
                        x.Enabled = true;
                    }
                }

                player++;
                label2.Text = "Bodovi: " + player.ToString();
                button17.Enabled = false;
            }

            else
            {
                MessageBox.Show("Pogrešan odgovor, drugi igrač je na redu");
                drugiIgrac();
            }
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToLower() == rjesenja[1])
            {
                textBox2.Enabled = false;

                button18.BackColor = Color.Green;
                await Task.Delay(500);
                button18.BackColor = Color.White;

                button5.Text = button5.Tag.ToString();
                button6.Text = button6.Tag.ToString();
                button7.Text = button7.Tag.ToString();
                button8.Text = button8.Tag.ToString();

                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text != "?" && x.Text == "")
                    {
                        x.Enabled = true;
                    }
                }

                player++;
                label2.Text = "Bodovi: " + player.ToString();
                button18.Enabled = false;

            }

            else
            {
                MessageBox.Show("Pogrešan odgovor, drugi igrač je na redu");
                drugiIgrac();
            }

        }

        private async void button19_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.ToLower() == rjesenja[2])
            {
                textBox3.Enabled = false;

                button19.BackColor = Color.Green;
                await Task.Delay(500);
                button19.BackColor = Color.White;

                button9.Text = button9.Tag.ToString();
                button10.Text = button10.Tag.ToString();
                button11.Text = button11.Tag.ToString();
                button12.Text = button12.Tag.ToString();

                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text != "?" && x.Text == "")
                    {
                        x.Enabled = true;
                    }
                }

                player++;
                label2.Text = "Bodovi: " + player.ToString();
                button19.Enabled = false;

            }

            else
            {
                MessageBox.Show("Pogrešan odgovor, drugi igrač je na redu");
                drugiIgrac();
            }
        }

        private async void button20_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.ToLower() == rjesenja[3])
            {
                textBox4.Enabled = false;

                button20.BackColor = Color.Green;
                await Task.Delay(500);
                button20.BackColor = Color.White;

                button13.Text = button13.Tag.ToString();
                button14.Text = button14.Tag.ToString();
                button15.Text = button15.Tag.ToString();
                button16.Text = button16.Tag.ToString();

                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text != "?" && x.Text == "")
                    {
                        x.Enabled = true;
                    }
                }

                player++;
                label2.Text = "Bodovi: " + player.ToString();
                button20.Enabled = false;

            }

            else
            {
                MessageBox.Show("Pogrešan odgovor, drugi igrač je na redu");
                drugiIgrac();
            }

        }

        private async void button21_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.ToLower() == rjesenja[4])
            {
                textBox5.Enabled = false;

                button21.BackColor = Color.Green;
                await Task.Delay(500);
                button21.BackColor = Color.White;

                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text != "?" && x.Text == "")
                    {
                        x.Text = x.Tag.ToString();
                    }
                }

                //Gotova Igra
                player++;
            }

            else
            {
                MessageBox.Show("Pogrešan odgovor, drugi igrač je na redu");
                drugiIgrac();
            }
        }
    }
}

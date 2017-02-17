﻿using Kviskoteka.Model.Extras;
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
    public partial class ABCPitalicaForm : Form
    {
        List<ABCPitalica> svaPitanja = new List<ABCPitalica>();
        string trenutniTocan;

        int player = 0;
        int player1 = 0;
        int player2 = 0;
        int kviskoBodovi = 0;
        double player1Tezina = Postavke.postavke[0] * 0.3;
        double player2Tezina = Postavke.postavke[3] * 0.3;
        int brojPitanja = 0;

        public ABCPitalicaForm()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            pictureBox2.Region = rg;

            svaPitanja = ABCPitalicaAccess.getAll();

            postaviPitanje();
        }

        private void updateBodovi()
        {
            bodovi.Text = "BODOVI: " + player.ToString();
        }

        private async void odgovorOstalihIgrača()
        {
            Random random = new Random();
            if(random.NextDouble() < player1Tezina)
            {
                player1 += 2;
                pictureBox1.BackColor = Color.SeaGreen; 
            }
            else
            {
                pictureBox1.BackColor = Color.Maroon;
            }
            if (random.NextDouble() < player2Tezina)
            {
                player2 += 2;
                pictureBox2.BackColor = Color.SeaGreen;
            }
            else
            {
                pictureBox2.BackColor = Color.Maroon;
            }

            player1bodovi.Text = "BODOVI: " + player1.ToString();
            player2bodovi.Text = "BODOVI: " + player2.ToString();

            ++brojPitanja;

            //System.Threading.Thread.Sleep(5000);
            await Task.Delay(2000);

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            a_odgovor.BackColor = Color.SkyBlue;
            b_odgovor.BackColor = Color.SkyBlue;
            c_odgovor.BackColor = Color.SkyBlue;
            if (brojPitanja < 5)
            {
                postaviPitanje();
            }
            else
            {
                int kviskoBodovi1 = 0;
                int kviskoBodovi2 = 0;

                if (player >= 6)
                {
                    kviskoBodovi = 1;
                }
                if (player1 >= 6)
                {
                    kviskoBodovi1 = 1;
                }
                if (player2 >= 6)
                {
                    kviskoBodovi2 = 1;
                }

                KviskoForm ni = new KviskoForm(kviskoBodovi, kviskoBodovi1, kviskoBodovi2, player, player1, player2);
                this.Hide();
                ni.ShowDialog();
                this.Close();

            }
        }

        private void postaviPitanje()
        {

            a_odgovor.Enabled = true;
            b_odgovor.Enabled = true;
            c_odgovor.Enabled = true;
            
            updateBodovi();
            Random rand = new Random();
            ABCPitalica prva = svaPitanja[rand.Next(0, svaPitanja.Count)];
            svaPitanja.Remove(prva);

            string[] odgovori = new[] { prva.Tocan, prva.Drugi, prva.Treci };
            trenutniTocan = prva.Tocan;

            Random rnd = new Random();
            pitanje.Text = prva.Pitanje;

            int a = rnd.Next(0, 3);
            a_odgovor.Text = odgovori[a];
            int b = rnd.Next(0, 3);
            while (b == a)
            {
                b = rnd.Next(0, 3);
            }
            b_odgovor.Text = odgovori[b];
            int c = rnd.Next(0, 3);
            while (c == a || c == b)
            {
                c = rnd.Next(0, 3);
            }
            c_odgovor.Text = odgovori[c];

            //spremiti id iskorištenog pitanja

        }

        private void a_odgovor_Click(object sender, EventArgs e)
        {
            b_odgovor.Enabled = false;
            c_odgovor.Enabled = false;
            if (a_odgovor.Text == trenutniTocan)
            {
                a_odgovor.BackColor = Color.SeaGreen;
                player += 2;
            }
            else
            {
                a_odgovor.BackColor = Color.Maroon;
            }

            updateBodovi();
            odgovorOstalihIgrača();
            

        }

        private void b_odgovor_Click(object sender, EventArgs e)
        {
            a_odgovor.Enabled = false;
            c_odgovor.Enabled = false;
            if (b_odgovor.Text == trenutniTocan)
            {
                b_odgovor.BackColor = Color.SeaGreen;
                player += 2;
            }
            else
            {
                b_odgovor.BackColor = Color.Maroon;
            }

            updateBodovi();
            odgovorOstalihIgrača();
            

        }

        private void c_odgovor_Click(object sender, EventArgs e)
        {
            a_odgovor.Enabled = false;
            b_odgovor.Enabled = false;
            if (c_odgovor.Text == trenutniTocan)
            {
                c_odgovor.BackColor = Color.SeaGreen;
                player += 2;
            }
            else
            {
                c_odgovor.BackColor = Color.Maroon;
            }

            updateBodovi();
            odgovorOstalihIgrača();

        }
    }
}

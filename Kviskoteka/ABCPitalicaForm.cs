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
        IEnumerable<int> iskoristenaPitanja = new SortedSet<int>();
        string trenutniTocan;

        int player = 0;
        int player1 = 0;
        int player2 = 0;
        int kviskoBodovi = 0;

        public ABCPitalicaForm()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            pictureBox2.Region = rg;

            postaviPitanje();
        }

        private void updateBodovi()
        {
            bodovi.Text = "BODOVI: " + player.ToString();
        }

        private void postaviPitanje()
        {

            a_odgovor.Enabled = true;
            b_odgovor.Enabled = true;
            c_odgovor.Enabled = true;

            //uzeti pitanje s neiskorištenim id-om
            kvisko.Text = "KVISKO: " + kviskoBodovi.ToString();
            updateBodovi();
            ABCPitalica prva = new ABCPitalica("Koliko je 2+2?", "4", "3", "2");
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

            player1bodovi.Text = player1.ToString();
            player2bodovi.Text = player2.ToString();

            //spremiti id iskorištenog pitanja

        }

        private void a_odgovor_Click(object sender, EventArgs e)
        {
            b_odgovor.Enabled = false;
            c_odgovor.Enabled = false;
            if (a_odgovor.Text == trenutniTocan)
            {
                a_odgovor.BackColor = Color.Green;
                ++player;
            }
            else
            {
                a_odgovor.BackColor = Color.Red;
            }

            updateBodovi();

            //dodati bodove protivnicima ovisno o tezini i promijeniti im boju

        }

        private void b_odgovor_Click(object sender, EventArgs e)
        {
            a_odgovor.Enabled = false;
            c_odgovor.Enabled = false;
            if (b_odgovor.Text == trenutniTocan)
            {
                b_odgovor.BackColor = Color.Green;
                ++player;
            }
            else
            {
                b_odgovor.BackColor = Color.Red;
            }

            updateBodovi();

            //dodati bodove protivnicima ovisno o tezini

        }

        private void c_odgovor_Click(object sender, EventArgs e)
        {
            a_odgovor.Enabled = false;
            b_odgovor.Enabled = false;
            if (c_odgovor.Text == trenutniTocan)
            {
                c_odgovor.BackColor = Color.Green;
                ++player;
            }
            else
            {
                c_odgovor.BackColor = Color.Red;
            }

            updateBodovi();

            //dodati bodove protivnicima ovisno o tezini

        }
    }
}

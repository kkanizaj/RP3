using System.Drawing;

namespace Kviskoteka
{
    partial class ABCPitalicaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABCPitalicaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.a_odgovor = new System.Windows.Forms.Button();
            this.b_odgovor = new System.Windows.Forms.Button();
            this.c_odgovor = new System.Windows.Forms.Button();
            this.pitanje = new System.Windows.Forms.Label();
            this.player1bodovi = new System.Windows.Forms.Label();
            this.player2bodovi = new System.Windows.Forms.Label();
            this.bodovi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kviskoteka.Properties.Resources.prof1;
            this.pictureBox1.Location = new System.Drawing.Point(115, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Kviskoteka.Properties.Resources.prof1;
            this.pictureBox2.Location = new System.Drawing.Point(409, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 132);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // a_odgovor
            // 
            this.a_odgovor.BackColor = System.Drawing.Color.SkyBlue;
            this.a_odgovor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.a_odgovor.FlatAppearance.BorderSize = 2;
            this.a_odgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a_odgovor.Location = new System.Drawing.Point(119, 410);
            this.a_odgovor.Margin = new System.Windows.Forms.Padding(2);
            this.a_odgovor.Name = "a_odgovor";
            this.a_odgovor.Size = new System.Drawing.Size(150, 74);
            this.a_odgovor.TabIndex = 7;
            this.a_odgovor.Text = "button1";
            this.a_odgovor.UseVisualStyleBackColor = false;
            this.a_odgovor.Click += new System.EventHandler(this.a_odgovor_Click);
            // 
            // b_odgovor
            // 
            this.b_odgovor.BackColor = System.Drawing.Color.SkyBlue;
            this.b_odgovor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_odgovor.FlatAppearance.BorderSize = 2;
            this.b_odgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_odgovor.Location = new System.Drawing.Point(332, 410);
            this.b_odgovor.Margin = new System.Windows.Forms.Padding(2);
            this.b_odgovor.Name = "b_odgovor";
            this.b_odgovor.Size = new System.Drawing.Size(150, 74);
            this.b_odgovor.TabIndex = 8;
            this.b_odgovor.Text = "button1";
            this.b_odgovor.UseVisualStyleBackColor = false;
            this.b_odgovor.Click += new System.EventHandler(this.b_odgovor_Click);
            // 
            // c_odgovor
            // 
            this.c_odgovor.BackColor = System.Drawing.Color.SkyBlue;
            this.c_odgovor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.c_odgovor.FlatAppearance.BorderSize = 2;
            this.c_odgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c_odgovor.Location = new System.Drawing.Point(542, 410);
            this.c_odgovor.Margin = new System.Windows.Forms.Padding(2);
            this.c_odgovor.Name = "c_odgovor";
            this.c_odgovor.Size = new System.Drawing.Size(150, 74);
            this.c_odgovor.TabIndex = 9;
            this.c_odgovor.Text = "button1";
            this.c_odgovor.UseVisualStyleBackColor = false;
            this.c_odgovor.Click += new System.EventHandler(this.c_odgovor_Click);
            // 
            // pitanje
            // 
            this.pitanje.BackColor = System.Drawing.Color.SkyBlue;
            this.pitanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pitanje.Location = new System.Drawing.Point(115, 266);
            this.pitanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pitanje.Name = "pitanje";
            this.pitanje.Size = new System.Drawing.Size(578, 79);
            this.pitanje.TabIndex = 11;
            this.pitanje.Text = "label";
            this.pitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1bodovi
            // 
            this.player1bodovi.AutoSize = true;
            this.player1bodovi.BackColor = System.Drawing.Color.Transparent;
            this.player1bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1bodovi.Location = new System.Drawing.Point(243, 148);
            this.player1bodovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1bodovi.Name = "player1bodovi";
            this.player1bodovi.Size = new System.Drawing.Size(0, 24);
            this.player1bodovi.TabIndex = 12;
            // 
            // player2bodovi
            // 
            this.player2bodovi.AutoSize = true;
            this.player2bodovi.BackColor = System.Drawing.Color.Transparent;
            this.player2bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2bodovi.Location = new System.Drawing.Point(538, 148);
            this.player2bodovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2bodovi.Name = "player2bodovi";
            this.player2bodovi.Size = new System.Drawing.Size(0, 24);
            this.player2bodovi.TabIndex = 13;
            // 
            // bodovi
            // 
            this.bodovi.AutoSize = true;
            this.bodovi.BackColor = System.Drawing.Color.Transparent;
            this.bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodovi.Location = new System.Drawing.Point(716, 148);
            this.bodovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bodovi.Name = "bodovi";
            this.bodovi.Size = new System.Drawing.Size(73, 24);
            this.bodovi.TabIndex = 15;
            this.bodovi.Text = "Bodovi:";
            // 
            // ABCPitalicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviskoteka.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.bodovi);
            this.Controls.Add(this.player2bodovi);
            this.Controls.Add(this.player1bodovi);
            this.Controls.Add(this.pitanje);
            this.Controls.Add(this.c_odgovor);
            this.Controls.Add(this.b_odgovor);
            this.Controls.Add(this.a_odgovor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ABCPitalicaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC pitalica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button a_odgovor;
        private System.Windows.Forms.Button b_odgovor;
        private System.Windows.Forms.Button c_odgovor;
        private System.Windows.Forms.Label pitanje;
        private System.Windows.Forms.Label player1bodovi;
        private System.Windows.Forms.Label player2bodovi;
        private System.Windows.Forms.Label bodovi;
    }
}
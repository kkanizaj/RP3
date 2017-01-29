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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player2bodovi = new System.Windows.Forms.TextBox();
            this.player1bodovi = new System.Windows.Forms.TextBox();
            this.kvisko = new System.Windows.Forms.TextBox();
            this.pitanje = new System.Windows.Forms.TextBox();
            this.a_odgovor = new System.Windows.Forms.Button();
            this.b_odgovor = new System.Windows.Forms.Button();
            this.c_odgovor = new System.Windows.Forms.Button();
            this.bodovi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Image = global::Kviskoteka.Properties.Resources.prof1;
            this.pictureBox1.Location = new System.Drawing.Point(121, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox2.Image = global::Kviskoteka.Properties.Resources.prof1;
            this.pictureBox2.Location = new System.Drawing.Point(709, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 162);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // player2bodovi
            // 
            this.player2bodovi.Location = new System.Drawing.Point(896, 169);
            this.player2bodovi.Name = "player2bodovi";
            this.player2bodovi.Size = new System.Drawing.Size(108, 22);
            this.player2bodovi.TabIndex = 2;
            // 
            // player1bodovi
            // 
            this.player1bodovi.Location = new System.Drawing.Point(311, 169);
            this.player1bodovi.Name = "player1bodovi";
            this.player1bodovi.Size = new System.Drawing.Size(112, 22);
            this.player1bodovi.TabIndex = 3;
            // 
            // kvisko
            // 
            this.kvisko.Location = new System.Drawing.Point(1182, 29);
            this.kvisko.Name = "kvisko";
            this.kvisko.Size = new System.Drawing.Size(81, 22);
            this.kvisko.TabIndex = 5;
            this.kvisko.Text = "KVISKO:";
            // 
            // pitanje
            // 
            this.pitanje.Location = new System.Drawing.Point(121, 244);
            this.pitanje.Name = "pitanje";
            this.pitanje.Size = new System.Drawing.Size(804, 22);
            this.pitanje.TabIndex = 6;
            // 
            // a_odgovor
            // 
            this.a_odgovor.Location = new System.Drawing.Point(147, 320);
            this.a_odgovor.Name = "a_odgovor";
            this.a_odgovor.Size = new System.Drawing.Size(172, 91);
            this.a_odgovor.TabIndex = 7;
            this.a_odgovor.Text = "button1";
            this.a_odgovor.UseVisualStyleBackColor = true;
            this.a_odgovor.Click += new System.EventHandler(this.a_odgovor_Click);
            // 
            // b_odgovor
            // 
            this.b_odgovor.Location = new System.Drawing.Point(437, 320);
            this.b_odgovor.Name = "b_odgovor";
            this.b_odgovor.Size = new System.Drawing.Size(172, 91);
            this.b_odgovor.TabIndex = 8;
            this.b_odgovor.Text = "button1";
            this.b_odgovor.UseVisualStyleBackColor = true;
            this.b_odgovor.Click += new System.EventHandler(this.b_odgovor_Click);
            // 
            // c_odgovor
            // 
            this.c_odgovor.Location = new System.Drawing.Point(719, 320);
            this.c_odgovor.Name = "c_odgovor";
            this.c_odgovor.Size = new System.Drawing.Size(172, 91);
            this.c_odgovor.TabIndex = 9;
            this.c_odgovor.Text = "button1";
            this.c_odgovor.UseVisualStyleBackColor = true;
            this.c_odgovor.Click += new System.EventHandler(this.c_odgovor_Click);
            // 
            // bodovi
            // 
            this.bodovi.Location = new System.Drawing.Point(1182, 69);
            this.bodovi.Name = "bodovi";
            this.bodovi.Size = new System.Drawing.Size(81, 22);
            this.bodovi.TabIndex = 10;
            this.bodovi.Text = "BODOVI:";
            // 
            // ABCPitalicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 719);
            this.Controls.Add(this.bodovi);
            this.Controls.Add(this.c_odgovor);
            this.Controls.Add(this.b_odgovor);
            this.Controls.Add(this.a_odgovor);
            this.Controls.Add(this.pitanje);
            this.Controls.Add(this.kvisko);
            this.Controls.Add(this.player1bodovi);
            this.Controls.Add(this.player2bodovi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ABCPitalicaForm";
            this.Text = "ABCPitalicaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox player2bodovi;
        private System.Windows.Forms.TextBox player1bodovi;
        private System.Windows.Forms.TextBox kvisko;
        private System.Windows.Forms.TextBox pitanje;
        private System.Windows.Forms.Button a_odgovor;
        private System.Windows.Forms.Button b_odgovor;
        private System.Windows.Forms.Button c_odgovor;
        private System.Windows.Forms.TextBox bodovi;
    }
}
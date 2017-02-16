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
            this.a_odgovor = new System.Windows.Forms.Button();
            this.b_odgovor = new System.Windows.Forms.Button();
            this.c_odgovor = new System.Windows.Forms.Button();
            this.pitanje = new System.Windows.Forms.Label();
            this.player1bodovi = new System.Windows.Forms.Label();
            this.player2bodovi = new System.Windows.Forms.Label();
            this.kvisko = new System.Windows.Forms.Label();
            this.bodovi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Image = global::Kviskoteka.Properties.Resources.prof1;
            this.pictureBox1.Location = new System.Drawing.Point(50, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox2.Image = global::Kviskoteka.Properties.Resources.prof1;
            this.pictureBox2.Location = new System.Drawing.Point(400, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 162);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // a_odgovor
            // 
            this.a_odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a_odgovor.Location = new System.Drawing.Point(106, 353);
            this.a_odgovor.Name = "a_odgovor";
            this.a_odgovor.Size = new System.Drawing.Size(172, 91);
            this.a_odgovor.TabIndex = 7;
            this.a_odgovor.Text = "button1";
            this.a_odgovor.UseVisualStyleBackColor = true;
            this.a_odgovor.Click += new System.EventHandler(this.a_odgovor_Click);
            // 
            // b_odgovor
            // 
            this.b_odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_odgovor.Location = new System.Drawing.Point(390, 353);
            this.b_odgovor.Name = "b_odgovor";
            this.b_odgovor.Size = new System.Drawing.Size(172, 91);
            this.b_odgovor.TabIndex = 8;
            this.b_odgovor.Text = "button1";
            this.b_odgovor.UseVisualStyleBackColor = true;
            this.b_odgovor.Click += new System.EventHandler(this.b_odgovor_Click);
            // 
            // c_odgovor
            // 
            this.c_odgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c_odgovor.Location = new System.Drawing.Point(670, 353);
            this.c_odgovor.Name = "c_odgovor";
            this.c_odgovor.Size = new System.Drawing.Size(172, 91);
            this.c_odgovor.TabIndex = 9;
            this.c_odgovor.Text = "button1";
            this.c_odgovor.UseVisualStyleBackColor = true;
            this.c_odgovor.Click += new System.EventHandler(this.c_odgovor_Click);
            // 
            // pitanje
            // 
            this.pitanje.AutoSize = true;
            this.pitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pitanje.Location = new System.Drawing.Point(100, 242);
            this.pitanje.Name = "pitanje";
            this.pitanje.Size = new System.Drawing.Size(77, 32);
            this.pitanje.TabIndex = 11;
            this.pitanje.Text = "label";
            this.pitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1bodovi
            // 
            this.player1bodovi.AutoSize = true;
            this.player1bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1bodovi.Location = new System.Drawing.Point(222, 146);
            this.player1bodovi.Name = "player1bodovi";
            this.player1bodovi.Size = new System.Drawing.Size(0, 29);
            this.player1bodovi.TabIndex = 12;
            // 
            // player2bodovi
            // 
            this.player2bodovi.AutoSize = true;
            this.player2bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2bodovi.Location = new System.Drawing.Point(572, 146);
            this.player2bodovi.Name = "player2bodovi";
            this.player2bodovi.Size = new System.Drawing.Size(0, 29);
            this.player2bodovi.TabIndex = 13;
            // 
            // kvisko
            // 
            this.kvisko.AutoSize = true;
            this.kvisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kvisko.Location = new System.Drawing.Point(746, 75);
            this.kvisko.Name = "kvisko";
            this.kvisko.Size = new System.Drawing.Size(96, 29);
            this.kvisko.TabIndex = 14;
            this.kvisko.Text = "Kvisko: ";
            // 
            // bodovi
            // 
            this.bodovi.AutoSize = true;
            this.bodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodovi.Location = new System.Drawing.Point(746, 121);
            this.bodovi.Name = "bodovi";
            this.bodovi.Size = new System.Drawing.Size(94, 29);
            this.bodovi.TabIndex = 15;
            this.bodovi.Text = "Bodovi:";
            // 
            // ABCPitalicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.bodovi);
            this.Controls.Add(this.kvisko);
            this.Controls.Add(this.player2bodovi);
            this.Controls.Add(this.player1bodovi);
            this.Controls.Add(this.pitanje);
            this.Controls.Add(this.c_odgovor);
            this.Controls.Add(this.b_odgovor);
            this.Controls.Add(this.a_odgovor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ABCPitalicaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABCPitalicaForm";
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
        private System.Windows.Forms.Label kvisko;
        private System.Windows.Forms.Label bodovi;
    }
}
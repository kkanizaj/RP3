namespace Kviskoteka
{
    partial class Napredne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Napredne));
            this.ABC = new System.Windows.Forms.Button();
            this.Asocijacije = new System.Windows.Forms.Button();
            this.Završna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Natrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABC
            // 
            this.ABC.BackColor = System.Drawing.Color.SkyBlue;
            this.ABC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ABC.FlatAppearance.BorderSize = 2;
            this.ABC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ABC.Location = new System.Drawing.Point(159, 106);
            this.ABC.Margin = new System.Windows.Forms.Padding(2);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(225, 81);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Pitalica";
            this.ABC.UseVisualStyleBackColor = false;
            this.ABC.Click += new System.EventHandler(this.ABC_Click);
            // 
            // Asocijacije
            // 
            this.Asocijacije.BackColor = System.Drawing.Color.SkyBlue;
            this.Asocijacije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Asocijacije.FlatAppearance.BorderSize = 2;
            this.Asocijacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asocijacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Asocijacije.Location = new System.Drawing.Point(159, 202);
            this.Asocijacije.Margin = new System.Windows.Forms.Padding(2);
            this.Asocijacije.Name = "Asocijacije";
            this.Asocijacije.Size = new System.Drawing.Size(225, 81);
            this.Asocijacije.TabIndex = 1;
            this.Asocijacije.Text = "Asocijacije";
            this.Asocijacije.UseVisualStyleBackColor = false;
            this.Asocijacije.Click += new System.EventHandler(this.Asocijacije_Click);
            // 
            // Završna
            // 
            this.Završna.BackColor = System.Drawing.Color.SkyBlue;
            this.Završna.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Završna.FlatAppearance.BorderSize = 2;
            this.Završna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Završna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Završna.Location = new System.Drawing.Point(159, 301);
            this.Završna.Margin = new System.Windows.Forms.Padding(2);
            this.Završna.Name = "Završna";
            this.Završna.Size = new System.Drawing.Size(225, 81);
            this.Završna.TabIndex = 2;
            this.Završna.Text = "Završna Igra";
            this.Završna.UseVisualStyleBackColor = false;
            this.Završna.Click += new System.EventHandler(this.Završna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberite igru za koju želite dodati pitanja";
            // 
            // Natrag
            // 
            this.Natrag.BackColor = System.Drawing.Color.SkyBlue;
            this.Natrag.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Natrag.FlatAppearance.BorderSize = 2;
            this.Natrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Natrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Natrag.Location = new System.Drawing.Point(476, 390);
            this.Natrag.Margin = new System.Windows.Forms.Padding(2);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(112, 34);
            this.Natrag.TabIndex = 4;
            this.Natrag.Text = "NATRAG";
            this.Natrag.UseVisualStyleBackColor = false;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // Napredne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviskoteka.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 453);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Završna);
            this.Controls.Add(this.Asocijacije);
            this.Controls.Add(this.ABC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Napredne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Napredne postavke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ABC;
        private System.Windows.Forms.Button Asocijacije;
        private System.Windows.Forms.Button Završna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Natrag;
    }
}
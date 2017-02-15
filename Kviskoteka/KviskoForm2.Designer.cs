namespace Kviskoteka
{
    partial class KviskoForm2
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
            this.asocijacije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kvisko = new System.Windows.Forms.Button();
            this.startZavršna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asocijacije
            // 
            this.asocijacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asocijacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asocijacije.Location = new System.Drawing.Point(0, 0);
            this.asocijacije.Name = "asocijacije";
            this.asocijacije.Size = new System.Drawing.Size(822, 56);
            this.asocijacije.TabIndex = 2;
            this.asocijacije.Text = "Završna igra";
            this.asocijacije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(640, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 8;
            // 
            // kvisko
            // 
            this.kvisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kvisko.Location = new System.Drawing.Point(182, 182);
            this.kvisko.Name = "kvisko";
            this.kvisko.Size = new System.Drawing.Size(411, 71);
            this.kvisko.TabIndex = 7;
            this.kvisko.Text = "Uloži kvisko";
            this.kvisko.UseVisualStyleBackColor = true;
            this.kvisko.Click += new System.EventHandler(this.kvisko_Click);
            // 
            // startZavršna
            // 
            this.startZavršna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startZavršna.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startZavršna.Location = new System.Drawing.Point(182, 290);
            this.startZavršna.Name = "startZavršna";
            this.startZavršna.Size = new System.Drawing.Size(411, 95);
            this.startZavršna.TabIndex = 6;
            this.startZavršna.Text = "START";
            this.startZavršna.UseVisualStyleBackColor = true;
            this.startZavršna.Click += new System.EventHandler(this.startZavršna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(161, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 9;
            // 
            // KviskoForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kvisko);
            this.Controls.Add(this.startZavršna);
            this.Controls.Add(this.asocijacije);
            this.Name = "KviskoForm2";
            this.Text = "KviskoForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asocijacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kvisko;
        private System.Windows.Forms.Button startZavršna;
        private System.Windows.Forms.Label label1;
    }
}
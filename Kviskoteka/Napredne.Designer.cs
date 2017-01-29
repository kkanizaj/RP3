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
            this.ABC = new System.Windows.Forms.Button();
            this.Asocijacije = new System.Windows.Forms.Button();
            this.Završna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Natrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABC
            // 
            this.ABC.Location = new System.Drawing.Point(213, 87);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(342, 97);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Pitalica";
            this.ABC.UseVisualStyleBackColor = true;
            this.ABC.Click += new System.EventHandler(this.ABC_Click);
            // 
            // Asocijacije
            // 
            this.Asocijacije.Location = new System.Drawing.Point(213, 205);
            this.Asocijacije.Name = "Asocijacije";
            this.Asocijacije.Size = new System.Drawing.Size(342, 97);
            this.Asocijacije.TabIndex = 1;
            this.Asocijacije.Text = "Asocijacije";
            this.Asocijacije.UseVisualStyleBackColor = true;
            this.Asocijacije.Click += new System.EventHandler(this.Asocijacije_Click);
            // 
            // Završna
            // 
            this.Završna.Location = new System.Drawing.Point(213, 327);
            this.Završna.Name = "Završna";
            this.Završna.Size = new System.Drawing.Size(342, 97);
            this.Završna.TabIndex = 2;
            this.Završna.Text = "Završna Igra";
            this.Završna.UseVisualStyleBackColor = true;
            this.Završna.Click += new System.EventHandler(this.Završna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberite igru za koju želite dodati pitanja";
            // 
            // Natrag
            // 
            this.Natrag.Location = new System.Drawing.Point(651, 416);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(112, 42);
            this.Natrag.TabIndex = 4;
            this.Natrag.Text = "NATRAG";
            this.Natrag.UseVisualStyleBackColor = true;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // Napredne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Završna);
            this.Controls.Add(this.Asocijacije);
            this.Controls.Add(this.ABC);
            this.Name = "Napredne";
            this.Text = "Napredne";
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
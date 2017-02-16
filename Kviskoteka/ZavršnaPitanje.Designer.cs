namespace Kviskoteka
{
    partial class ZavršnaPitanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pitanje = new System.Windows.Forms.TextBox();
            this.Odgovor = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Natrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(56, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(56, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odgovor";
            // 
            // Pitanje
            // 
            this.Pitanje.Location = new System.Drawing.Point(221, 119);
            this.Pitanje.Name = "Pitanje";
            this.Pitanje.Size = new System.Drawing.Size(359, 22);
            this.Pitanje.TabIndex = 2;
            // 
            // Odgovor
            // 
            this.Odgovor.Location = new System.Drawing.Point(221, 207);
            this.Odgovor.Name = "Odgovor";
            this.Odgovor.Size = new System.Drawing.Size(359, 22);
            this.Odgovor.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Save.Location = new System.Drawing.Point(430, 325);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 50);
            this.Save.TabIndex = 4;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Natrag
            // 
            this.Natrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Natrag.Location = new System.Drawing.Point(61, 325);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(150, 50);
            this.Natrag.TabIndex = 5;
            this.Natrag.Text = "NATRAG";
            this.Natrag.UseVisualStyleBackColor = true;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // ZavršnaPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Odgovor);
            this.Controls.Add(this.Pitanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ZavršnaPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZavršnaPitanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pitanje;
        private System.Windows.Forms.TextBox Odgovor;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Natrag;
    }
}
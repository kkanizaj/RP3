namespace Kviskoteka
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.NovaIgra = new System.Windows.Forms.Button();
            this.Postavke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NovaIgra
            // 
            this.NovaIgra.BackColor = System.Drawing.Color.SkyBlue;
            this.NovaIgra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NovaIgra.FlatAppearance.BorderSize = 2;
            this.NovaIgra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovaIgra.Location = new System.Drawing.Point(200, 174);
            this.NovaIgra.Name = "NovaIgra";
            this.NovaIgra.Size = new System.Drawing.Size(300, 100);
            this.NovaIgra.TabIndex = 1;
            this.NovaIgra.Text = "Nova igra";
            this.NovaIgra.UseVisualStyleBackColor = false;
            this.NovaIgra.Click += new System.EventHandler(this.NovaIgra_Click);
            // 
            // Postavke
            // 
            this.Postavke.BackColor = System.Drawing.Color.SkyBlue;
            this.Postavke.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Postavke.FlatAppearance.BorderSize = 2;
            this.Postavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Postavke.Location = new System.Drawing.Point(200, 306);
            this.Postavke.Name = "Postavke";
            this.Postavke.Size = new System.Drawing.Size(300, 100);
            this.Postavke.TabIndex = 2;
            this.Postavke.Text = "Postavke";
            this.Postavke.UseVisualStyleBackColor = false;
            this.Postavke.Click += new System.EventHandler(this.Postavke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(205, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kviskoteka";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviskoteka.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Postavke);
            this.Controls.Add(this.NovaIgra);
            this.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kviskoteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NovaIgra;
        private System.Windows.Forms.Button Postavke;
        private System.Windows.Forms.Label label1;
    }
}


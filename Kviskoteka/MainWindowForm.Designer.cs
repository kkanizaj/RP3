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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NovaIgra = new System.Windows.Forms.Button();
            this.Postavke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1299, 55);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "KVISKOTEKA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NovaIgra
            // 
            this.NovaIgra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NovaIgra.Location = new System.Drawing.Point(406, 213);
            this.NovaIgra.Name = "NovaIgra";
            this.NovaIgra.Size = new System.Drawing.Size(472, 120);
            this.NovaIgra.TabIndex = 1;
            this.NovaIgra.Text = "Nova igra";
            this.NovaIgra.UseVisualStyleBackColor = true;
            this.NovaIgra.Click += new System.EventHandler(this.NovaIgra_Click);
            // 
            // Postavke
            // 
            this.Postavke.Location = new System.Drawing.Point(406, 393);
            this.Postavke.Name = "Postavke";
            this.Postavke.Size = new System.Drawing.Size(472, 120);
            this.Postavke.TabIndex = 2;
            this.Postavke.Text = "Postavke";
            this.Postavke.UseVisualStyleBackColor = true;
            this.Postavke.Click += new System.EventHandler(this.Postavke_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 719);
            this.Controls.Add(this.Postavke);
            this.Controls.Add(this.NovaIgra);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "MainWindowForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NovaIgra;
        private System.Windows.Forms.Button Postavke;
    }
}


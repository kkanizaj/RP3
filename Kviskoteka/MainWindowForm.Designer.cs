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
            this.NovaIgra = new System.Windows.Forms.Button();
            this.Postavke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NovaIgra
            // 
            this.NovaIgra.Location = new System.Drawing.Point(200, 145);
            this.NovaIgra.Name = "NovaIgra";
            this.NovaIgra.Size = new System.Drawing.Size(300, 100);
            this.NovaIgra.TabIndex = 1;
            this.NovaIgra.Text = "Nova igra";
            this.NovaIgra.UseVisualStyleBackColor = true;
            this.NovaIgra.Click += new System.EventHandler(this.NovaIgra_Click);
            // 
            // Postavke
            // 
            this.Postavke.Location = new System.Drawing.Point(200, 280);
            this.Postavke.Name = "Postavke";
            this.Postavke.Size = new System.Drawing.Size(300, 100);
            this.Postavke.TabIndex = 2;
            this.Postavke.Text = "Postavke";
            this.Postavke.UseVisualStyleBackColor = true;
            this.Postavke.Click += new System.EventHandler(this.Postavke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kviskoteka";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Postavke);
            this.Controls.Add(this.NovaIgra);
            this.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NovaIgra;
        private System.Windows.Forms.Button Postavke;
        private System.Windows.Forms.Label label1;
    }
}


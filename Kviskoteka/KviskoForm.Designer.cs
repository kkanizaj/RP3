namespace Kviskoteka
{
    partial class KviskoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KviskoForm));
            this.startAsocijacije = new System.Windows.Forms.Button();
            this.kvisko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startAsocijacije
            // 
            this.startAsocijacije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startAsocijacije.BackColor = System.Drawing.Color.SkyBlue;
            this.startAsocijacije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startAsocijacije.FlatAppearance.BorderSize = 2;
            this.startAsocijacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startAsocijacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startAsocijacije.Location = new System.Drawing.Point(148, 250);
            this.startAsocijacije.Margin = new System.Windows.Forms.Padding(2);
            this.startAsocijacije.Name = "startAsocijacije";
            this.startAsocijacije.Size = new System.Drawing.Size(225, 81);
            this.startAsocijacije.TabIndex = 2;
            this.startAsocijacije.Text = "START";
            this.startAsocijacije.UseVisualStyleBackColor = false;
            this.startAsocijacije.Click += new System.EventHandler(this.startAsocijacije_Click);
            // 
            // kvisko
            // 
            this.kvisko.BackColor = System.Drawing.Color.SkyBlue;
            this.kvisko.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.kvisko.FlatAppearance.BorderSize = 2;
            this.kvisko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kvisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kvisko.Location = new System.Drawing.Point(148, 141);
            this.kvisko.Margin = new System.Windows.Forms.Padding(2);
            this.kvisko.Name = "kvisko";
            this.kvisko.Size = new System.Drawing.Size(225, 81);
            this.kvisko.TabIndex = 3;
            this.kvisko.Text = "ULOŽI KVISKO";
            this.kvisko.UseVisualStyleBackColor = false;
            this.kvisko.Click += new System.EventHandler(this.kvisko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(171, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(171, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asocijacije";
            // 
            // KviskoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviskoteka.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(512, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kvisko);
            this.Controls.Add(this.startAsocijacije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "KviskoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startAsocijacije;
        private System.Windows.Forms.Button kvisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
﻿namespace Kviskoteka
{
    partial class ABCPitanje
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
            this.pitanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treci = new System.Windows.Forms.TextBox();
            this.drugi = new System.Windows.Forms.TextBox();
            this.tocan = new System.Windows.Forms.TextBox();
            this.spremi = new System.Windows.Forms.Button();
            this.natrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje:";
            // 
            // pitanje
            // 
            this.pitanje.Location = new System.Drawing.Point(317, 90);
            this.pitanje.Name = "pitanje";
            this.pitanje.Size = new System.Drawing.Size(279, 22);
            this.pitanje.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Točan odgovor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pogrešan odgovor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pogrešan odgovor:";
            // 
            // treci
            // 
            this.treci.Location = new System.Drawing.Point(317, 217);
            this.treci.Name = "treci";
            this.treci.Size = new System.Drawing.Size(279, 22);
            this.treci.TabIndex = 6;
            // 
            // drugi
            // 
            this.drugi.Location = new System.Drawing.Point(317, 175);
            this.drugi.Name = "drugi";
            this.drugi.Size = new System.Drawing.Size(279, 22);
            this.drugi.TabIndex = 7;
            // 
            // tocan
            // 
            this.tocan.Location = new System.Drawing.Point(317, 134);
            this.tocan.Name = "tocan";
            this.tocan.Size = new System.Drawing.Size(279, 22);
            this.tocan.TabIndex = 8;
            // 
            // spremi
            // 
            this.spremi.Location = new System.Drawing.Point(614, 350);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(96, 36);
            this.spremi.TabIndex = 9;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // natrag
            // 
            this.natrag.Location = new System.Drawing.Point(508, 350);
            this.natrag.Name = "natrag";
            this.natrag.Size = new System.Drawing.Size(88, 36);
            this.natrag.TabIndex = 10;
            this.natrag.Text = "Natrag";
            this.natrag.UseVisualStyleBackColor = true;
            this.natrag.Click += new System.EventHandler(this.natrag_Click);
            // 
            // ABCPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 479);
            this.Controls.Add(this.natrag);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.tocan);
            this.Controls.Add(this.drugi);
            this.Controls.Add(this.treci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pitanje);
            this.Controls.Add(this.label1);
            this.Name = "ABCPitanje";
            this.Text = "ABCPitanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pitanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox treci;
        private System.Windows.Forms.TextBox drugi;
        private System.Windows.Forms.TextBox tocan;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.Button natrag;
    }
}
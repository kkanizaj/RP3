﻿namespace Kviskoteka
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
            this.asocijacije = new System.Windows.Forms.TextBox();
            this.startAsocijacije = new System.Windows.Forms.Button();
            this.kvisko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // asocijacije
            // 
            this.asocijacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asocijacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asocijacije.Location = new System.Drawing.Point(0, 0);
            this.asocijacije.Name = "asocijacije";
            this.asocijacije.Size = new System.Drawing.Size(822, 56);
            this.asocijacije.TabIndex = 1;
            this.asocijacije.Text = "Asocijacije";
            this.asocijacije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startAsocijacije
            // 
            this.startAsocijacije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startAsocijacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startAsocijacije.Location = new System.Drawing.Point(196, 300);
            this.startAsocijacije.Name = "startAsocijacije";
            this.startAsocijacije.Size = new System.Drawing.Size(411, 95);
            this.startAsocijacije.TabIndex = 2;
            this.startAsocijacije.Text = "START";
            this.startAsocijacije.UseVisualStyleBackColor = true;
            this.startAsocijacije.Click += new System.EventHandler(this.startAsocijacije_Click);
            // 
            // kvisko
            // 
            this.kvisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kvisko.Location = new System.Drawing.Point(196, 199);
            this.kvisko.Name = "kvisko";
            this.kvisko.Size = new System.Drawing.Size(411, 71);
            this.kvisko.TabIndex = 3;
            this.kvisko.Text = "Uloži kvisko";
            this.kvisko.UseVisualStyleBackColor = true;
            this.kvisko.Click += new System.EventHandler(this.kvisko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(121, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(654, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 5;
            // 
            // KviskoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kvisko);
            this.Controls.Add(this.startAsocijacije);
            this.Controls.Add(this.asocijacije);
            this.Name = "KviskoForm";
            this.Text = "KviskoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asocijacije;
        private System.Windows.Forms.Button startAsocijacije;
        private System.Windows.Forms.Button kvisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
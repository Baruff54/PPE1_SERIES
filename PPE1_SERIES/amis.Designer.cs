﻿namespace PPE1_SERIES
{
    partial class amis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajouter = new System.Windows.Forms.Button();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.ajoute = new System.Windows.Forms.Label();
            this.rechercher = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.ami = new System.Windows.Forms.Label();
            this.listeAmi = new System.Windows.Forms.ListBox();
            this.accueil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.tb_2);
            this.panel1.Controls.Add(this.ajoute);
            this.panel1.Controls.Add(this.rechercher);
            this.panel1.Controls.Add(this.tb_1);
            this.panel1.Controls.Add(this.ami);
            this.panel1.Controls.Add(this.listeAmi);
            this.panel1.Controls.Add(this.accueil);
            this.panel1.Location = new System.Drawing.Point(36, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 379);
            this.panel1.TabIndex = 0;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(217, 341);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 9;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(111, 341);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 20);
            this.tb_2.TabIndex = 8;
            // 
            // ajoute
            // 
            this.ajoute.AutoSize = true;
            this.ajoute.Location = new System.Drawing.Point(49, 344);
            this.ajoute.Name = "ajoute";
            this.ajoute.Size = new System.Drawing.Size(59, 13);
            this.ajoute.TabIndex = 7;
            this.ajoute.Text = "Ajouter ami";
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(217, 70);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(75, 23);
            this.rechercher.TabIndex = 6;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = true;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(111, 70);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 20);
            this.tb_1.TabIndex = 5;
            // 
            // ami
            // 
            this.ami.AutoSize = true;
            this.ami.Location = new System.Drawing.Point(49, 73);
            this.ami.Name = "ami";
            this.ami.Size = new System.Drawing.Size(56, 13);
            this.ami.TabIndex = 4;
            this.ami.Text = "Nom d\'ami";
            // 
            // listeAmi
            // 
            this.listeAmi.FormattingEnabled = true;
            this.listeAmi.Location = new System.Drawing.Point(28, 103);
            this.listeAmi.Name = "listeAmi";
            this.listeAmi.Size = new System.Drawing.Size(329, 212);
            this.listeAmi.TabIndex = 3;
            // 
            // accueil
            // 
            this.accueil.Location = new System.Drawing.Point(123, 16);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(115, 26);
            this.accueil.TabIndex = 2;
            this.accueil.Text = "Accueil";
            this.accueil.UseVisualStyleBackColor = true;
            this.accueil.Click += new System.EventHandler(this.accueil_Click_1);
            // 
            // amis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.panel1);
            this.Name = "amis";
            this.Text = "Accueil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label ami;
        private System.Windows.Forms.ListBox listeAmi;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label ajoute;
    }
}
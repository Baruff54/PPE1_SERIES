namespace PPE1_SERIES
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.profil = new System.Windows.Forms.Button();
            this.Connexion = new System.Windows.Forms.Button();
            this.recherche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.maListe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nbEpisodeTexte = new System.Windows.Forms.Label();
            this.nbSaisonTexte = new System.Windows.Forms.Label();
            this.dateSortieTexte = new System.Windows.Forms.Label();
            this.GenreTexte = new System.Windows.Forms.Label();
            this.titreTexte = new System.Windows.Forms.Label();
            this.ajoutListe = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(13, 13);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(143, 49);
            this.profil.TabIndex = 0;
            this.profil.Text = "Mon profil";
            this.profil.UseVisualStyleBackColor = true;
            this.profil.Visible = false;
            this.profil.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connexion
            // 
            this.Connexion.Location = new System.Drawing.Point(304, 13);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(141, 49);
            this.Connexion.TabIndex = 1;
            this.Connexion.Text = "Connexion";
            this.Connexion.UseVisualStyleBackColor = true;
            this.Connexion.Click += new System.EventHandler(this.button2_Click);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(76, 461);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(142, 20);
            this.recherche.TabIndex = 12;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nom série :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 119);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 316);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // maListe
            // 
            this.maListe.Location = new System.Drawing.Point(163, 13);
            this.maListe.Name = "maListe";
            this.maListe.Size = new System.Drawing.Size(135, 49);
            this.maListe.TabIndex = 14;
            this.maListe.Text = "Ma Liste";
            this.maListe.UseVisualStyleBackColor = true;
            this.maListe.Visible = false;
            this.maListe.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nbEpisodeTexte);
            this.panel1.Controls.Add(this.nbSaisonTexte);
            this.panel1.Controls.Add(this.dateSortieTexte);
            this.panel1.Controls.Add(this.GenreTexte);
            this.panel1.Controls.Add(this.titreTexte);
            this.panel1.Location = new System.Drawing.Point(16, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 96);
            this.panel1.TabIndex = 15;
            // 
            // nbEpisodeTexte
            // 
            this.nbEpisodeTexte.AutoSize = true;
            this.nbEpisodeTexte.Location = new System.Drawing.Point(4, 72);
            this.nbEpisodeTexte.Name = "nbEpisodeTexte";
            this.nbEpisodeTexte.Size = new System.Drawing.Size(118, 13);
            this.nbEpisodeTexte.TabIndex = 4;
            this.nbEpisodeTexte.Text = "Nombre d\'épisode total:";
            // 
            // nbSaisonTexte
            // 
            this.nbSaisonTexte.AutoSize = true;
            this.nbSaisonTexte.Location = new System.Drawing.Point(4, 55);
            this.nbSaisonTexte.Name = "nbSaisonTexte";
            this.nbSaisonTexte.Size = new System.Drawing.Size(95, 13);
            this.nbSaisonTexte.TabIndex = 3;
            this.nbSaisonTexte.Text = "Nombre de saison:";
            // 
            // dateSortieTexte
            // 
            this.dateSortieTexte.AutoSize = true;
            this.dateSortieTexte.Location = new System.Drawing.Point(4, 38);
            this.dateSortieTexte.Name = "dateSortieTexte";
            this.dateSortieTexte.Size = new System.Drawing.Size(76, 13);
            this.dateSortieTexte.TabIndex = 2;
            this.dateSortieTexte.Text = "Date de sortie:";
            // 
            // GenreTexte
            // 
            this.GenreTexte.AutoSize = true;
            this.GenreTexte.Location = new System.Drawing.Point(4, 21);
            this.GenreTexte.Name = "GenreTexte";
            this.GenreTexte.Size = new System.Drawing.Size(39, 13);
            this.GenreTexte.TabIndex = 1;
            this.GenreTexte.Text = "Genre:";
            // 
            // titreTexte
            // 
            this.titreTexte.AutoSize = true;
            this.titreTexte.Location = new System.Drawing.Point(4, 4);
            this.titreTexte.Name = "titreTexte";
            this.titreTexte.Size = new System.Drawing.Size(31, 13);
            this.titreTexte.TabIndex = 0;
            this.titreTexte.Text = "Titre:";
            // 
            // ajoutListe
            // 
            this.ajoutListe.Location = new System.Drawing.Point(348, 459);
            this.ajoutListe.Name = "ajoutListe";
            this.ajoutListe.Size = new System.Drawing.Size(97, 23);
            this.ajoutListe.TabIndex = 16;
            this.ajoutListe.Text = "Ajouter à ma liste";
            this.ajoutListe.UseVisualStyleBackColor = true;
            this.ajoutListe.Visible = false;
            this.ajoutListe.Click += new System.EventHandler(this.ajoutListe_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(15, 68);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(430, 45);
            this.adminButton.TabIndex = 17;
            this.adminButton.Text = "Administration";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 605);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.ajoutListe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maListe);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.profil);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button profil;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button maListe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nbEpisodeTexte;
        private System.Windows.Forms.Label nbSaisonTexte;
        private System.Windows.Forms.Label dateSortieTexte;
        private System.Windows.Forms.Label GenreTexte;
        private System.Windows.Forms.Label titreTexte;
        private System.Windows.Forms.Button ajoutListe;
        private System.Windows.Forms.Button adminButton;
    }
}


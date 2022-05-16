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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(21, 16);
            this.profil.Margin = new System.Windows.Forms.Padding(4);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(283, 60);
            this.profil.TabIndex = 0;
            this.profil.Text = "Mon profil";
            this.profil.UseVisualStyleBackColor = true;
            this.profil.Visible = false;
            this.profil.Click += new System.EventHandler(this.button1_Click);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(101, 567);
            this.recherche.Margin = new System.Windows.Forms.Padding(4);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(188, 22);
            this.recherche.TabIndex = 12;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 570);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nom série :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(17, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 452);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // maListe
            // 
            this.maListe.Location = new System.Drawing.Point(310, 16);
            this.maListe.Margin = new System.Windows.Forms.Padding(4);
            this.maListe.Name = "maListe";
            this.maListe.Size = new System.Drawing.Size(283, 60);
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
            this.panel1.Location = new System.Drawing.Point(21, 614);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 118);
            this.panel1.TabIndex = 15;
            // 
            // nbEpisodeTexte
            // 
            this.nbEpisodeTexte.AutoSize = true;
            this.nbEpisodeTexte.Location = new System.Drawing.Point(5, 89);
            this.nbEpisodeTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbEpisodeTexte.Name = "nbEpisodeTexte";
            this.nbEpisodeTexte.Size = new System.Drawing.Size(158, 17);
            this.nbEpisodeTexte.TabIndex = 4;
            this.nbEpisodeTexte.Text = "Nombre d\'épisode total:";
            // 
            // nbSaisonTexte
            // 
            this.nbSaisonTexte.AutoSize = true;
            this.nbSaisonTexte.Location = new System.Drawing.Point(5, 68);
            this.nbSaisonTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbSaisonTexte.Name = "nbSaisonTexte";
            this.nbSaisonTexte.Size = new System.Drawing.Size(127, 17);
            this.nbSaisonTexte.TabIndex = 3;
            this.nbSaisonTexte.Text = "Nombre de saison:";
            // 
            // dateSortieTexte
            // 
            this.dateSortieTexte.AutoSize = true;
            this.dateSortieTexte.Location = new System.Drawing.Point(5, 47);
            this.dateSortieTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateSortieTexte.Name = "dateSortieTexte";
            this.dateSortieTexte.Size = new System.Drawing.Size(101, 17);
            this.dateSortieTexte.TabIndex = 2;
            this.dateSortieTexte.Text = "Date de sortie:";
            // 
            // GenreTexte
            // 
            this.GenreTexte.AutoSize = true;
            this.GenreTexte.Location = new System.Drawing.Point(5, 26);
            this.GenreTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreTexte.Name = "GenreTexte";
            this.GenreTexte.Size = new System.Drawing.Size(52, 17);
            this.GenreTexte.TabIndex = 1;
            this.GenreTexte.Text = "Genre:";
            // 
            // titreTexte
            // 
            this.titreTexte.AutoSize = true;
            this.titreTexte.Location = new System.Drawing.Point(5, 5);
            this.titreTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titreTexte.Name = "titreTexte";
            this.titreTexte.Size = new System.Drawing.Size(41, 17);
            this.titreTexte.TabIndex = 0;
            this.titreTexte.Text = "Titre:";
            // 
            // ajoutListe
            // 
            this.ajoutListe.Location = new System.Drawing.Point(464, 565);
            this.ajoutListe.Margin = new System.Windows.Forms.Padding(4);
            this.ajoutListe.Name = "ajoutListe";
            this.ajoutListe.Size = new System.Drawing.Size(129, 28);
            this.ajoutListe.TabIndex = 16;
            this.ajoutListe.Text = "Ajouter à ma liste";
            this.ajoutListe.UseVisualStyleBackColor = true;
            this.ajoutListe.Visible = false;
            this.ajoutListe.Click += new System.EventHandler(this.ajoutListe_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 745);
            this.Controls.Add(this.ajoutListe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maListe);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.profil);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}


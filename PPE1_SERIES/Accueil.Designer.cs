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
            this.titreTexte = new System.Windows.Forms.Label();
            this.ajoutListe = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(16, 13);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(212, 49);
            this.profil.TabIndex = 0;
            this.profil.Text = "Mon profil";
            this.profil.UseVisualStyleBackColor = true;
            this.profil.Visible = false;
            this.profil.Click += new System.EventHandler(this.button1_Click);
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
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(13, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 368);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // maListe
            // 
            this.maListe.Location = new System.Drawing.Point(232, 13);
            this.maListe.Name = "maListe";
            this.maListe.Size = new System.Drawing.Size(212, 49);
            this.maListe.TabIndex = 14;
            this.maListe.Text = "Ma Liste";
            this.maListe.UseVisualStyleBackColor = true;
            this.maListe.Visible = false;
            this.maListe.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorMessage);
            this.panel1.Controls.Add(this.nbEpisodeTexte);
            this.panel1.Controls.Add(this.nbSaisonTexte);
            this.panel1.Controls.Add(this.titreTexte);
            this.panel1.Location = new System.Drawing.Point(16, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 78);
            this.panel1.TabIndex = 15;
            // 
            // nbEpisodeTexte
            // 
            this.nbEpisodeTexte.AutoSize = true;
            this.nbEpisodeTexte.Location = new System.Drawing.Point(4, 32);
            this.nbEpisodeTexte.Name = "nbEpisodeTexte";
            this.nbEpisodeTexte.Size = new System.Drawing.Size(118, 13);
            this.nbEpisodeTexte.TabIndex = 4;
            this.nbEpisodeTexte.Text = "Nombre d\'épisode total:";
            // 
            // nbSaisonTexte
            // 
            this.nbSaisonTexte.AutoSize = true;
            this.nbSaisonTexte.Location = new System.Drawing.Point(4, 18);
            this.nbSaisonTexte.Name = "nbSaisonTexte";
            this.nbSaisonTexte.Size = new System.Drawing.Size(95, 13);
            this.nbSaisonTexte.TabIndex = 3;
            this.nbSaisonTexte.Text = "Nombre de saison:";
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
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(7, 62);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 5;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 577);
            this.Controls.Add(this.ajoutListe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maListe);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button maListe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nbEpisodeTexte;
        private System.Windows.Forms.Label nbSaisonTexte;
        private System.Windows.Forms.Label titreTexte;
        private System.Windows.Forms.Button ajoutListe;
        private System.Windows.Forms.Label errorMessage;
    }
}


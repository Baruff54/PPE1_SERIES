namespace PPE1_SERIES
{
    partial class maListe
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
            this.labelSaisonArretee = new System.Windows.Forms.Label();
            this.labelNomSerie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEpisodeArrete = new System.Windows.Forms.Label();
            this.panelInfosSerie = new System.Windows.Forms.Panel();
            this.btValider = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lesSeries = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSaison = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lesSaisons = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new System.Data.DataSet();
            this.lesEpisodes = new System.Windows.Forms.ListBox();
            this.panelCommentaires = new System.Windows.Forms.Panel();
            this.note = new System.Windows.Forms.NumericUpDown();
            this.comm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noteMoy = new System.Windows.Forms.Label();
            this.amis = new System.Windows.Forms.Button();
            this.panelInfosSerie.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSaison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelCommentaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.note)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSaisonArretee
            // 
            this.labelSaisonArretee.AutoSize = true;
            this.labelSaisonArretee.Location = new System.Drawing.Point(56, 100);
            this.labelSaisonArretee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaisonArretee.Name = "labelSaisonArretee";
            this.labelSaisonArretee.Size = new System.Drawing.Size(80, 17);
            this.labelSaisonArretee.TabIndex = 1;
            this.labelSaisonArretee.Text = "Ma saison :";
            // 
            // labelNomSerie
            // 
            this.labelNomSerie.AutoSize = true;
            this.labelNomSerie.Location = new System.Drawing.Point(56, 30);
            this.labelNomSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomSerie.Name = "labelNomSerie";
            this.labelNomSerie.Size = new System.Drawing.Size(117, 17);
            this.labelNomSerie.TabIndex = 2;
            this.labelNomSerie.Text = "Nom de la Série :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 3;
            // 
            // labelEpisodeArrete
            // 
            this.labelEpisodeArrete.AutoSize = true;
            this.labelEpisodeArrete.Location = new System.Drawing.Point(56, 165);
            this.labelEpisodeArrete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEpisodeArrete.Name = "labelEpisodeArrete";
            this.labelEpisodeArrete.Size = new System.Drawing.Size(97, 17);
            this.labelEpisodeArrete.TabIndex = 4;
            this.labelEpisodeArrete.Text = "Mon épisode :";
            // 
            // panelInfosSerie
            // 
            this.panelInfosSerie.Controls.Add(this.amis);
            this.panelInfosSerie.Controls.Add(this.labelNomSerie);
            this.panelInfosSerie.Controls.Add(this.labelEpisodeArrete);
            this.panelInfosSerie.Controls.Add(this.labelSaisonArretee);
            this.panelInfosSerie.Controls.Add(this.label3);
            this.panelInfosSerie.Location = new System.Drawing.Point(32, 185);
            this.panelInfosSerie.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfosSerie.Name = "panelInfosSerie";
            this.panelInfosSerie.Size = new System.Drawing.Size(357, 220);
            this.panelInfosSerie.TabIndex = 5;
            this.panelInfosSerie.Visible = false;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(54, 157);
            this.btValider.Margin = new System.Windows.Forms.Padding(4);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(173, 53);
            this.btValider.TabIndex = 6;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1003, 59);
            this.button3.TabIndex = 10;
            this.button3.Text = "Accueil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lesSeries
            // 
            this.lesSeries.FormattingEnabled = true;
            this.lesSeries.Location = new System.Drawing.Point(182, 9);
            this.lesSeries.Name = "lesSeries";
            this.lesSeries.Size = new System.Drawing.Size(172, 24);
            this.lesSeries.TabIndex = 11;
            this.lesSeries.SelectedIndexChanged += new System.EventHandler(this.lesSeries_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lesSeries);
            this.panel2.Location = new System.Drawing.Point(32, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 40);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Veuillez choisir une série :";
            // 
            // panelSaison
            // 
            this.panelSaison.Controls.Add(this.label6);
            this.panelSaison.Controls.Add(this.lesSaisons);
            this.panelSaison.Location = new System.Drawing.Point(32, 138);
            this.panelSaison.Name = "panelSaison";
            this.panelSaison.Size = new System.Drawing.Size(357, 40);
            this.panelSaison.TabIndex = 13;
            this.panelSaison.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Veuillez choisir une saison :";
            // 
            // lesSaisons
            // 
            this.lesSaisons.FormattingEnabled = true;
            this.lesSaisons.Location = new System.Drawing.Point(182, 9);
            this.lesSaisons.Name = "lesSaisons";
            this.lesSaisons.Size = new System.Drawing.Size(172, 24);
            this.lesSaisons.TabIndex = 11;
            this.lesSaisons.SelectedIndexChanged += new System.EventHandler(this.lesSaisons_SelectedIndexChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // lesEpisodes
            // 
            this.lesEpisodes.FormattingEnabled = true;
            this.lesEpisodes.ItemHeight = 16;
            this.lesEpisodes.Location = new System.Drawing.Point(421, 92);
            this.lesEpisodes.Name = "lesEpisodes";
            this.lesEpisodes.Size = new System.Drawing.Size(255, 308);
            this.lesEpisodes.TabIndex = 14;
            this.lesEpisodes.Visible = false;
            this.lesEpisodes.SelectedIndexChanged += new System.EventHandler(this.lesEpisodes_SelectedIndexChanged);
            // 
            // panelCommentaires
            // 
            this.panelCommentaires.Controls.Add(this.note);
            this.panelCommentaires.Controls.Add(this.comm);
            this.panelCommentaires.Controls.Add(this.label5);
            this.panelCommentaires.Controls.Add(this.label8);
            this.panelCommentaires.Controls.Add(this.label7);
            this.panelCommentaires.Controls.Add(this.noteMoy);
            this.panelCommentaires.Controls.Add(this.btValider);
            this.panelCommentaires.Location = new System.Drawing.Point(682, 142);
            this.panelCommentaires.Name = "panelCommentaires";
            this.panelCommentaires.Size = new System.Drawing.Size(291, 225);
            this.panelCommentaires.TabIndex = 15;
            this.panelCommentaires.Visible = false;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(121, 55);
            this.note.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(149, 22);
            this.note.TabIndex = 9;
            // 
            // comm
            // 
            this.comm.Location = new System.Drawing.Point(121, 93);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(149, 22);
            this.comm.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valider pour enregistrer la progression";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Commentaire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Note :";
            // 
            // noteMoy
            // 
            this.noteMoy.AutoSize = true;
            this.noteMoy.Location = new System.Drawing.Point(15, 15);
            this.noteMoy.Name = "noteMoy";
            this.noteMoy.Size = new System.Drawing.Size(112, 17);
            this.noteMoy.TabIndex = 0;
            this.noteMoy.Text = "Note moyenne : ";
            // 
            // amis
            // 
            this.amis.Location = new System.Drawing.Point(59, 194);
            this.amis.Name = "amis";
            this.amis.Size = new System.Drawing.Size(219, 23);
            this.amis.TabIndex = 5;
            this.amis.Text = "Voir les commentaires des amis";
            this.amis.UseVisualStyleBackColor = true;
            this.amis.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // maListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 549);
            this.Controls.Add(this.panelCommentaires);
            this.Controls.Add(this.lesEpisodes);
            this.Controls.Add(this.panelSaison);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelInfosSerie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "maListe";
            this.Text = "Ma liste";
            this.panelInfosSerie.ResumeLayout(false);
            this.panelInfosSerie.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSaison.ResumeLayout(false);
            this.panelSaison.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelCommentaires.ResumeLayout(false);
            this.panelCommentaires.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.note)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSaisonArretee;
        private System.Windows.Forms.Label labelNomSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInfosSerie;
        private System.Windows.Forms.Label labelEpisodeArrete;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox lesSeries;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSaison;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lesSaisons;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ListBox lesEpisodes;
        private System.Windows.Forms.Panel panelCommentaires;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label noteMoy;
        private System.Windows.Forms.NumericUpDown note;
        private System.Windows.Forms.TextBox comm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button amis;
    }
}
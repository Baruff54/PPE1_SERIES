
namespace PPE1_SERIES
{
    partial class CommentairesAmis
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
            this.accueil = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.ami = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lesSaisonsAmis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lesEpisodesAmis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.laNote = new System.Windows.Forms.Label();
            this.leCommentaire = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // accueil
            // 
            this.accueil.Location = new System.Drawing.Point(39, 54);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(966, 38);
            this.accueil.TabIndex = 0;
            this.accueil.Text = "Accueil";
            this.accueil.UseVisualStyleBackColor = true;
            this.accueil.Click += new System.EventHandler(this.accueil_Click);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(39, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(966, 38);
            this.retour.TabIndex = 1;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // ami
            // 
            this.ami.FormattingEnabled = true;
            this.ami.Location = new System.Drawing.Point(143, 3);
            this.ami.Name = "ami";
            this.ami.Size = new System.Drawing.Size(150, 24);
            this.ami.TabIndex = 2;
            this.ami.SelectedIndexChanged += new System.EventHandler(this.ami_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choisissez un ami :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ami);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 33);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lesSaisonsAmis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(353, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 33);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // lesSaisonsAmis
            // 
            this.lesSaisonsAmis.FormattingEnabled = true;
            this.lesSaisonsAmis.Location = new System.Drawing.Point(168, 6);
            this.lesSaisonsAmis.Name = "lesSaisonsAmis";
            this.lesSaisonsAmis.Size = new System.Drawing.Size(150, 24);
            this.lesSaisonsAmis.TabIndex = 6;
            this.lesSaisonsAmis.SelectedIndexChanged += new System.EventHandler(this.lesSaisonsAmis_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choisissez une saison :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lesEpisodesAmis);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(682, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 33);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // lesEpisodesAmis
            // 
            this.lesEpisodesAmis.FormattingEnabled = true;
            this.lesEpisodesAmis.Location = new System.Drawing.Point(168, 6);
            this.lesEpisodesAmis.Name = "lesEpisodesAmis";
            this.lesEpisodesAmis.Size = new System.Drawing.Size(150, 24);
            this.lesEpisodesAmis.TabIndex = 6;
            this.lesEpisodesAmis.SelectedIndexChanged += new System.EventHandler(this.lesEpisodesAmis_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choisissez un épisode :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(264, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Une saison ou un épisode ne s\'affichera uniquement si l\'ami l\'a commenté ou noté." +
    "";
            // 
            // laNote
            // 
            this.laNote.AutoSize = true;
            this.laNote.Location = new System.Drawing.Point(3, 5);
            this.laNote.Name = "laNote";
            this.laNote.Size = new System.Drawing.Size(46, 17);
            this.laNote.TabIndex = 8;
            this.laNote.Text = "Note :";
            // 
            // leCommentaire
            // 
            this.leCommentaire.AutoSize = true;
            this.leCommentaire.Location = new System.Drawing.Point(3, 22);
            this.leCommentaire.Name = "leCommentaire";
            this.leCommentaire.Size = new System.Drawing.Size(99, 17);
            this.leCommentaire.TabIndex = 9;
            this.leCommentaire.Text = "Commentaire :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.leCommentaire);
            this.panel4.Controls.Add(this.laNote);
            this.panel4.Location = new System.Drawing.Point(39, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 41);
            this.panel4.TabIndex = 10;
            this.panel4.Visible = false;
            // 
            // CommentairesAmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 244);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.accueil);
            this.Name = "CommentairesAmis";
            this.Text = "Commentaires des amis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.ComboBox ami;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox lesSaisonsAmis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox lesEpisodesAmis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laNote;
        private System.Windows.Forms.Label leCommentaire;
        private System.Windows.Forms.Panel panel4;
    }
}
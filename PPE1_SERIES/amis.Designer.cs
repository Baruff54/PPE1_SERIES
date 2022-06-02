namespace PPE1_SERIES
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
            this.messageAdd = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.searchFriends = new System.Windows.Forms.TextBox();
            this.ajoute = new System.Windows.Forms.Label();
            this.rechercher = new System.Windows.Forms.Button();
            this.pseudoAmi = new System.Windows.Forms.TextBox();
            this.ami = new System.Windows.Forms.Label();
            this.listeAmi = new System.Windows.Forms.ListBox();
            this.accueil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.messageAdd);
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.searchFriends);
            this.panel1.Controls.Add(this.ajoute);
            this.panel1.Controls.Add(this.rechercher);
            this.panel1.Controls.Add(this.pseudoAmi);
            this.panel1.Controls.Add(this.ami);
            this.panel1.Controls.Add(this.listeAmi);
            this.panel1.Controls.Add(this.accueil);
            this.panel1.Location = new System.Drawing.Point(36, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 379);
            this.panel1.TabIndex = 0;
            // 
            // messageAdd
            // 
            this.messageAdd.AutoSize = true;
            this.messageAdd.Location = new System.Drawing.Point(52, 322);
            this.messageAdd.Name = "messageAdd";
            this.messageAdd.Size = new System.Drawing.Size(0, 13);
            this.messageAdd.TabIndex = 10;
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
            // searchFriends
            // 
            this.searchFriends.Location = new System.Drawing.Point(111, 341);
            this.searchFriends.Name = "searchFriends";
            this.searchFriends.Size = new System.Drawing.Size(100, 20);
            this.searchFriends.TabIndex = 8;
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
            // pseudoAmi
            // 
            this.pseudoAmi.Location = new System.Drawing.Point(111, 70);
            this.pseudoAmi.Name = "pseudoAmi";
            this.pseudoAmi.Size = new System.Drawing.Size(100, 20);
            this.pseudoAmi.TabIndex = 5;
            this.pseudoAmi.TextChanged += new System.EventHandler(this.pseudoAmi_TextChanged);
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
            this.listeAmi.SelectedIndexChanged += new System.EventHandler(this.listeAmi_SelectedIndexChanged);
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
            this.Load += new System.EventHandler(this.amis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.Label ami;
        private System.Windows.Forms.ListBox listeAmi;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label ajoute;
        private System.Windows.Forms.TextBox pseudoAmi;
        private System.Windows.Forms.Label messageAdd;
        private System.Windows.Forms.TextBox searchFriends;
    }
}
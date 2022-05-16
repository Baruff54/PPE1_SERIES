namespace PPE1_SERIES
{
    partial class Inscription
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.mdp2 = new System.Windows.Forms.TextBox();
            this.mdp1 = new System.Windows.Forms.TextBox();
            this.Identifiant = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.mdp2);
            this.panel1.Controls.Add(this.mdp1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Identifiant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 307);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "S\'inscrire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmer le Mot de passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identifiant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Red;
            this.error.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.error.Location = new System.Drawing.Point(22, 255);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(58, 17);
            this.error.TabIndex = 9;
            this.error.Text = "ERROR";
            this.error.Visible = false;
            // 
            // mdp2
            // 
            this.mdp2.BackColor = System.Drawing.SystemColors.Control;
            this.mdp2.Location = new System.Drawing.Point(72, 178);
            this.mdp2.Name = "mdp2";
            this.mdp2.PasswordChar = '•';
            this.mdp2.Size = new System.Drawing.Size(100, 22);
            this.mdp2.TabIndex = 8;
            // 
            // mdp1
            // 
            this.mdp1.BackColor = System.Drawing.SystemColors.Control;
            this.mdp1.Location = new System.Drawing.Point(72, 114);
            this.mdp1.Name = "mdp1";
            this.mdp1.PasswordChar = '•';
            this.mdp1.Size = new System.Drawing.Size(100, 22);
            this.mdp1.TabIndex = 7;
            // 
            // Identifiant
            // 
            this.Identifiant.BackColor = System.Drawing.SystemColors.Control;
            this.Identifiant.Location = new System.Drawing.Point(72, 47);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(100, 22);
            this.Identifiant.TabIndex = 2;
            // 
            // Inscription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(308, 344);
            this.Controls.Add(this.panel1);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox mdp2;
        private System.Windows.Forms.TextBox mdp1;
        private System.Windows.Forms.TextBox Identifiant;
    }
}
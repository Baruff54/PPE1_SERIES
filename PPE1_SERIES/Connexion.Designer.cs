namespace PPE1_SERIES
{
    partial class Connexion
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
            this.error = new System.Windows.Forms.Label();
            this.Inscript = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.mdp = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.Inscript);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Controls.Add(this.mdp);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(80, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 358);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Red;
            this.error.ForeColor = System.Drawing.Color.White;
            this.error.Location = new System.Drawing.Point(25, 231);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(170, 17);
            this.error.TabIndex = 6;
            this.error.Text = "La connexion a échouée !";
            this.error.Visible = false;
            // 
            // Inscript
            // 
            this.Inscript.Location = new System.Drawing.Point(60, 324);
            this.Inscript.Margin = new System.Windows.Forms.Padding(4);
            this.Inscript.Name = "Inscript";
            this.Inscript.Size = new System.Drawing.Size(100, 28);
            this.Inscript.TabIndex = 5;
            this.Inscript.Text = "Inscription";
            this.Inscript.UseVisualStyleBackColor = true;
            this.Inscript.Click += new System.EventHandler(this.Inscript_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(60, 266);
            this.connect.Margin = new System.Windows.Forms.Padding(4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(100, 28);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connexion";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(43, 190);
            this.mdp.Margin = new System.Windows.Forms.Padding(4);
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '•';
            this.mdp.Size = new System.Drawing.Size(132, 22);
            this.mdp.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(43, 91);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(132, 22);
            this.login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant:";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 474);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Inscript;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
    }
}
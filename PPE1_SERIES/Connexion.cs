using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PPE1_SERIES
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        public static string identifiant;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inscript_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription Inscript = new Inscription();
            Inscript.ShowDialog();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string verif = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\login.txt";
            string s = "";
            int access = 0;
            StreamReader fichierEntree = File.OpenText(verif);
            while ((s = fichierEntree.ReadLine()) != null && access == 0)
            {
                string[] split = s.Split(',');
                if (split[0] == login.Text && split[1] == mdp.Text) access = 1;
            }
            fichierEntree.Close();

            if (access == 1)
            {
                identifiant = login.Text;
                this.Hide();
                Accueil accueil= new Accueil();
                accueil.ShowDialog();
            }
            else
            {
                error.Text = "Mot de passe ou identifiant incorrecte.";
                error.Visible = true;
            }
        }
    }
}

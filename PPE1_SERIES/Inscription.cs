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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string verif = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\login.txt";
            string s = "";
            int doublon = 0;
            StreamReader fichierEntree = File.OpenText(verif);
            while ((s = fichierEntree.ReadLine()) != null && doublon == 0)
            {
                string[] split = s.Split(',');
                if (split[0] == Identifiant.Text) doublon = 1;
            }
            fichierEntree.Close();

            if(mdp1.Text == mdp2.Text && mdp1.Text != "" && doublon == 0)
            {
                StreamWriter fichierSortie = File.AppendText(verif);
                fichierSortie.WriteLine(Identifiant.Text + "," + mdp1.Text);
                fichierSortie.WriteLine();
                fichierSortie.Close();
                this.Hide();
                Connexion connect = new Connexion();
                connect.ShowDialog();
            } else if(mdp1.Text != mdp2.Text || mdp1.Text == "")
            {
                error.Text = "Mot de passe différent ou non inscrit!";
                error.Visible = true;
            } else
            {
                error.Text = "Identifiant déjà pris, veuillez en choisir un autre.";
                error.Visible = true;
            }
        }
    }
}

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
    public partial class maListe : Form
    {
        public maListe()
        {
            InitializeComponent();
        }

        private void maListe_Load(object sender, EventArgs e)
        {
            string s = "";
            string fichier = ".\\liste.txt";
            StreamReader serie = File.OpenText(fichier);
            listePerso.Items.Clear();
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if (split[0] == Connexion.identifiant)
                {
                    listePerso.Items.Add(split[1]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Accueil accueil = new Accueil();
            accueil.ShowDialog();*/
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            string fichier = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\liste.txt";
            StreamReader serie = File.OpenText(fichier);
            listePerso.Items.Clear();
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if (split[1].ToUpper().IndexOf(recherche.Text.ToUpper()) != -1 && split[0] == Connexion.identifiant)
                {
                    listePerso.Items.Add(split[1]);
                }
            }
        }
    }
}

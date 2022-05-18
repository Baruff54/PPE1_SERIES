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
using PPE1_SERIES.DAO;

namespace PPE1_SERIES
{
    public partial class Accueil : Form
    {
        
        public Accueil(int idconn)
        {
            InitializeComponent();
        }
        private void Accueil_Load(object sender, EventArgs e)
        {
            SerieDAO sdao = new SerieDAO();
            List<string> lesSeries = new List<string>();
            lesSeries = sdao.SELECT();
            foreach (string uneSerie in lesSeries)
            {
                listBox1.Items.Add(uneSerie);
            }
            profil.Visible = true;
            maListe.Visible = true;
            ajoutListe.Visible = true;

        }
            private void button2_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Connexion connect = new Connexion("");
            connect.ShowDialog();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            amis profil = new amis();
            profil.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            maListe liste = new maListe();
            liste.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string laSerie = listBox1.SelectedItem.ToString();
            int i=0;
            /*string s = "";
            string fichier = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\film.txt";
            StreamReader serie = File.OpenText(fichier);
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if (split[1] == Convert.ToString(listBox1.SelectedItem))
                {
                    titreTexte.Text = "Titre: " + split[1];
                    GenreTexte.Text = "Genre: " + split[2];
                    dateSortieTexte.Text = "Date de sortie: " + split[3];
                    nbSaisonTexte.Text = "Nombre de saison: " + split[4];
                    nbEpisodeTexte.Text = "Nombre d'épisode: " + split[5];
                }
            }*/
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            SerieDAO sdao = new SerieDAO();
            List<String> lesSeries = sdao.SELECT_SEARCH(recherche.Text);
            listBox1.Items.Clear();
            foreach(String uneSerie in lesSeries)
            {
                listBox1.Items.Add(uneSerie);
            }
        }

        private void ajoutListe_Click(object sender, EventArgs e)
        {
            string s = "";
            int nom = -1;
            string ajout = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\liste.txt";
            string film = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\film.txt";

            StreamReader serie = File.OpenText(film);
            while ((s = serie.ReadLine()) != null && nom == -1)
            {
                string[] split = s.Split(',');
                if (split[1] == Convert.ToString(listBox1.SelectedItem)) nom = Convert.ToInt32(split[0]);
            }
            serie.Close();
            if (nom != -1)
            {
                StreamWriter liste = File.AppendText(ajout);
                liste.WriteLine(PPE1_SERIES.Connexion.identifiant + "," + nom + ",0,0");
                liste.Close();
            }
        }
    }
}

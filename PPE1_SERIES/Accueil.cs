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
    public partial class Accueil : Form
    {
        string fichier = ".\\film.txt";
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (PPE1_SERIES.Connexion.identifiant != null)
            {
                profil.Visible = true;
                Connexion.Visible = false;
                maListe.Visible = true;
                ajoutListe.Visible = true;
                if (PPE1_SERIES.Connexion.identifiant == "admin")
                {
                    adminButton.Visible = true;
                }
            }


            string s = "";
            StreamReader serie = File.OpenText(fichier);
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                listBox1.Items.Add(split[1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion connect = new Connexion();
            connect.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            amis profil = new amis();
            profil.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            maListe liste = new maListe();
            liste.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
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
            }
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            string fichier = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\film.txt";
            StreamReader serie = File.OpenText(fichier);
            listBox1.Items.Clear();
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if (split[1].ToUpper().IndexOf(recherche.Text.ToUpper()) != -1)
                {
                    listBox1.Items.Add(split[1]);
                }
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
            if(nom != -1)
            {
                StreamWriter liste = File.AppendText(ajout);
                liste.WriteLine(PPE1_SERIES.Connexion.identifiant + "," + nom + ",0,0");
                liste.Close();
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin Admin = new admin();
            Admin.ShowDialog();
        }
    }
}

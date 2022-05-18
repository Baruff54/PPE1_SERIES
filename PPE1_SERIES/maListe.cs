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
    public partial class maListe : Form
    {
        private int idConnexion;
        public maListe(int idconn)
        {
            InitializeComponent();
            this.idConnexion = idconn;
            SerieDAO sdao = new SerieDAO();
            List<string> lesSeriesData = new List<string>();
            lesSeriesData = sdao.SELECTSELEC(this.idConnexion);
            foreach(string uneSerie in lesSeriesData)
            {
                lesSeries.Items.Add(uneSerie);
            }
        }

        private void chargerLaListe()
        {
            
            /*string s = "";
            string fichier = ".\\liste.txt";
            StreamReader serie = File.OpenText(fichier);
            listePerso.Items.Clear();
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if (Convert.ToInt32(split[0]) == Connexion.identifiant)
                {
                    listePerso.Items.Add(split[1]);
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueil = new Accueil(this.idConnexion);
            accueil.ShowDialog();
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            /*string s = "";
            string fichier = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\liste.txt";
            StreamReader serie = File.OpenText(fichier);
            listePerso.Items.Clear();
            while ((s = serie.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if (split[1].ToUpper().IndexOf(recherche.Text.ToUpper()) != -1 && Convert.ToInt32(split[0]) == Connexion.identifiant)
                {
                    listePerso.Items.Add(split[1]);
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lesSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.ToString() != "")
            {
                panelSaison.Visible = true;
                SaisonDAO sdao = new SaisonDAO();
                List<string> lesSaisonsData = new List<string>();
                lesSaisonsData = sdao.SELECT(lesSeries.SelectedItem.ToString());
                foreach (string uneSaison in lesSaisonsData)
                {
                    lesSaisons.Items.Add(uneSaison);
                }
                panelInfosSerie.Visible = true;
                labelNomSerie.Text ="Nom de la série : "+lesSeries.SelectedItem.ToString();

            }
        }

        private void lesSaisons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.ToString() != "")
            {
                if (lesEpisodes.Items.Count != 0)
                {
                    lesEpisodes.Items.Clear();
                }
                lesEpisodes.Visible = true;
                EpisodeDAO sdao = new EpisodeDAO();
                List<string> lesEpisodesData = new List<string>();
                lesEpisodesData = sdao.SELECT(lesSeries.SelectedItem.ToString(), lesSaisons.SelectedItem.ToString());
                foreach (string unEpisode in lesEpisodesData)
                {
                    lesEpisodes.Items.Add(unEpisode);
                }
            }
        }

        private void lesEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.ToString() != "")
            {
                panelCommentaires.Visible = true;
            }
        }
    }
}

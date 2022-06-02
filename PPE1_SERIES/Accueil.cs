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
        
        public Accueil()
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
            titreTexte.Text = "Titre: " + laSerie;
            SaisonDAO saisonDAO = new SaisonDAO();
            nbSaisonTexte.Text = "Nombre de saison: " + saisonDAO.COUNT_SAISON(laSerie);
            EpisodeDAO episodeDAO = new EpisodeDAO();
            nbEpisodeTexte.Text = "Nombre d'épisode: " + episodeDAO.SELECT_NBEPISODE(laSerie);
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
            errorMessage.Text = "";
            SerieDAO serdao = new SerieDAO();
            int idSerie;
            idSerie = serdao.SELECT_ID(listBox1.SelectedItem.ToString());
            ListeDAO ldao = new ListeDAO();
            try
            {
                ldao.INSERT(Connexion.identifiant, idSerie);
            } catch (Exception ex)
            {
                errorMessage.Text = "Vous avez déjà cette série dans votre liste.";
            }
        }
    }
}

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
       
        public maListe()
        {
            InitializeComponent();
            
            SerieDAO sdao = new SerieDAO();
            List<string> lesSeriesData = new List<string>();
            lesSeriesData = sdao.SELECTSELEC(Connexion.identifiant);
            foreach(string uneSerie in lesSeriesData)
            {
                lesSeries.Items.Add(uneSerie);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueil = new Accueil();
            accueil.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPersonne = Connexion.identifiant;
            int noteVal = Convert.ToInt32(note.Value);
            string commentaire = comm.Text;
            EvaluerDAO edao = new EvaluerDAO();
            string labelSerie = lesSeries.SelectedItem.ToString();
            string labelSaison = lesSaisons.SelectedItem.ToString();
            string labelEpisode = lesEpisodes.SelectedItem.ToString();
            int idSerie=edao.getIdSerie(labelSerie);
            int idEpisode = edao.getIdEpisode(idSerie,Convert.ToInt32(labelSaison),labelEpisode);
            int i = 0;
            edao.INSERT(idPersonne, idEpisode, Convert.ToInt32(labelSaison), idSerie, noteVal, commentaire);

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
                PartagerDAO pdao = new PartagerDAO();
                int saisonCourrante;
                saisonCourrante=pdao.SELECTPROGRESSIONSAISON(Connexion.identifiant, lesSeries.SelectedItem.ToString());
                labelSaisonArretee.Text = "Ma saison : " + saisonCourrante;
                string episodeCourrant;
                episodeCourrant=pdao.SELECTPROGRESSIONEPISODE(Connexion.identifiant, lesSeries.SelectedItem.ToString(),saisonCourrante);
                labelEpisodeArrete.Text = "Mon épisode : " + episodeCourrant;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SerieDAO sdao = new SerieDAO();
            string nomSerie = lesSeries.SelectedItem.ToString();
            int laSerie=sdao.SELECT_ID(lesSeries.SelectedItem.ToString());
            CommentairesAmis commAmis = new CommentairesAmis(laSerie);
            this.Hide();
            commAmis.Show();
        }
    }
}

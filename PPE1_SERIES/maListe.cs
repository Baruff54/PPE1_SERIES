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
            string noteVal = Convert.ToString(note.Value);
            string commentaire = comm.Text;
            EvaluerDAO edao = new EvaluerDAO();
            string labelSerie = lesSeries.SelectedItem.ToString();
            string labelSaison = lesSaisons.SelectedItem.ToString();
            string labelEpisode = lesEpisodes.SelectedItem.ToString();
            List<string> lesId = new List<string>();
            lesId=edao.getIdSerieIdEpisode(Convert.ToInt32(labelSaison), labelSerie, labelEpisode);
            int i = 0;
            //INSERT(int idIdentifiant, int idEpisode, int idSaison, int idSerie, int uneNote, string unCommentaire)
            //edao.INSERT();

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
                List<String> LabelSaisonData = new List<string>();
                LabelSaisonData=pdao.SELECTPROGRESSIONSAISON(Connexion.identifiant, lesSeries.SelectedItem.ToString());
                labelSaisonArretee.Text = "Ma saison : " + LabelSaisonData.ElementAt(0);
                List<string> labelEpisodeData = new List<string>();
                labelEpisodeData=pdao.SELECTPROGRESSIONEPISODE(Connexion.identifiant, lesSeries.SelectedItem.ToString());
                labelEpisodeArrete.Text = "Mon épisode : " + labelEpisodeData.ElementAt(0);
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

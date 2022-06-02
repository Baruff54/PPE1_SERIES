using PPE1_SERIES.Class;
using PPE1_SERIES.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE1_SERIES
{
    public partial class CommentairesAmis : Form
    {
        public CommentairesAmis(int uneSerie)
        {
            InitializeComponent();
            this.chargementListeAmis();
            laSerie = uneSerie;
        }

        public static int laSerie;

        private void chargementListeAmis()
        {
            List<string> lesAmis = new List<string>();
            PartagerDAO partdao = new PartagerDAO();
            lesAmis=partdao.SELECTLESAMIS(Connexion.identifiant);
            foreach(string unAmi in lesAmis)
            {
                ami.Items.Add(unAmi);
            }
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueil = new Accueil();
            accueil.ShowDialog();
        }

        private void ami_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            if (ami.SelectedItem.ToString() != "")
            {
                Identifiant unAmi = new Identifiant(0, ami.SelectedItem.ToString(), false);
                IdentifiantDAO idao = new IdentifiantDAO();
                unAmi.Id = idao.getIdByLogin(ami.SelectedItem.ToString());
                this.chargementDesSaisons(unAmi);
            }
        }

        private void chargementDesSaisons(Identifiant unAmi)
        {
            SaisonDAO saisondao = new SaisonDAO();
            List<string> lesNumSaison = new List<string>();
            lesNumSaison=saisondao.SELECT_NUM_SAISON_AMI(unAmi, laSerie);
            foreach (string uneSaison in lesNumSaison){
                lesSaisonsAmis.Items.Add(uneSaison);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            maListe maListe = new maListe();
            maListe.ShowDialog();
        }

        private void lesSaisonsAmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Serie uneSerieSelect = new Serie(laSerie, "");
            if (lesSaisonsAmis.SelectedItem.ToString() != "")
            {
                Saison laSaisonSelect = new Saison(Convert.ToInt32(lesSaisonsAmis.SelectedItem.ToString()), uneSerieSelect);
                Identifiant unAmi = new Identifiant(0, ami.SelectedItem.ToString(), false);
                IdentifiantDAO idao = new IdentifiantDAO();
                unAmi.Id = idao.getIdByLogin(ami.SelectedItem.ToString());//------------------PB AFFICHAGE DEUX EPISODES POUR lolo ALORS QU'IL NE DEVRAIT Y AVOIR QUE BAELOR
                this.chargementDesEpisodes(laSerie, laSaisonSelect, Convert.ToInt32(unAmi.Id));
            }
        }

        private void chargementDesEpisodes(int uneSerie, Saison uneSaison, int unAmi)
        {
            EpisodeDAO episodedao = new EpisodeDAO();
            List<string> lesEpisodes = new List<string>();
            lesEpisodes = episodedao.SELECT_Episodes_Amis(unAmi,uneSerie,uneSaison.Id) ;
            foreach (string unEpisode in lesEpisodes)
            {
                lesEpisodesAmis.Items.Add(unEpisode);
            }
        }

        private void lesEpisodesAmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            Serie uneSerieSelect = new Serie(laSerie, "");
            if (lesSaisonsAmis.SelectedItem.ToString() != "")
            {
                Saison laSaisonSelect = new Saison(Convert.ToInt32(lesSaisonsAmis.SelectedItem.ToString()), uneSerieSelect);
                Identifiant unAmi = new Identifiant(0, ami.SelectedItem.ToString(), false);
                IdentifiantDAO idao = new IdentifiantDAO();
                unAmi.Id = idao.getIdByLogin(ami.SelectedItem.ToString());
                chargementDesLabels(laSerie, laSaisonSelect,unAmi.Id);
            }
        }

        private void chargementDesLabels(int uneSerie, Saison uneSaison, int unAmi)
        {
            EvaluerDAO evaldao = new EvaluerDAO();
            string nomEpisode = lesEpisodesAmis.SelectedItem.ToString();
            EpisodeDAO episodeDAO = new EpisodeDAO();
            int IdEpisode=episodeDAO.SELECT_ID_EPISODE(nomEpisode, uneSerie, uneSaison.Id);
            int laNotetext = evaldao.GETNOTEAMI(uneSerie, uneSaison.Id, IdEpisode, unAmi);
            string leCommentairetext = evaldao.GETCOMMENTAIREAMI(uneSerie, uneSaison.Id, IdEpisode, unAmi);
            laNote.Text = "Note : " + laNotetext;
            leCommentaire.Text = "Commentaire : " + leCommentairetext;
        }
    }
}

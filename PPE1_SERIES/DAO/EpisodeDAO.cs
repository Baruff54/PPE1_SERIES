using PPE1_SERIES.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class EpisodeDAO : DAO
    {
        DAO DAO = new DAO();

        public void INSERT()
        {
            DAO.Conn();
            DAO.CHANGE("");
            DAO.connClose();
        }

        public void UPDATE()
        {
            DAO.Conn();
            DAO.CHANGE("");
            DAO.connClose();
        }
        public void DELETE()
        {
            DAO.Conn();
            DAO.CHANGE("");
            DAO.connClose();
        }
        public List<string> SELECT(string uneSerie, string uneSaison)
        {
            DAO.Conn();
            List<string> lesEpisodes = new List<string>();
            lesEpisodes = DAO.SELECT("SELECT nom FROM `episode` WHERE idSerie =(SELECT id FROM serie WHERE nom='" + uneSerie + "') AND idSaison="+uneSaison+" ORDER BY idEpisode ASC;");
            DAO.connClose();
            return lesEpisodes;
        }

        public String SELECT_NBEPISODE(string uneSerie)
        {
            DAO.Conn();
            List<string> lesEpisodes = new List<string>();
            lesEpisodes = DAO.SELECT("SELECT count(*) FROM `episode` WHERE idSerie =(SELECT id FROM serie WHERE nom='" + uneSerie + "')");
            DAO.connClose();
            return lesEpisodes[0];
        }

        public List<string> SELECT_Episodes_Amis(int unAmi, int uneSerie, int uneSaison)
        {
            List<string> lesEpisodes = new List<string>();
            DAO.Conn();
            string requete = "SELECT episode.nom FROM episode WHERE idEpisode " +
                "IN(SELECT idEpisode FROM evaluer WHERE idIdentifiant=" + unAmi + " AND note IS NOT NULL AND commentaire IS NOT NULL) " +
                "AND idSerie =" + uneSerie + " AND idSaison =" + uneSaison;
            lesEpisodes = DAO.SELECT(requete);
            return lesEpisodes;
        }

        public int SELECT_ID_EPISODE(string unEpisode, int uneSerie, int uneSaison)
        {
            DAO.Conn();
            List<string> lesRes = new List<string>();
            string requete = "SELECT episode.idEpisode FROM episode WHERE episode.nom='" + unEpisode + "' AND idSaison="+uneSaison+" AND idSerie="+uneSaison;
            lesRes = DAO.SELECT(requete);
            DAO.connClose();
            return Convert.ToInt32(lesRes[0]);
        }
    }
}

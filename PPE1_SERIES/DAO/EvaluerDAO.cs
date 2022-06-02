using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class EvaluerDAO : DAO
    {
        DAO DAO = new DAO();

        public void INSERT(int idIdentifiant, int idEpisode, int idSaison, int idSerie, int uneNote, string unCommentaire)
        {
            DAO.Conn();
            DAO.CHANGE("INSERT INTO evaluer VALUES("+idIdentifiant+","+idEpisode+","+idSaison+","+idSerie+","+uneNote+",'"+unCommentaire+"')");
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
        public void SELECT()
        {
            DAO.Conn();
            DAO.SELECT("");
            DAO.connClose();
        }

        public int getIdSerie(string serie)
        {
            List<string> idSaison = new List<string>();
            DAO.Conn();
            string requete = "SELECT id FROM serie WHERE serie.nom='" + serie + "'";
            idSaison=DAO.SELECT(requete);
            DAO.connClose();
            return Convert.ToInt32(idSaison[0]);
        }

        public int getIdEpisode(int idSerie, int numSaison, string nomEpisode)
        {
            List<string> idEpisode = new List<string>();
            DAO.Conn();
            string requete = "SELECT idEpisode FROM episode WHERE episode.nom='" + nomEpisode + "' AND idSaison=" + numSaison +" AND idSerie=" + idSerie;
            idEpisode = DAO.SELECT(requete);
            DAO.connClose();
            return Convert.ToInt32(idEpisode[0]);
        }

        public string GETCOMMENTAIREAMI(int idSerie, int numSaison, int idEpisode, int unAmi)
        {
            List<string> res = new List<string>();
            DAO.Conn();
            string requete = "SELECT commentaire FROM evaluer WHERE idIdentifiant = "+unAmi+" AND idEpisode ="+ idEpisode +" AND idSaison="+numSaison+" AND " +
                "idSerie=" +idSerie;
            res = DAO.SELECT(requete);
            DAO.connClose();
            return res[0];
        }
        public int GETNOTEAMI(int idSerie, int numSaison, int idEpisode, int unAmi)
        {
            List<string> res = new List<string>();
            DAO.Conn();
            string requete = "SELECT note FROM evaluer WHERE idIdentifiant = " + unAmi + " AND idEpisode =" + idEpisode + " AND idSaison=" + numSaison + " AND " +
                "idSerie=" + idSerie;
            res = DAO.SELECT(requete);
            DAO.connClose();
            return Convert.ToInt32(res[0]);
        }
    }
}

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class PartagerDAO : DAO
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
        public void SELECT()
        {
            DAO.Conn();
            DAO.SELECT("");
            DAO.connClose();
        }
        public int SELECTPROGRESSIONSAISON(int unUser, string uneSerie)
        {
            DAO.Conn();
            List<string> progression = new List<string>();
            progression = DAO.SELECT("SELECT MAX(evaluer.idSaison) FROM evaluer WHERE evaluer.idIdentifiant="+unUser+" AND" +
                " evaluer.idSerie=(SELECT serie.id FROM serie WHERE serie.nom='"+uneSerie+"')");
            DAO.connClose();
            return Convert.ToInt32(progression[0]);
        }
        public string SELECTPROGRESSIONEPISODE(int unUser, string uneSerie, int uneSaison)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT episode.nom FROM episode WHERE episode.idEpisode = "+
            "(SELECT MAX(evaluer.idEpisode) FROM evaluer WHERE "+
            "evaluer.idSerie = (SELECT serie.id FROM serie WHERE serie.nom = '"+uneSerie+"')"+
            "AND evaluer.idIdentifiant = "+unUser+" AND evaluer.idSaison = "+uneSaison+")"+
            "AND idSaison = "+uneSaison+ " AND idSerie = (SELECT serie.id FROM serie WHERE serie.nom='"+uneSerie+"')");
            DAO.connClose();
            return progression[0];
        }
    }
}

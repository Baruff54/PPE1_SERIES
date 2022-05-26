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
        public List<string> SELECTPROGRESSIONSAISON(int unUser, string uneSerie)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT max(saison.numSaison)FROM saison INNER JOIN serie ON saison.idSerie = serie.id" +
                " INNER JOIN evaluer ON evaluer.idSerie=serie.id WHERE evaluer.idIdentifiant" +
                " = "+unUser+" AND evaluer.idSerie=(SELECT id FROM serie WHERE nom='"+uneSerie +"')");
            DAO.connClose();
            return progression;
        }
        public List<string> SELECTPROGRESSIONEPISODE(int unUser, string uneSerie)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT max(episode.nom)FROM episode INNER JOIN serie ON episode.idEpisode = serie.id" +
                " INNER JOIN evaluer ON evaluer.idSerie=serie.id WHERE evaluer.idIdentifiant" +
                " = " + unUser + " AND evaluer.idSerie=(SELECT id FROM serie WHERE nom='" + uneSerie + "')");
            DAO.connClose();
            return progression;
        }
    }
}

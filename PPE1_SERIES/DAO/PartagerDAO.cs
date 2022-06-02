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
        public bool CHECK_ISFRIEND(int unUser)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT * FROM `partager` WHERE idAmi = '" + unUser + "'");
            DAO.connClose();

            if(progression.Count > 0)
                return true;
            else
                return false;
        }
        public bool CHECK_ASKEDFRIEND(int unUser)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT * FROM `partager` WHERE idIdentifiant = '"+unUser+"' && idAmi = '"+Connexion.identifiant+"' && demande = 1;");
            DAO.connClose();

            if (progression.Count > 0)
            {
                DAO.CHANGE("INSERT INTO `partager`(`idIdentifiant`, `idAmi`, `demande`) VALUES ('"+Connexion.identifiant+"','"+unUser+"','0');");
                DAO.CHANGE("UPDATE `partager` SET `demande`= 0 WHERE idIdentifiant = '" + unUser + "' && idAmi = '" + Connexion.identifiant + "'");
                return true;
            }
            else
                return false;
        }
        public void SEND_FRIENDS(int user)
        {
            DAO.CHANGE("INSERT INTO `partager`(`idIdentifiant`, `idAmi`, `demande`) VALUES ('" + Connexion.identifiant + "','" + user + "','1');");
        }
        public int SELECTPROGRESSIONSAISON(int unUser, string uneSerie)
        {
            DAO.Conn();
            List<string> progression = new List<string>();
            progression = DAO.SELECT("SELECT MAX(evaluer.idSaison) FROM evaluer WHERE evaluer.idIdentifiant=" + unUser + " AND" +
                " evaluer.idSerie=(SELECT serie.id FROM serie WHERE serie.nom='" + uneSerie + "')");
            DAO.connClose();
            try
            {
                return Convert.ToInt32(progression[0]);
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
        public string SELECTPROGRESSIONEPISODE(int unUser, string uneSerie, int uneSaison)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT episode.nom FROM episode WHERE episode.idEpisode = " +
            "(SELECT MAX(evaluer.idEpisode) FROM evaluer WHERE " +
            "evaluer.idSerie = (SELECT serie.id FROM serie WHERE serie.nom = '" + uneSerie + "')" +
            "AND evaluer.idIdentifiant = " + unUser + " AND evaluer.idSaison = " + uneSaison + ")" +
            "AND idSaison = " + uneSaison + " AND idSerie = (SELECT serie.id FROM serie WHERE serie.nom='" + uneSerie + "')");
            DAO.connClose();
            try
            {
                return progression[0];
            }
            catch (Exception)
            {
                return "Vous n'avez pas encore\nenregistré une progression";
            }
        }
        public List<string> SELECTLESAMIS(int unUser)
        {
            List<string> lesAmis = new List<string>();
            DAO.Conn();
            lesAmis = DAO.SELECT("SELECT identifiant.login FROM identifiant WHERE identifiant.id IN (SELECT idAmi FROM partager WHERE idIdentifiant ="+
                unUser+" AND demande=0)");
            DAO.connClose();
            return lesAmis;
        }
    }
}

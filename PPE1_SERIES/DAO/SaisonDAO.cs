using PPE1_SERIES.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class SaisonDAO : DAO
    {
        DAO DAO = new DAO();

        public void INSERT(int id)
        {
            DAO.Conn();
            DAO.CHANGE("INSERT INTO `saison`(`id`, `idSerie`) VALUES ('[value-1]','[value-2]')");
            DAO.connClose();
        }

        public void UPDATE(int id)
        {
            DAO.Conn();
            DAO.CHANGE("UPDATE `saison` SET `id`='[value-1]',`idSerie`='[value-2]' WHERE 1");
            DAO.connClose();
        }
        public void DELETE(int serie, int saison)
        {
            DAO.Conn();
            DAO.CHANGE("DELETE FROM `saison` WHERE idSerie = "+serie+" && numSaison = "+saison);
            DAO.connClose();
        }
        public new List<string> SELECT(string nomSerie)
        {
            DAO.Conn();
            List<string> lesSaisons = new List<string>();
            lesSaisons=DAO.SELECT("SELECT numSaison FROM `saison` WHERE idSerie =(SELECT id FROM serie WHERE nom='"+nomSerie+"') ORDER BY numSaison ASC;");
            DAO.connClose();
            return lesSaisons;            
        }

        public String COUNT_SAISON(string nomSerie)
        {
            DAO.Conn();
            List<string> lesSaisons = new List<string>();
            lesSaisons = DAO.SELECT("SELECT numSaison FROM `serie` INNER JOIN saison ON saison.idSerie = serie.id WHERE nom = '" + nomSerie + "' ORDER BY saison.numSaison DESC LIMIT 1;");
            DAO.connClose();
            return lesSaisons[0];
        }

        public List<string> SELECT_NUM_SAISON_AMI(Identifiant unAmi, int unIdSerie)
        {
            DAO.Conn();
            List<string> lesSaisons = new List<string>();
            lesSaisons = DAO.SELECT("SELECT DISTINCT numSaison FROM saison WHERE numSaison IN (SELECT idSaison FROM evaluer WHERE idIdentifiant=" + unAmi.Id + ")");
            DAO.connClose();
            return lesSaisons;
        }
    }
}

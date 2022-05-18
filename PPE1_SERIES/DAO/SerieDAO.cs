using PPE1_SERIES.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class SerieDAO : DAO
    {
        DAO DAO = new DAO();

        public void INSERT(string nom)
        {
            DAO.Conn();
            DAO.CHANGE("INSERT INTO `serie`(`nom`) VALUES ('"+nom+"')");
            DAO.connClose();
        }

        public void UPDATE(int id, string nom)
        {
            DAO.Conn();
            DAO.CHANGE("UPDATE `serie` SET `nom`='"+nom+"' WHERE id="+id);
            DAO.connClose();
        }
        public void DELETE(int serie)
        {
            DAO.Conn();
            DAO.CHANGE("DELETE FROM `serie` WHERE id = "+serie);
            DAO.connClose();
        }
        public List<String> SELECT()
        {
            List<String> lesSeries = new List<String>();
            DAO.Conn();
            lesSeries=DAO.SELECT("SELECT nom FROM `serie`");
            DAO.connClose();
            return lesSeries;
        }
        public List<string> SELECTSELEC(int unUser)
        {
            DAO.Conn();
            List<string> lesSeries = new List<string>();
            lesSeries = DAO.SELECT("SELECT nom FROM serie INNER JOIN listeSuivi ON serie.id = listeSuivi.idSerie WHERE listeSuivi.idPersonne=" + unUser + ";");
            DAO.connClose();
            return lesSeries;
        }

        public List<String> SELECT_SEARCH(string contain)
        {
            List<String> lesSeries = new List<String>();
            DAO.Conn();
            lesSeries = DAO.SELECT("SELECT nom FROM `serie` WHERE nom LIKE '%"+contain+"%'");
            DAO.connClose();
            return lesSeries;
        }
    }
}

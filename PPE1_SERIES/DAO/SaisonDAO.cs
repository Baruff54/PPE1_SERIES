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
        public void SELECT()
        {
            DAO.Conn();
            DAO.SELECT("SELECT * FROM `saison`");
            DAO.connClose();
        }
    }
}

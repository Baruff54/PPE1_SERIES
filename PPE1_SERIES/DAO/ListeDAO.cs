using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class ListeDAO
    {
        DAO DAO = new DAO();

        public void DELETE(int idPers, int idSerie)
        {
            DAO.Conn();
            DAO.CHANGE("DELETE FROM `listeSuivi` WHERE idPersonne = '" + idPers + "' && idSerie = '" + idSerie + "'");
            DAO.connClose();
        }

        public void INSERT(int idPers, int idSerie)
        {
            DAO.Conn();
            DAO.CHANGE("INSERT INTO `listeSuivi`(`idPersonne`, `idSerie`) VALUES ('"+ idPers + "','"+ idSerie + "')");
            DAO.connClose();
        }

        public void SELECT(int idPers)
        {
            DAO.Conn();
            DAO.SELECT("SELECT * FROM `listeSuivi` WHERE idPersonne = '"+idPers+"'");
            DAO.connClose();
        }
    }
}

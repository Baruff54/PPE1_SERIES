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
            DAO.CHANGE("INSERT INTO evaluer VALUES("+idIdentifiant+","+idEpisode+","+idSaison+","+idSerie+","+uneNote+","+unCommentaire+")");
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

        public List<string> getIdSerieIdEpisode(int numSaison, string serie, string episode)
        {
            List<string> lesId = new List<string>();
            DAO.Conn();
            string requete = "CALL recuperationInfosCommentaire('" + serie + "','" + episode + "'," + numSaison + ");";
            DAO.CHANGE(requete);
            lesId=DAO.SELECTPARAM("SELECT @idEpisode,@idSerie");

            DAO.connClose();
            return lesId;
        }
    }
}

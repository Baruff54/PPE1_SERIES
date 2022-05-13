using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class IdentifiantDAO : DAO
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
        public bool SELECT(string login, string mdp)
        {
            List<String> resultatConn = new List<String>();
            DAO.Conn();
            string requete = "SELECT COUNT(id) FROM identifiant WHERE login ='" + login + "' AND mdp='" + mdp + "';";
            resultatConn = DAO.SELECT(requete);
            bool resultat = false;
            if (resultatConn.Contains("1"))
            {
                resultat = true;   
            }
            DAO.connClose();
            return resultat;
        }

        public string HasherSalerMDP(string mdp)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes("*//" + mdp + "**/"));

                // Convert byte array to a string   
                StringBuilder mdpHasher = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    mdpHasher.Append(bytes[i].ToString("x2"));
                }
                return mdpHasher.ToString();
            }
        }

        public int getId(string login, string mdp)
        {
            List<String> resultatId = new List<String>();
            DAO.Conn();
            string requete = "SELECT id FROM identifiant WHERE login ='" + login + "' AND mdp='" + mdp + "';";
            resultatId = DAO.SELECT(requete);
            string resultat;
            if (resultatId.Count()>0)
            {
                try
                {
                    int id = Convert.ToInt32(resultatId[0]);
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
            DAO.connClose();
            
            return Convert.ToInt32(resultatId[0]);
        }
    }
}

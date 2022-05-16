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

        public void INSERT(string unLogin, string unMdp)
        {
            DAO.Conn();
            DAO.CHANGE("INSERT INTO identifiant VALUES(null,'"+unLogin+"','"+unMdp+"');");
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
        public int SELECT(string login, string mdp)
        {
            List<String> resultatId = new List<String>();
            DAO.Conn();
            string requete = "SELECT id FROM identifiant WHERE login ='" + login + "' AND mdp='" + mdp + "';";
            resultatId = DAO.SELECT(requete);
            int id=0;
            if (resultatId.Count() > 0)
            {
                try
                {
                    id = Convert.ToInt32(resultatId[0]);
                }
                catch (Exception e)
                {
                    id = 0;
                }
            }
            DAO.connClose();
            return id;
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
    }
}

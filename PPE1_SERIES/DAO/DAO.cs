using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector.Authentication;
using MySqlConnector.Logging;
using MySql.Data.MySqlClient;

namespace PPE1_SERIES.DAO
{
    internal class DAO
    {
        MySqlConnection connexion = new MySqlConnection("server=baruff.fr;database=ppeSerie;user=ppeSerie;password=ppeSerie");
        public void Conn()
        {
            connexion.Open();
        }
        public List<String> SELECT(string requete)
        {
            List<string> resultat = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = requete;
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                resultat.Add(reader[i].ToString());
                i++;
            }
            return resultat;
        }
        public void CHANGE(string requete)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = requete;
            cmd.ExecuteNonQuery();
        }
        public void connClose()
        {
            connexion.Close();
        }
    }
}

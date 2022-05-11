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
        public MySqlDataReader SELECT(string requete)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = requete;
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
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

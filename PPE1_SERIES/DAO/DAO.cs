using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector.Authentication;
using MySqlConnector.Logging;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;

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
                resultat.Add(reader[0].ToString());
                i++;
            }
            return resultat;
        }

        public List<int> SELECTPARAM(string requete)
        {
            List<MySqlParameter> param = new List<MySqlParameter>()
            {
                new MySqlParameter{ParameterName="@idEpisode", MySqlDbType=MySql.Data.MySqlClient.MySqlDbType.Int32},
                //new MySqlParameter{ParameterName="@idSerie", MySqlDbType=MySql.Data.MySqlClient.MySqlDbType.Int32},
            };
            List<int> resultat = new List<int>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connexion;
            cmd.CommandText = requete;
            cmd.Parameters.AddRange(param.ToArray());
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                resultat.Add(Convert.ToInt32(reader[0]));
                Debug.WriteLine(reader);
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

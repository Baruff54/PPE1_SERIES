﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.DAO
{
    internal class PartagerDAO : DAO
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
        public void SELECT()
        {
            DAO.Conn();
            DAO.SELECT("");
            DAO.connClose();
        }
        public bool CHECK_ISFRIEND(string unUser)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT count(*) FROM `partager` INNER JOIN identifiant ON identifiant.id = partager.idAmi WHERE identifiant.login = '" + unUser + "'");
            DAO.connClose();

            if(progression.Count > 0)
                return true;
            else
                return false;
        }
        public bool CHECK_ASKEDFRIEND(string unUser)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT * FROM `partager` INNER JOIN identifiant ON identifiant.id = partager.idIdentifiant WHERE identifiant.login = '"+unUser+"' && idAmi = '"+Connexion.identifiant+"' && demande = 1;");
            DAO.connClose();

            if (progression.Count > 0)
            {
                DAO.CHANGE("");
                return true;
            }
            else
                return false;
        }
        public int SELECTPROGRESSIONSAISON(int unUser, string uneSerie)
        {
            DAO.Conn();
            List<string> progression = new List<string>();
            progression = DAO.SELECT("SELECT MAX(evaluer.idSaison) FROM evaluer WHERE evaluer.idIdentifiant=" + unUser + " AND" +
                " evaluer.idSerie=(SELECT serie.id FROM serie WHERE serie.nom='" + uneSerie + "')");
            DAO.connClose();
            return Convert.ToInt32(progression[0]);
        }
        public string SELECTPROGRESSIONEPISODE(int unUser, string uneSerie, int uneSaison)
        {
            List<String> progression = new List<String>();
            DAO.Conn();
            progression = DAO.SELECT("SELECT episode.nom FROM episode WHERE episode.idEpisode = " +
            "(SELECT MAX(evaluer.idEpisode) FROM evaluer WHERE " +
            "evaluer.idSerie = (SELECT serie.id FROM serie WHERE serie.nom = '" + uneSerie + "')" +
            "AND evaluer.idIdentifiant = " + unUser + " AND evaluer.idSaison = " + uneSaison + ")" +
            "AND idSaison = " + uneSaison + " AND idSerie = (SELECT serie.id FROM serie WHERE serie.nom='" + uneSerie + "')");
            DAO.connClose();
            return progression[0];
        }
        public List<string> SELECTLESAMIS(int unUser)
        {
            List<string> lesAmis = new List<string>();
            DAO.Conn();
            lesAmis = DAO.SELECT("SELECT identifiant.login FROM identifiant WHERE identifiant.id IN (SELECT idAmi FROM partager WHERE idIdentifiant ="+
                unUser+" AND demande=0)");
            DAO.connClose();
            return lesAmis;
        }
    }
}

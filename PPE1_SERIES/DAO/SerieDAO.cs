﻿using System;
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
        public void SELECT()
        {
            DAO.Conn();
            DAO.SELECT("SELECT * FROM `serie`");
            DAO.connClose();
        }
    }
}
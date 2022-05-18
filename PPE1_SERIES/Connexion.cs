using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PPE1_SERIES.DAO;
using MySql.Data.MySqlClient;

namespace PPE1_SERIES
{
    public partial class Connexion : Form
    {
        public Connexion(string inscription)
        {
            InitializeComponent();
            if(inscription != null)
            {
                error.Text = "Inscription réussie!";
                error.BackColor=Color.DarkGreen;
                error.Visible = true;
            }
        }

        public static int identifiant;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inscript_Click(object sender, EventArgs e)
        {
            Inscription Inscript = new Inscription();
            //this.Close();
            Inscript.Show();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            IdentifiantDAO idao = new IdentifiantDAO();
            string mdphashersaler = idao.HasherSalerMDP(mdp.Text);
            int conn = idao.SELECT(login.Text, mdphashersaler);
            if (conn != 0)
            {
                identifiant = idao.SELECT(login.Text, mdphashersaler);
                Accueil a = new Accueil();
                //this.Close();
                a.Show();
            }
            else
            {
                login.Text = "";
                mdp.Text = "";
                error.Visible = true;
            }

        }
    }
}

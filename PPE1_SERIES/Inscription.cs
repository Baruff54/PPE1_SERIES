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

namespace PPE1_SERIES
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mdp1.Text == mdp2.Text)
            {
                IdentifiantDAO idao = new IdentifiantDAO();
                string mdphashersaler = idao.HasherSalerMDP(mdp1.Text);
                try
                {
                    idao.INSERT(Identifiant.Text, mdphashersaler);
                    Connexion c = new Connexion("inscription");
                    this.Close();
                    c.Show();
                }
                catch(Exception)
                {
                    error.Text = "Le nom d\'utilisateur à déjà été utilisé";
                    error.Visible = true;
                }
            }
            else
            {
                error.Text = "Les deux mots de passes sont différents!";
                error.Visible = true;
            }
        }
    }
}

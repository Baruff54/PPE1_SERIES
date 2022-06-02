using PPE1_SERIES.Class;
using PPE1_SERIES.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE1_SERIES
{
    public partial class CommentairesAmis : Form
    {
        public CommentairesAmis(int uneSerie)
        {
            InitializeComponent();
            this.chargementListeAmis();
            laSerie = uneSerie;
        }

        public static int laSerie;
        private void chargementListeAmis()
        {
            List<string> lesAmis = new List<string>();
            PartagerDAO partdao = new PartagerDAO();
            lesAmis=partdao.SELECTLESAMIS(Connexion.identifiant);
            foreach(string unAmi in lesAmis)
            {
                ami.Items.Add(unAmi);
            }
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueil = new Accueil();
            accueil.ShowDialog();
        }

        private void ami_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Identifiant unAmi = new Identifiant(0, ami.SelectedItem.ToString(), false);
            IdentifiantDAO idao = new IdentifiantDAO();
            unAmi.Id=idao.getIdByLogin(ami.SelectedItem.ToString());
            this.chargementDesSaisons(unAmi);
        }

        private void chargementDesSaisons(Identifiant unAmi)
        {
            SaisonDAO saisondao = new SaisonDAO();
            List<string> lesNumSaison = new List<string>();
            lesNumSaison=saisondao.SELECT_NUM_SAISON_AMI(unAmi, laSerie);
            foreach (string uneSaison in lesNumSaison){
                lesSaisonsAmis.Items.Add(uneSaison);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            maListe maListe = new maListe();
            maListe.ShowDialog();
        }

        private void lesSaisonsAmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Serie uneSerieSelect = new Serie(laSerie, "");
            //Saison laSaison = new Saison(Convert.ToInt32(lesSaisonsAmis.SelectedItem.ToString(), uneSerieSelect));
        }
    }
}

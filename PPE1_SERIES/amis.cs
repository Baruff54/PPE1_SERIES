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
    public partial class amis : Form
    {
        public amis()
        {
            InitializeComponent();
        }

        private void amis_Load(object sender, EventArgs e)
        {
            PartagerDAO partagerDAO = new PartagerDAO();
            List<string> lesAmis = new List<string>();
            lesAmis = partagerDAO.SELECT_FRIENDS();
            IdentifiantDAO identifiantDAO = new IdentifiantDAO();
            foreach (string unAmi in lesAmis)
            {
                listeAmi.Items.Add(identifiantDAO.getLoginById(Convert.ToInt16(unAmi)));
            }
        }

        private void modif_Click(object sender, EventArgs e)
        {

        }

        private void accueil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Accueil connect = new Accueil();
            connect.ShowDialog();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            PartagerDAO partagerDAO = new PartagerDAO();
            IdentifiantDAO idDAO = new IdentifiantDAO();

            int idFriends = idDAO.getIdByLogin(searchFriends.Text);

            if(idFriends == -1)
            {
                messageAdd.Text = "Cette identifiant n'éxiste pas.";
                return;
            }

            if (partagerDAO.CHECK_ISFRIEND(idFriends))
            {
                messageAdd.Text = "Vous avez déjà demandé en ami cette personne.";
                return;
            }

            if(partagerDAO.CHECK_ASKEDFRIEND(idFriends))
            {
                messageAdd.Text = "Cette utilisateur vous avez déjà envoyer une requête, vous êtes maintenant ami :D";
                return;
            }

            partagerDAO.SEND_FRIENDS(idFriends);

            messageAdd.Text = "Votre demande a été effectué avec succès.";
        }

        private void listeAmi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pseudoAmi_TextChanged(object sender, EventArgs e)
        {
            PartagerDAO partagerDAO = new PartagerDAO();
            List<String> lesAmi = partagerDAO.SELECT_SEARCH(pseudoAmi.Text);
            listeAmi.Items.Clear();
            foreach (String uneSerie in lesAmi)
            {
                listeAmi.Items.Add(uneSerie);
            }
        }
    }
}

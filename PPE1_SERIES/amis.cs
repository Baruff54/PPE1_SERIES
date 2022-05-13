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

namespace PPE1_SERIES
{
    public partial class amis : Form
    {

        private static string fichierAmi = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\ami.txt";
        private static string verif = "C:\\Users\\loris\\source\\repos\\PPE1_SERIES\\PPE1_SERIES\\login.txt";
        public amis()
        {
            InitializeComponent();

            string s = "";
            StreamReader amis = File.OpenText(fichierAmi);
            while ((s = amis.ReadLine()) != null)
            {
                string[] split = s.Split(',');
                if(split[0] == Connexion.identifiant) listeAmi.Items.Add(split[1]);
            }
            amis.Close();
        }

        private void modif_Click(object sender, EventArgs e)
        {

        }

        private void accueil_Click_1(object sender, EventArgs e)
        {
            /*this.Hide();
            Accueil connect = new Accueil();
            connect.ShowDialog();*/
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string s = "", d = "";
            int verifAmis = -1;
            StreamReader fichierEntree = File.OpenText(verif);
            while ((s = fichierEntree.ReadLine()) != null && verifAmis == -1)
            {
                string[] split = s.Split(',');

                if (split[0] == tb_2.Text)
                {
                    StreamReader listeAmis = File.OpenText(fichierAmi);
                    while ((d = listeAmis.ReadLine()) != null && verifAmis == -1)
                    {
                        split = d.Split(',');
                        if (split[0] == Connexion.identifiant && split[1] == tb_2.Text) verifAmis++;
                    }
                    listeAmis.Close();
                    if (verifAmis == -1)
                    {
                        StreamWriter fichierSortie = File.AppendText(fichierAmi);
                        fichierSortie.WriteLine(Connexion.identifiant + "," + tb_2.Text);
                        fichierSortie.Close();
                        listeAmi.Items.Add(tb_2.Text);
                    }
                    else MessageBox.Show("Vous avez déjà cette amis.");
                }
            }
            fichierEntree.Close();
        }
    }
}

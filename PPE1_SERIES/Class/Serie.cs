using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.Class
{
    class Serie
    {
        private int id;
        private string nom;
        private List<Saison> lesSaisons;
        private List<Episode> lesEpisodes;

        public Serie(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
            this.lesSaisons = new List<Saison>();
            this.lesEpisodes = new List<Episode>();
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public void ajouterUnEpisode(Episode unEpisode)
        {
            this.lesEpisodes.Add(unEpisode);
        }

        public void ajouterUneSaison(Saison uneSaison)
        {
            this.lesSaisons.Add(uneSaison);
        }
    }
}

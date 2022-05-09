using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.Class
{
    class Episode
    {
        private int id;
        private Saison laSaison;
        private Serie laSerie;
        private string nom;
        private double time;

        public Episode(int id, Saison laSaison, Serie laSerie, string nom, double time)
        {
            this.id = id;
            this.laSaison = laSaison;
            this.laSerie = laSerie;
            this.nom = nom;
            this.time = time;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public double Time { get => time; set => time = value; }
        internal Saison LaSaison { get => laSaison; set => laSaison = value; }
        internal Serie LaSerie { get => laSerie; set => laSerie = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.Class
{
    class Evaluer
    {
        private Identifiant idIdentifiant;
        private Episode idEpisode;

        public Evaluer(Identifiant idIdentifiant, Episode idEpisode)
        {
            this.idIdentifiant = idIdentifiant;
            this.idEpisode = idEpisode;
        }

        public Identifiant IdIdentifiant { get => idIdentifiant; set => idIdentifiant = value; }
        public Episode IdEpisode { get => idEpisode; set => idEpisode = value; }
    }
}

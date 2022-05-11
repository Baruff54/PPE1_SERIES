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
        private String commentaire;
        private int note;

        public Evaluer(Identifiant idIdentifiant, Episode idEpisode, string commentaire, int note)
        {
            this.idIdentifiant = idIdentifiant;
            this.idEpisode = idEpisode;
            this.commentaire = commentaire;
            this.note = note;
        }

        public Identifiant IdIdentifiant { get => idIdentifiant; set => idIdentifiant = value; }
        public Episode IdEpisode { get => idEpisode; set => idEpisode = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public int Note { get => note; set => note = value; }
    }
}

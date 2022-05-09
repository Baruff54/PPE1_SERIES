using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.Class
{
    class Partager
    {
        private Identifiant idIdentifiant;
        private Identifiant idAmi;
        private bool demande;

        public Partager(Identifiant idIdentifiant, Identifiant idAmi, bool demande)
        {
            this.idIdentifiant = idIdentifiant;
            this.idAmi = idAmi;
            this.demande = demande;
        }
    }
}

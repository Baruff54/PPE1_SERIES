using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.Class
{
    class Saison
    {
        private int id;
        private Serie laSerie;

        public Saison(int id, Serie laSerie)
        {
            this.id = id;
            this.laSerie = laSerie;
        }

        public int Id { get => id; set => id = value; }
        internal Serie LaSerie { get => laSerie; set => laSerie = value; }
    }
}

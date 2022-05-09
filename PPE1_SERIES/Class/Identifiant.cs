using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE1_SERIES.Class
{
    class Identifiant
    {
        private int id;
        private string login;
        private string mdp;

        public Identifiant(int id, string login, string mdp)
        {
            this.id = id;
            this.login = login;
            this.mdp = mdp;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}

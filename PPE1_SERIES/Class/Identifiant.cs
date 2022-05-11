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
        private bool connecter; // True si la connexion à été établie

        public Identifiant(int id, string login, bool connecter)
        {
            this.id = id;
            this.login = login;
            this.connecter = connecter;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public bool Connecter { get => connecter; set => connecter = value; }
    }
}

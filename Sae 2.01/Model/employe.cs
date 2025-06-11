using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    public class employe
    {
        private string nom;
        private string prenom;
        private string mdp;
        private string login;
        private string numrole;

        public employe()
        {
        }

        public employe(string nom, string prenom, string mdp, string login)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mdp = mdp;
            this.Login = login;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value;
            }
        }

        public string Mdp
        {
            get
            {
                return this.mdp;
            }

            set
            {
                this.mdp = value;
            }
        }

        public string Login
        {
            get
            {
                return this.login;
            }

            set
            {
                this.login = value;
            }
        }

      // public string Nomrole
        //{
         //   get
          //  {
               // return this.nomrole;
         //   }

           // set
         //  {
            //   this.nomrole = value;
           // }
       // }
    }
}

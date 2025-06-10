using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    public class client
    {
        private int numclient;
        private string nomclient;
        private string prenomclient;
        private DateTime datenaissance;
        private string tel;
        private string email;

        public client()
        {
        }

        public client(int numclient, string nomclient, string prenomclient, DateTime datenaissance, string tel, string email)
        {
            this.Numclient = numclient;
            this.Nomclient = nomclient;
            this.Prenomclient = prenomclient;
            this.Datenaissance = datenaissance;
            this.Tel = tel;
            this.Email = email;
        }

        public int Numclient
        {
            get
            {
                return this.numclient;
            }

            set
            {
                this.numclient = value;
            }
        }

        public string Nomclient
        {
            get
            {
                return this.nomclient;
            }

            set
            {
                this.nomclient = value;
            }
        }

        public string Prenomclient
        {
            get
            {
                return this.prenomclient;
            }

            set
            {
                this.prenomclient = value;
            }
        }

        public DateTime Datenaissance
        {
            get
            {
                return this.datenaissance;
            }

            set
            {
                this.datenaissance = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }
    }
}

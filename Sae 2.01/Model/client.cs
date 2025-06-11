using Npgsql;
using Sae_2._01.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
        public List<client> FindAll()
        {
            List<client> lesClients = new List<client>();
            using (NpgsqlCommand cmdSelect = new NpgsqlCommand("select * from client ;"))
            {
                DataTable dt = DataAccess.Instance.ExecuteSelect(cmdSelect);
                foreach (DataRow dr in dt.Rows)
                    lesClients.Add(new client(
                        (Int32)dr["numclient"], 
                        (string)dr["nomclient"],
                        (String)dr["prenomclient"], 
                        DateTime.Parse(dr["datenaissance"].ToString()), 
                        (string)dr["tel"], 
                        (string)dr["email"]));
            }
            return lesClients;
        }
    }
}

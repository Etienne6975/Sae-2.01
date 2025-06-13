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
    public class client : ICrud<client>
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
        public int Create()
        {
            int id = 0;
            using (var cmd = new NpgsqlCommand("INSERT INTO client (nomclient, prenomclient, datenaissance, tel, email) VALUES (@nom, @prenom, @date, @tel, @mail) RETURNING numclient"))
            {
               
                cmd.Parameters.AddWithValue("nom", this.Nomclient);
                cmd.Parameters.AddWithValue("prenom", this.Prenomclient);
                cmd.Parameters.AddWithValue("date", this.Datenaissance);
                cmd.Parameters.AddWithValue("tel", this.Tel);
                cmd.Parameters.AddWithValue("mail", this.Email);
                id = DataAccess.Instance.ExecuteInsert(cmd);
            }
            this.Numclient = id;
            return id;
        }


        public void Read()
        {
            using (var cmdSelect = new NpgsqlCommand("select * from  client  where numclient =@numclient;"))
            {
                cmdSelect.Parameters.AddWithValue("numclient", this.numclient);

                DataTable dt = DataAccess.Instance.ExecuteSelect(cmdSelect);
                this.Numclient = (Int32)dt.Rows[0]["numclient"];
                this.Nomclient = (String)dt.Rows[0]["nomclient"];
                this.Prenomclient = (string)dt.Rows[0]["prenomclient"];
                this.Datenaissance = (DateTime)dt.Rows[0]["datenaissance"];
                this.Tel = (string)dt.Rows[0]["tel"];
                this.Email= (string)dt.Rows[0]["email"];

            }

        }

        public int Update()
        {
            using (var cmd = new NpgsqlCommand("UPDATE client SET nomclient = @nom, prenomclient = @prenom, " +
                                               "datenaissance = @date, tel = @tel, email = @mail WHERE numclient = @id"))
            {
                cmd.Parameters.AddWithValue("nom", this.Nomclient);
                cmd.Parameters.AddWithValue("prenom", this.Prenomclient);
                cmd.Parameters.AddWithValue("date", this.Datenaissance);
                cmd.Parameters.AddWithValue("tel", this.Tel);
                cmd.Parameters.AddWithValue("mail", this.Email);
                cmd.Parameters.AddWithValue("id", this.Numclient);
                return DataAccess.Instance.ExecuteSet(cmd);
            }
        }
        public int Delete()
        {
            using (var cmd = new NpgsqlCommand("DELETE FROM client WHERE numclient = @id"))
            {
                cmd.Parameters.AddWithValue("id", this.Numclient);
                return DataAccess.Instance.ExecuteSet(cmd);
            }
        }
        public List<client> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }


    }
}

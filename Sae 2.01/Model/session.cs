
using Npgsql;
using Sae_2._01.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sae_2._01.Model
{
    public class session : ICrud<session>
    {
        private int numSession;
        private int numDiscipline;
        private int numEmploye;
        private int numPublic;
        private int? numNiveau;
        private int annee;
        private int numSemaine;
        private TimeSpan heureDebut;
        private TimeSpan heureFin;
        private int nbPlaceMaximal;
        private int nbPlaceDisponible;
        private decimal tarif;

        public session()
        {
        }

        public session(int numSession, int numDiscipline, int numPublic, int? numNiveau, int annee, int numSemaine, TimeSpan heureDebut, TimeSpan heureFin, int nbPlaceMaximal, int nbPlaceDisponible, decimal tarif)
        {
            this.NumSession = numSession;
            this.NumDiscipline = numDiscipline;
            this.NumPublic = numPublic;
            this.NumNiveau = numNiveau;
            this.Annee = annee;
            this.NumSemaine = numSemaine;
            this.HeureDebut = heureDebut;
            this.HeureFin = heureFin;
            this.NbPlaceMaximal = nbPlaceMaximal;
            this.NbPlaceDisponible = nbPlaceDisponible;
            this.Tarif = tarif;
        }

        public int NumSession
        {
            get
            {
                return this.numSession;
            }

            set
            {
                this.numSession = value;
            }
        }

        public int NumDiscipline
        {
            get
            {
                return this.numDiscipline;
            }

            set
            {
                this.numDiscipline = value;
            }
        }

        public int NumEmploye
        {
            get
            {
                return this.numEmploye;
            }

            set
            {
                this.numEmploye = value;
            }
        }

        public int NumPublic
        {
            get
            {
                return this.numPublic;
            }

            set
            {
                this.numPublic = value;
            }
        }

        public int? NumNiveau
        {
            get
            {
                return this.numNiveau;
            }

            set
            {
                this.numNiveau = value;
            }
        }

        public int Annee
        {
            get
            {
                return this.annee;
            }

            set
            {
                this.annee = value;
            }
        }

        public int NumSemaine
        {
            get
            {
                return this.numSemaine;
            }

            set
            {
                this.numSemaine = value;
            }
        }

        public TimeSpan HeureDebut
        {
            get
            {
                return this.heureDebut;
            }

            set
            {
                this.heureDebut = value;
            }
        }

        public TimeSpan HeureFin
        {
            get
            {
                return this.heureFin;
            }

            set
            {
                this.heureFin = value;
            }
        }

        public int NbPlaceMaximal
        {
            get
            {
                return this.nbPlaceMaximal;
            }

            set
            {
                this.nbPlaceMaximal = value;
            }
        }

        public int NbPlaceDisponible
        {
            get
            {
                return this.nbPlaceDisponible;
            }

            set
            {
                this.nbPlaceDisponible = value;
            }
        }

        public decimal Tarif
        {
            get
            {
                return this.tarif;
            }

            set
            {
                this.tarif = value;
            }
        }
        public List<session> FindAll()
        {
            List<session> lesSessions = new List<session>();

            using (var cmdSelect = new NpgsqlCommand("SELECT * FROM session;"))
            {
                DataTable dt = DataAccess.Instance.ExecuteSelect(cmdSelect);
                foreach (DataRow dr in dt.Rows)
                {
                    lesSessions.Add(new session(
                        (int)dr["numsession"],
                        (int)dr["numdiscipline"],
                        (int)dr["numpublic"],
                        dr["numniveau"] == DBNull.Value ? null : (int?)dr["numniveau"],
                        (int)dr["annee"],
                        (int)dr["numsemaine"],
                        TimeSpan.Parse(dr["heuredebut"].ToString()),
                        TimeSpan.Parse(dr["heurefin"].ToString()),
                        (int)dr["nbplacemaximal"],
                        (int)dr["nbplacedisponible"],
                        (decimal)dr["tarif"]
                    ));
                }
            }

            return lesSessions;
        }
        public int Create()
        {
            int id = 0;
            using (var cmd = new NpgsqlCommand(@"INSERT INTO session 
            (numdiscipline, numemploye, numpublic, numniveau, annee, numsemaine, heuredebut, heurefin, nbplacemaximal, nbplacedisponible, tarif)
            VALUES (@discipline, @public, @niveau, @annee, @semaine, @debut, @fin, @max, @dispo, @tarif)
            RETURNING numsession"))
            {
                cmd.Parameters.AddWithValue("discipline", this.NumDiscipline);
                cmd.Parameters.AddWithValue("public", this.NumPublic);
                cmd.Parameters.AddWithValue("niveau", (object?)this.NumNiveau ?? DBNull.Value);
                cmd.Parameters.AddWithValue("annee", this.Annee);
                cmd.Parameters.AddWithValue("semaine", this.NumSemaine);
                cmd.Parameters.AddWithValue("debut", this.HeureDebut);
                cmd.Parameters.AddWithValue("fin", this.HeureFin);
                cmd.Parameters.AddWithValue("max", this.NbPlaceMaximal);
                cmd.Parameters.AddWithValue("dispo", this.NbPlaceDisponible);
                cmd.Parameters.AddWithValue("tarif", this.Tarif);

                id = DataAccess.Instance.ExecuteInsert(cmd);
            }

            this.NumSession = id;
            return id;
        }
        public void Read()
        {
            using (var cmd = new NpgsqlCommand("SELECT * FROM session WHERE numsession = @numsession"))
            {
                cmd.Parameters.AddWithValue("numsession", this.NumSession);
                DataTable dt = DataAccess.Instance.ExecuteSelect(cmd);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    this.NumDiscipline = (int)dr["numdiscipline"];
                    this.NumPublic = (int)dr["numpublic"];
                    this.NumNiveau = dr["numniveau"] == DBNull.Value ? null : (int?)dr["numniveau"];
                    this.Annee = (int)dr["annee"];
                    this.NumSemaine = (int)dr["numsemaine"];
                    this.HeureDebut = TimeSpan.Parse(dr["heuredebut"].ToString());
                    this.HeureFin = TimeSpan.Parse(dr["heurefin"].ToString());
                    this.NbPlaceMaximal = (int)dr["nbplacemaximal"];
                    this.NbPlaceDisponible = (int)dr["nbplacedisponible"];
                    this.Tarif = (decimal)dr["tarif"];
                }
            }
        }
        public int Update()
        {
            using (var cmd = new NpgsqlCommand(@"UPDATE session SET numdiscipline = @discipline,numemploye = @employe,numpublic = @public,numniveau = @niveau,annee = @annee,
                numsemaine = @semaine,heuredebut = @debut,heurefin = @fin,nbplacemaximal = @max,nbplacedisponible = @dispo,tarif = @tarif WHERE numsession = @numsession"))
            {
                cmd.Parameters.AddWithValue("discipline", this.NumDiscipline);
                cmd.Parameters.AddWithValue("employe", this.NumEmploye);
                cmd.Parameters.AddWithValue("public", this.NumPublic);
                cmd.Parameters.AddWithValue("niveau", (object?)this.NumNiveau ?? DBNull.Value);
                cmd.Parameters.AddWithValue("annee", this.Annee);
                cmd.Parameters.AddWithValue("semaine", this.NumSemaine);
                cmd.Parameters.AddWithValue("debut", this.HeureDebut);
                cmd.Parameters.AddWithValue("fin", this.HeureFin);
                cmd.Parameters.AddWithValue("max", this.NbPlaceMaximal);
                cmd.Parameters.AddWithValue("dispo", this.NbPlaceDisponible);
                cmd.Parameters.AddWithValue("tarif", this.Tarif);
                cmd.Parameters.AddWithValue("id", this.NumSession);

                return DataAccess.Instance.ExecuteSet(cmd);
            }
        }
        public List<session> FindBySelection(string criteres)
        {
            throw new NotImplementedException();

        }
        public int Delete()
        {
            using (var cmd = new NpgsqlCommand("DELETE FROM session WHERE numsession = @id"))
            {
                cmd.Parameters.AddWithValue("id", this.numSession);
                return DataAccess.Instance.ExecuteSet(cmd);
            }
        }
    }
}
        





    





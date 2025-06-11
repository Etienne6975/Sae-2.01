using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sae_2._01
{

    internal class Inscription
    {
        private int semaine;
        private string Date;
        private string Horaire;
        private string Categorie;
        private int Niveau;

        public int Semaine
        {
            get
            {
                return this.semaine;
            }

            set
            {
                this.semaine = value;
            }
        }

        public string Date1
        {
            get
            {
                return this.Date;
            }

            set
            {
                this.Date = value;
            }
        }

        public string Horaire1
        {
            get
            {
                return this.Horaire;
            }

            set
            {
                this.Horaire = value;
            }
        }

        public string Categorie1
        {
            get
            {
                return this.Categorie;
            }

            set
            {
                this.Categorie = value;
            }
        }

        public int Niveau1
        {
            get
            {
                return this.Niveau;
            }

            set
            {
                this.Niveau = value;
            }
        }
    }
}

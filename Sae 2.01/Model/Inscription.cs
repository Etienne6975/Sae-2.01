using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sae_2._01.Model
{

    internal class Inscription
    {
        public int Semaine { get; set; }
        public string Creneaux { get; set; }
        public string Categorie { get; set; }
        public string Discipline { get; set; }
        public string Public { get; set; }
        public int NombreMax { get; set; }
        public int PlacesRestantes { get; set; }
        
    }
}

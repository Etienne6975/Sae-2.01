using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using table;

namespace Sae_2._01.Model
{
    public class Gestion
    {
        private ObservableCollection<client> lesClients;

        public Gestion()
        {
            this.LesClients = new ObservableCollection<client>(new client().FindAll());
        }

        public ObservableCollection<client> LesClients
        {
            get
            {
                return this.lesClients;
            }

            set
            {
                this.lesClients = value;
            }
        }
    }
}

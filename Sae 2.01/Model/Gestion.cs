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
        private ObservableCollection<session> lesSessions;

        public Gestion()
        {
            this.LesClients = new ObservableCollection<client>(new client().FindAll());
            this.lesSessions = new ObservableCollection<session>(new session().FindAll());
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

        public ObservableCollection<session> LesSessions
        {
            get
            {
                return this.lesSessions;
            }

            set
            {
                this.lesSessions = value;
            }
        }
    }
}

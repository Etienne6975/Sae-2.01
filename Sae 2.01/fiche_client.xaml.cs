using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using table;

namespace Sae_2._01
{
    /// <summary>
    /// Logique d'interaction pour synthese_sessions.xaml
    /// </summary>
    public partial class synthese_sessions : UserControl
    {
        public client Leclient { get; set; }
        public synthese_sessions()
        {
           // ChargeData;
            InitializeComponent();
        }

        public void ChargeData()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème lors de récupération des données,veuillez consulter votre admin");

                Application.Current.Shutdown();
            }
        }
    }
}

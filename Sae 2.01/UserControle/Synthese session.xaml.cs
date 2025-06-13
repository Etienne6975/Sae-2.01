using Sae_2._01.Model;
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
using System.Windows.Shapes;

namespace Sae_2._01
{
    /// <summary>
    /// Logique d'interaction pour DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : UserControl
    {
        private static Gestion laSessions { get; set; }
        public DetailWindow()
        {
            ChargeData();
            InitializeComponent();
        }

        private void ChargeData()
        {
            try
            {
                laSessions = new Gestion();
                this.DataContext = laSessions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème lors de récupération des données, veuillez consulter votre admin");

                Application.Current.Shutdown();
            }
        }
    }
}

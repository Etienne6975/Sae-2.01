using Sae_2._01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using table;

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
            dataGridCours.Items.Filter = RechercheMotClefSessions;
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

        private bool RechercheMotClefSessions(object obj)
        {
            if (String.IsNullOrEmpty(textRechercheSemaine.Text))
                return true;
            session Session = obj as session;
            return (Session.NumSession.ToString().StartsWith(textRechercheSemaine.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void textRechercheSemaine_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dataGridCours.ItemsSource).Refresh();
        }
    }
}

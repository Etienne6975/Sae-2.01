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
using System.Windows.Navigation;
using System.Windows.Shapes;
using table;

namespace Sae_2._01
{
    /// <summary>
    /// Logique d'interaction pour synthese_sessions.xaml
    /// </summary>
    public partial class fiche_client : UserControl
    {
        public static Gestion Lagestion { get; set; }

        public fiche_client()
        {
            ChargeData();
            InitializeComponent();
            dgClient.Items.Filter = RechercheMotClefNomPrenom;

        }
        public void ChargeData()
        {
            try
            {
                Lagestion = new Gestion();
                this.DataContext = Lagestion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème lors de récupération des données, veuillez consulter votre admin");

                Application.Current.Shutdown();
            }
        }
        private bool RechercheMotClefNomPrenom(object obj)
        {
            if (String.IsNullOrEmpty(textRechercheNomPrenom.Text))
                return true;
            client unClient = obj as client;
            return (unClient.Nomclient.StartsWith(textRechercheNomPrenom.Text, StringComparison.OrdinalIgnoreCase)
            || unClient.Prenomclient.StartsWith(textRechercheNomPrenom.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void textRechercheNomPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dgClient.ItemsSource).Refresh();
        }
    }
}

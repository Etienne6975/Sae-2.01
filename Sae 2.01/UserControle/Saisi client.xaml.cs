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
using table;

namespace Sae_2._01
{
    /// <summary>
    /// Logique d'interaction pour Saisi_client.xaml
    /// </summary>
    public partial class Saisi_client : UserControl
    {
        private client nouveauClient;
        
        public Saisi_client()
        {
            nouveauClient = new client();
            DataContext = nouveauClient;

            InitializeComponent();
        }

        private void butadd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                nouveauClient.Create();
                fiche_client.Lagestion.LesClients.Add(nouveauClient);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Le client n'a pas pu être créé.", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }

        }
        }
}

using System.ComponentModel;
using System.Net;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static client lesClients  { get; set; }
        public MainWindow()
        {
            ChargeData();
            Hide();
            Seconnecter seconnecter = new Seconnecter();
            seconnecter.ShowDialog();
            InitializeComponent();
            Show();
        }

        private void ButFicheClient_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (result != MessageBoxResult.Yes)
            {
                e.Cancel = true; 
            }
        }

        private void Accueil_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public void ChargeData()
        {
            try
            {
                lesClients = new client();
                this.DataContext = lesClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problème lors de récupération des données,veuillez consulter votre admin");

                Application.Current.Shutdown();
            }
        }

        private void ButDeconnexion_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButDeconnexion_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

}
using Sae_2._01.Model;
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
using static System.Collections.Specialized.BitVector32;

namespace Sae_2._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static client LesClients  { get; set; }
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
                LesClients = new client();
                this.DataContext = LesClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Détails", MessageBoxButton.OK, MessageBoxImage.Error);
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
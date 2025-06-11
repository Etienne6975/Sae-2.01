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
        public client lesClients { get; set; }
        public MainWindow()
        {
            ChargeData();
            Seconnecter seconnecter = new Seconnecter();
            seconnecter.ShowDialog();
            InitializeComponent();
        }

        private void ButFicheClient_Click(object sender, RoutedEventArgs e)
        {
           // Conteneur.Content = new fic();
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
    }
}
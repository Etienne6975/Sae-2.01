using System.ComponentModel;
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

namespace Sae_2._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Hide();
            Seconnecter seconnecter = new Seconnecter();
            seconnecter.ShowDialog();
            InitializeComponent();
            Show();
        }

        private void ButFicheClient_Click(object sender, RoutedEventArgs e)
        {
           // Conteneur.Content = new fic();
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
    }

}
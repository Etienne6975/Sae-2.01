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
    /// Logique d'interaction pour Seconnecter.xaml
    /// </summary>
    public partial class Seconnecter : Window
    {
        public Seconnecter()
        {
            InitializeComponent();
        }
        private void ButLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = nameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "esf")
            {

                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();

                this.Close();
            }
            else
            {
                // Message d'erreur
                MessageBox.Show("Identifiants incorrects", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
     


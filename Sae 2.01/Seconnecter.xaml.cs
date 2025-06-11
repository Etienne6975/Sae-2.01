using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            string identifiant = nameTextBox.Text;
            string motDePasse = PasswordBox.Password;

            if (identifiant == "admin" && motDePasse == "1234")
            {
                MainWindow main = new MainWindow();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

     
    }
}
     


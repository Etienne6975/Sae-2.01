using Sae_2._01.Model;
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
        private bool _connexionValide = false;

        public Seconnecter()
        {
            InitializeComponent();
            this.Closing += Window_Closing;
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            string identifiant = nameTextBox.Text;
            string motDePasse = PasswordBox.Password;
            DataAccess.Instance.DefinirConnection($"Host=srv-peda-new;Port=5433;Username={identifiant};Password={motDePasse};Database=SAE201_ESF;Options='-c search_path=atake'");

            /*  if (identifiant == "admin" && motDePasse == "1234")
              {
                  _connexionValide = true; 
                  this.Close(); 
              }
              else
              {
                  MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
              }*/
            _connexionValide = true;
            this.Close();
        }


        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (!_connexionValide)
            {
                Application.Current.Shutdown();
            }
        }


    }
}



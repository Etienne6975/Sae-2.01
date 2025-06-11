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
    /// Logique d'interaction pour DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow(Inscription inscription)
        {
            InitializeComponent();
            txtSemaine.Text = inscription.Semaine.ToString();
            txtDate.Text = inscription.Date1;
            txtHoraire.Text = inscription.Horaire1;
            txtCategorie.Text = inscription.Categorie1;
            txtNiveau.Text = inscription.Niveau1.ToString();
        }

        private void Fermer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

using System.Configuration;
using System.Data;
using System.Windows;

namespace Sae_2._01
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var loginWindow = new Seconnecter();
            this.MainWindow = loginWindow; 
            loginWindow.Show();
        }
    }

}

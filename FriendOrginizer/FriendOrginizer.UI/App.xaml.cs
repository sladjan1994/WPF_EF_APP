using Autofac;
using FriendOrginizer.UI.Data;
using FriendOrginizer.UI.Startup;
using FriendOrginizer.UI.ViewModel;
using System.Windows;

namespace FriendOrginizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();

            //var mainWindow = new MainWindow(new MainViewModel(new FriendDataService()));
            mainWindow.Show();
        }
    }
}

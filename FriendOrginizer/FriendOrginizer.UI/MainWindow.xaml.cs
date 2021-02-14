using FriendOrginizer.UI.ViewModel;
using System.Threading.Tasks;
using System.Windows;

namespace FriendOrginizer.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindowLoaded; //ne treba u konstruktoru da se poziva nikakva metoda za load, pa ide ovako preko Loaded eventa
        }

        private async void MainWindowLoaded(object sender, RoutedEventArgs e)  //kod event handlera ide void a ne Task kao kod ostalih!!!!
        {
             await _viewModel.LoadAsync();
        }
    }
}

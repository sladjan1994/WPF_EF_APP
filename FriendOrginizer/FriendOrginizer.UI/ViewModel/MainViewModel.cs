using FriendOrginizer.Model;
using FriendOrginizer.UI.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FriendOrginizer.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {

        private IFriendDataService _friendDataService;

        private Friend _selectedFriend;

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get 
            {
                return _selectedFriend; 
            }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged(); //nameof(SelectedFriend))
            }
        }


        public async Task LoadAsync() //umjesto void ide Task
        {
            var friends = await _friendDataService.GetAllAsync();
            Friends.Clear(); //cisti se lista
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }

    }

}

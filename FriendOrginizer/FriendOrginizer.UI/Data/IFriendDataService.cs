using FriendOrginizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrginizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}
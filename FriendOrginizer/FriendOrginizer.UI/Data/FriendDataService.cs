using FriendOrginizer.DataAccess;
using FriendOrginizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrginizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrginizerDbContext> _contextCreator;  //funkcija koja vraca DbContext, ne znam zasto stavlja funkciju radi i sa obicnom promjenljivom

        public FriendDataService(Func<FriendOrginizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Friend>> GetAllAsync()
        {
            using (var ctx = _contextCreator()) //skontaj sto treba using ovdje
            {
               return await ctx.Friends.AsNoTracking().ToListAsync();
                //await Task.Delay(5000);
                //return friends;

            }
            //yield return new Friend { FirstName = "Thomas", LastName = "Huber" };
            //yield return new Friend { FirstName = "Andreas", LastName = "Boehler" };
            //yield return new Friend { FirstName = "Julia", LastName = "Huber" };
            //yield return new Friend { FirstName = "Chrissi", LastName = "Egin" };
        }
    }
}

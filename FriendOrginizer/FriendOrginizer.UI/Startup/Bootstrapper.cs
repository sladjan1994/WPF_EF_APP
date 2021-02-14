using Autofac;
using FriendOrginizer.DataAccess;
using FriendOrginizer.UI.Data;
using FriendOrginizer.UI.ViewModel;

namespace FriendOrginizer.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();
            //zelim da koristim FriendDataService kada je potreban IFriendDataService

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<FriendOrginizerDbContext>().AsSelf();

            return builder.Build();
        }
    }
}

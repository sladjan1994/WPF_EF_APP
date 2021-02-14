namespace FriendOrginizer.DataAccess.Migrations
{
    using FriendOrginizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrginizer.DataAccess.FriendOrginizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrginizer.DataAccess.FriendOrginizerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Friends.AddOrUpdate(p => p.FirstName,      //na osnovu FirstName-a se gleda da li se radi Add ili Update
                 new Friend { FirstName = "Thomas", LastName = "Huber" },
                 new Friend { FirstName = "Urs", LastName = "Meier" },
                 new Friend { FirstName = "Erkan", LastName = "Egin" },
                 new Friend { FirstName = "Sara", LastName = "Huber" });

        }
    }
}

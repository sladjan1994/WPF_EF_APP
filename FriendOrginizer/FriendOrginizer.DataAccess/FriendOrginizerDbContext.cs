using FriendOrginizer.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FriendOrginizer.DataAccess
{
    public class FriendOrginizerDbContext : DbContext
    {
        public FriendOrginizerDbContext() : base("FriendOrginizerDb") //connection string
        {

        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new FriendConfiguration());  //FluentApi
        }
        //public class FriendConfiguration : EntityTypeConfiguration<Friend>
        //{
        //    public FriendConfiguration()
        //    {
        //        Property(f => f.FirstName)  //Property je metoda
        //            .IsRequired()
        //            .HasMaxLength(50);
        //    }
        //}

    }
}


using AppModel.Seed;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.Model
{
    public partial class Entities1 : DbContext
    {

        public static string DefaultConnectionString;
        public static int DefaultCommandTimeoutSeconds = 30;

        public Entities1()
            : base(DefaultConnectionString)
        {

            (this as System.Data.Entity.Infrastructure.IObjectContextAdapter).ObjectContext.CommandTimeout = DefaultCommandTimeoutSeconds;
        }

        public DbSet<SystemMenuItem1> SystemMenuItems { get; set; }

        public DbSet<SystemMenuTree1> SystemMenuTrees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Entities1>(new MyInitializer());

        //    //Database.SetInitializer<Entities>(new MyInitializer());
        //    //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Entities>());
        //    //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Entities, Configuration>());    
        //    //Database.SetInitializer<Entities>(null);
        //    //var migrator = new DbMigrator(new Migrations.Configuration());
        //    //migrator.Update();
        //    //Database.SetInitializer<Entities>(null);
        //    //Database.SetInitializer<Entities>(new MigrateDatabaseToLatestVersion<Entities, Migrations.Configuration>());
        //    //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Entities, DbConfiguration>());
        //    //var migrator = new DbMigrator(new MyMigrationsConfiguration());
        //    //migrator.Update();
        //    //modelBuilder.Entity<Trader>().HasKey(t => t.TraderId);
        //    //modelBuilder.Entity<TradeHistory>().HasKey(t => t.ProviderTicket);
        //    //modelBuilder.Entity<OpenPosition>().HasKey(t => t.ProviderTicket);
        //    //modelBuilder.Entity<FollowedTrader>().HasKey(t => t.TraderId);
        //    //modelBuilder.Entity<AppException>().HasKey(t => t.ExceptionId);

        //    //modelBuilder.Entity<TradeHistory>().HasRequired(p => p.Trader).WithMany(b => b.TradeHistories).HasForeignKey(p => p.TraderId);
        //    //modelBuilder.Entity<OpenPosition>().HasRequired(p => p.Trader).WithMany(b => b.OpenPositions).HasForeignKey(p => p.TraderId);

        //    //modelBuilder.Entity<Trader>().Property(t => t.TraderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        //    //modelBuilder.Entity<TradeHistory>().Property(t => t.ProviderTicket).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        //    //modelBuilder.Entity<OpenPosition>().Property(t => t.ProviderTicket).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        //    //modelBuilder.Entity<FollowedTrader>().Property(t => t.TraderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        public class MyInitializer : CreateDatabaseIfNotExists<Entities1>
        {
            protected override void Seed(Entities1 context)
            {
                SystemMenuItemSeed.CreateSystemMenuItemSeed(context);
                SystemMenuTreeSeed.CreateSystemMenuTreeSeed(context);
                //context.Database.ExecuteSqlCommand("CREATE INDEX IX_TradeHistory_1 ON TradeHistories (RowUpdated)");
                //context.Database.ExecuteSqlCommand("CREATE INDEX IX_Traders_1 ON Traders (FileDownloaded)");
            }
        }
    }
}

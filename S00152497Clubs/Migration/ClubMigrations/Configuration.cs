namespace S00152497Clubs.Migration.ClubMigrations
{
    using Models.ClubsModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<S00152497Clubs.Models.ClubsModel.ClubsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\ClubMigrations";
        }

        protected override void Seed(S00152497Clubs.Models.ClubsModel.ClubsContext context)
        {
            context.Clubs.AddOrUpdate(c => c.ClubName, new Club
                {
                    ClubName = "The Chess Club",
                    CreationDate = DateTime.Now
                });

            context.Clubs.AddOrUpdate(c => c.ClubName, new Club
            {
                ClubName = "Tiddly Winks Club",
                CreationDate = DateTime.Now
            });
        }
    }
}

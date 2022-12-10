using TesteMVC5.Data;

namespace TesteMVC5.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            // será alterado para true para conseguirmos aplicar as migrations
            AutomaticMigrationsEnabled = true;
        }

        //Seed = serve para incluir informações no BD no momento da criação
        protected override void Seed(AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

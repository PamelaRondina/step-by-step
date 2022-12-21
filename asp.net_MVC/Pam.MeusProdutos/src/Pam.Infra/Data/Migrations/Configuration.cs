
using Pam.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace Pam.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
                
    }
}

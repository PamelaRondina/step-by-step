using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TesteMVC5.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TesteMVC5.Data
{
    public class AppDbContext : DbContext
    {
        //objetivo do DbContext será mapear as classes para que as tabelas se tornem BD
        public AppDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Aqui, está bloqueando a convensão de incluir o plural nas tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Cliente>().ToTable("Clientes");

            base.OnModelCreating(modelBuilder);
        }
    }
}
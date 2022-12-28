using Pam.Business.Models.Fornecedores;
using Pam.Business.Models.Produtos;
using Pam.Infra.Data.Mappings;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Pam.Infra.Data.Context
{
    //Adicionar herança
    public class MeuDbContext : DbContext
    {
        //constructor vai passar para a classe base com o nome abaixo
        public MeuDbContext() : base(nameOrConnectionString: "DefaultConnection")
        { 
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        //Mapeamento (nomes sempre no PLURAL)
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Deabilitar: Nome das tabelas no plural*/
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            /*Desabilitar: a exclusão em cascata*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            /*Se for do tipo string = será VARCHAR(100)*/
            modelBuilder.Properties<string>().Configure(p => p
                .HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

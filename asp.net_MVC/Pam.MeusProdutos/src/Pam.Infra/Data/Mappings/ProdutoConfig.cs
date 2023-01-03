

using Pam.Business.Models.Produtos;
using System.Data.Entity.ModelConfiguration;

namespace Pam.Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>   
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(1000);

            Property(p => p.Imagem)
                .IsRequired()
                .HasMaxLength(100);
             
            /*Produto tem um relacionamento com o Fornecedor*/
            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);

            /*Nome da Tabela*/
            ToTable("Produtos");
        }
    }
}

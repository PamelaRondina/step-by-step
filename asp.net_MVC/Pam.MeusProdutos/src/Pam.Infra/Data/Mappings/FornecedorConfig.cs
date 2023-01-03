using Pam.Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Pam.Infra.Data.Mappings
{
    // Aqui temos um mapeamento realizado através do EntityTypeConfiguration de Fornecedor
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            //A chave primária da minha tabela é o ID
            HasKey(f => f.Id);

            //mapear Propriedade = Nome não pode ser nulo | VARCHAR(200)
            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            //mapear Documento = Documento não pode ser nulo | VARCHAR(14) para CPF ou CNPJ | Possui um Índice (para mapeamento mais rápido)
            Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Documento",
                //Index ser único não é possível cadastrar dois ou mais iguais
               new IndexAnnotation(new IndexAttribute {IsUnique = true}));
               
            //É Obrigatório o Endereço
            //Se não fosse obrigatório seria incluso:  HasOptional
            HasRequired(f => f.Endereco)
                //O principal é o Fornecedor nesta relação
                .WithRequiredPrincipal(e => e.Fornecedor);

            //Nome da Tabela
            ToTable("Fornecedores");
        }
    }
}

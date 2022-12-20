using Pam.Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;


namespace Pam.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {

        public EnderecoConfig()
        {
            /*A chave primária da minha tabela é o ID*/
            HasKey(p => p.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(50);

            /*Possui tamanho fixo*/
            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(c => c.Complemento)
                .HasMaxLength(250);

            Property(c => c.Bairro)
               .IsRequired();


            Property(c => c.Cidade)
               .IsRequired();

            Property(c => c.Estado)
               .IsRequired();
       

            /*Nome da Tabela*/
            ToTable("Enderecos");
        }
    }
}

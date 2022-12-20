using Pam.Business.Core.Models;
using Pam.Business.Models.Fornecedores;
using System;

namespace Pam.Business.Models.Produtos
{
    // Classe Fornecedor que vai herdar de Entity
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
       
        /*EF Relations - Relacionamento com o Fornecedor*/
        public Fornecedor Fornecedor { get; set; }
    }
}


using Pam.Business.Core.Models;
using Pam.Business.Models.Produtos;
using System.Collections.Generic;

namespace Pam.Business.Models.Fornecedores
{
    // Classe Fornecedor que vai herdar de Entity
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; } 
        public bool Ativo { get; set; }
    
        /*EF Relations*/
        public ICollection<Produto> Produtos { get; set; }
    }
}

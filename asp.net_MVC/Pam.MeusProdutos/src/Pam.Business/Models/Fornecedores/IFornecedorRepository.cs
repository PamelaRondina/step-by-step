using Pam.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Fornecedores
{
    // Para não repetirmos informações [ : IRepository<Fornecedor> ]
    // Tudo o que o Irepository implementa + os dois métodos deste 
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);

    }
}

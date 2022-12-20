using Pam.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pam.Business.Models.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        //lista de produtos e seus fornecedores
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutosFornecedor(Guid id);
    }
}

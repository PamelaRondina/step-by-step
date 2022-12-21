using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Produtos.Services
{
    public interface IProdutosService : IDisposable
    {
        /*Realizar modificações no estado da minha entidade*/
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }

}

using Pam.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}

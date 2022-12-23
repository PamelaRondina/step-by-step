using Pam.Business.Models.Fornecedores;
using Pam.Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}

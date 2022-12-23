using Pam.Business.Models.Fornecedores;
using Pam.Infra.Data.Context;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Pam.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context) { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            /*retornar o Fornecedor + Endereço populado*/
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
             .Include(f => f.Endereco)
             .Include(f => f.Produtos)
             .FirstOrDefaultAsync(f => f.Id == id);
        }

        /*Método para não remover um Fornecedor e sim deixá-lo Intaivo
        public override async Task Remover(Guid id)
        {
            var fornecedor = await ObterPorId(id);
            fornecedor.Ativo = false;

            await Atualizar(fornecedor);*/
    }
}

using Pam.Business.Core.Notificacoes;
using Pam.Business.Core.Services;
using Pam.Business.Models.Produtos.Validations;
using System;
using System.Threading.Tasks;

namespace Pam.Business.Models.Produtos.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador) 
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {/*Para Adicionar um produto, executa a validação*/
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }
               
        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }
        /*verificar se no repositório possui instância*/
        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }

}

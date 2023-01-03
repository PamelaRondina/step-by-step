using System;
using System.Linq;
using System.Threading.Tasks;
using Pam.Business.Core.Notificacoes;
using Pam.Business.Core.Services;
using Pam.Business.Models.Fornecedores.Validations;


namespace Pam.Business.Models.Fornecedores.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, 
                                 IEnderecoRepository enderecoRepository,
                                 INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
            
        }
        public async Task Adicionar(Fornecedor fornecedor)
        {
            //Limitações do EF 6 fora da convenção
            fornecedor.Endereco.Id = fornecedor.Id;
            fornecedor.Endereco.Fornecedor = fornecedor;

            /*Fornecedor e Endereço estão validos? Se não, retorna!*/
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

            /*Fornecedor Existe com esse documento? Se sim, retorna*/
            if (await FornecedorExistente(fornecedor)) return;

            /*estando ok, Adiciona*/
            await _fornecedorRepository.Adicionar(fornecedor);

        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            /*Fornecedor está válido? Se não, retorna!*/
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            /*Fornecedor Existe com esse documento? Se sim, retorna*/
            if (await FornecedorExistente(fornecedor)) return;

            /*estando ok, Atualiza*/
            await _fornecedorRepository.Atualizar(fornecedor);
        }

        public async Task Remover(Guid id)
        {
            var fornecedor = await _fornecedorRepository.ObterFornecedorProdutosEndereco(id);
            /*regra, não pode deletar fornecedor com produtos
             Se o fornecedor possui produtos, retorna*/
            if (fornecedor.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos cadastrados!");
                return;
            }
            /*Se o endereço do fornecedor.Endereço for diferente de NULL será removido o Endereço*/
            if (fornecedor.Endereco != null)
            {
                await _enderecoRepository.Remover(fornecedor.Endereco.Id);
            }
            /*Depois de remover o endereço, remover o fornecedor*/

            await _fornecedorRepository.Remover(id);
        }
        public async Task AtualizarEndereco(Endereco endereco)
        {
            /*Endereço está válido? Se não, retorna!*/
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

            await _enderecoRepository.Atualizar(endereco);
        }

        private async Task<bool> FornecedorExistente(Fornecedor fornecedor)
        {
            var fornecedorAtual = await _fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id);

            if (!fornecedorAtual.Any()) return false;

            Notificar("Já existe um fornecedor com este documento informado.");
                  
            return true;
        }

            public void Dispose()
            {
                _fornecedorRepository?.Dispose();
                _enderecoRepository?.Dispose();
            }

        }
    } 


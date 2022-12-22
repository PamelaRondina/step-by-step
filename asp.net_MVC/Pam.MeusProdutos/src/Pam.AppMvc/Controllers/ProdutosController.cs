using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pam.AppMvc.Teste;
using Pam.AppMvc.ViewModels;
using Pam.Business.Models.Produtos;
using Pam.Business.Models.Produtos.Services;
using Pam.Business.Core.Notificacoes;
using Pam.Infra.Data.Repository;
using AutoMapper;

namespace Pam.AppMvc.Controllers
{
    public class ProdutosController : Controller
    {
        /*para realizar a leitura*/
        private readonly IProdutoRepository _produtoRepository;
        /*para modificar o BD*/
        private readonly IProdutoService _produtoService;
        /*adicionar o AutoMapper*/
        private readonly IMapper _mapper;

        public ProdutosController()
        {
            /*_produtoRepository = new ProdutoRepository();
            _produtoService = new ProdutoService(_produtoRepository,new Notificador());*/
        }

        [Route("lista-de-produtos")]
        [HttpGet]
        public async Task<ActionResult> Index()
            /*retornar uma lista de produtos ViewModel
             produtosVM = ProdutosViewModel*/
        {            
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()));
        }

     
        [Route("dados_do_produto/{id:guid}")]
        [HttpGet]

        public async Task<ActionResult> Details(Guid id)
        {            
            var produtoViewModel = await ObterProduto(id);
     
            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }
                
        [Route("novo-produto")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Route("novo-produto")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Adicionar(_mapper.Map<Produto>(produtoViewModel));
               
                return RedirectToAction("Index");
            }

            return View(produtoViewModel);
        }

        [Route("editar-produto/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return HttpNotFound(); 
            }

            return View(produtoViewModel);

        }
         
        [Route("editar-produto/{id:guid}")]        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Atualizar(_mapper.Map<Produto>(produtoViewModel));

                return RedirectToAction("Index");
            }
            return View(produtoViewModel);
        }

        [Route("excluir-produto/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Delete(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)

            {                
                return HttpNotFound();
            }

            return View(produtoViewModel);
        }

        [Route("excluir-produto/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)

            {
                return HttpNotFound();
            }

            await _produtoService.Remover(id);

            return RedirectToAction("Index");
        }

        private async Task<ProdutoViewModel> ObterProduto(Guid id)
        {
            var produto = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutosPorFornecedor(id));
            return produto;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _produtoRepository.Dispose();
                _produtoService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

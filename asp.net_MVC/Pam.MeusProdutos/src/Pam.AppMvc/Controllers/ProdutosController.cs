using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Pam.AppMvc.ViewModels;
using Pam.Business.Models.Produtos;
using AutoMapper;
using Pam.Business.Models.Produtos.Services;
using Pam.Business.Models.Fornecedores;
using Pam.Infra.Data.Repository;
using System.IO;
using System.Web;

namespace Pam.AppMvc.Controllers
{
    public class ProdutosController : BaseController
    {
        /*para realizar a leitura*/
        private readonly IProdutoRepository _produtoRepository;
        /*para modificar o BD*/
        private readonly IProdutoService _produtoService;

        private readonly IFornecedorRepository fornecedorRepository;
        /*adicionar o AutoMapper*/
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository,
                                  IProdutoService produtoService,
                                  IFornecedorRepository fornecedorRepository,
                                  IMapper mapper)
        {

            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        [Route("lista-de-produtos")]
        [HttpGet]
        public async Task<ActionResult> Index()
            /*retornar uma lista de produtos ViewModel
             produtosVM = ProdutosViewModel*/
        {            
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosFornecedores()));
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
        public async Task<ActionResult> Create()
        {
            var produtoViewModel = await PopularFornecedores(new ProdutoViewModel());

            return View(produtoViewModel);
        }

        [Route("novo-produto")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            produtoViewModel = await PopularFornecedores(produtoViewModel);
            if (!ModelState.IsValid) return View(produtoViewModel);

            var imgPrefixo = Guid.NewGuid() + "_";
            if (!UploadImagem(produtoViewModel.ImagemUpload, imgPrefixo))
            {
                return View(produtoViewModel);
            }

            produtoViewModel.Imagem = imgPrefixo + produtoViewModel.ImagemUpload.FileName;
           await _produtoService.Adicionar(_mapper.Map<Produto>(produtoViewModel));       

            return RedirectToAction("Index");
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
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return produto;
        }

        private async Task<ProdutoViewModel> PopularFornecedores(ProdutoViewModel produto)
        {
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return produto;
        }

        private bool UploadImagem(HttpPostedFileBase img, string imgPrefixo)
        {
            if (img == null || img.ContentLength <= 0)
            {
                ModelState.AddModelError(string.Empty, "Imagem em formato inválido!");
                return false;
            }

            var path = Path.Combine(HttpContext.Server.MapPath("~/imagens"), imgPrefixo + img.FileName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
                return false;
            }

            img.SaveAs(path);
            return true;
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

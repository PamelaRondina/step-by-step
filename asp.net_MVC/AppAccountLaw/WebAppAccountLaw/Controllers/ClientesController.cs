using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppAccountLaw.Models;

namespace WebAppAccountLaw.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        
        //instância do contexto
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route(template:"listar-clientes") ]
        // (retornar uma lista dos Clientes)
        public async Task<ActionResult> Index()
        {
            return View(await db.Clientes.ToListAsync());
        }

        [HttpGet]
        [Route(template: "cliente/detalhe/{id:int}")]
        // (com base no ID)
        public async Task<ActionResult> Details(int id)
        {        
            var cliente = await db.Clientes.FindAsync(id);

            if (cliente == null)
            {
                //caso não seja encontrado retonar NotFound
                return HttpNotFound();
            }
            //se sim, retorna na View
            return View(cliente);
        }

      //(retorna uma View de criação)
        [HttpGet]
        [Route(template: "novo-cliente")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create      
        [HttpPost]
        [Route(template: "novo-cliente")]
        [ValidateAntiForgeryToken]
        //receber de volta
        //Bind = receber as propriedades que estão dentro deste campo, se incluir mais campos na tabela, é necessário incluir aqui!!
        public async Task<ActionResult> Create([Bind(Include = "Id,NomeEmpresa,CNPJ,NomeContatoFinanceiro,Email,Telefone,Ativo")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.DataMatricula = DateTime.Now;
                //vai adicionar no contexto
                db.Clientes.Add(cliente);
                //e salvar
                await db.SaveChangesAsync();

                TempData["Mensagem"] = "Cliente cadastrado com sucesso!";

                // retorna para Index de Clientes
                return RedirectToAction("Index");
            }

            //tendo algum problema, retorna para a View
            return View(cliente);
        }

        [HttpGet]
        [Route(template: "editar-cliente/{id:int}")]
        // vai puxar um ID específico 
        public async Task<ActionResult> Edit(int id)
        {
            //caso não exista, retorna um NotFound
            var cliente = await db.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            //caso exista, retorna a View para poder editar e submeter na próxima etapa
            return View(cliente);
        }

        // POST: Clientes/Edit/5
       
        [HttpPost]
        [Route(template: "editar-cliente/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NomeEmpresa,CNPJ,NomeContatoFinanceiro,Email,Telefone,Ativo")] Cliente cliente)
        {            
            {
                //se for válido, será modificado no Entry
                db.Entry(cliente).State = EntityState.Modified;
                db.Entry(cliente).Property(Cliente => Cliente.DataMatricula).IsModified = false;
                //será salvo
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpGet]
        [Route(template: "excluir-cliente/{id:int}")]
        // pelo ID tenterá encotrar o Cliente
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)

            {  //caso não exista, retorna um NotFound
                return HttpNotFound();
            }
            ViewBag.Mensagem = "Atenção, ao continuar: Ação Irreversível!";

            //caso exista, retorna a Viewo Delete POST
            return View(cliente);
        }

        [HttpPost]
        [Route(template: "excluir-cliente/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            //o Cliente será removido
            var cliente = await db.Clientes.FindAsync(id);
            db.Clientes.Remove(cliente);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

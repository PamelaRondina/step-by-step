using System;
using System.Web.Mvc;
using TesteMVC5.Data;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext context = new AppDbContext();

        [HttpGet]
        [Route(template: "novo-cliente")]

        public ActionResult NovoCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route(template: "novo-cliente")]
        public ActionResult NovoCliente(Cliente cliente)
        {
            
            if (!ModelState.IsValid) return View(cliente);

            cliente.DataMatricula = DateTime.Now;

            context.Clientes.Add(cliente);
            context.SaveChanges();

            return View(cliente);

        }
    }

}
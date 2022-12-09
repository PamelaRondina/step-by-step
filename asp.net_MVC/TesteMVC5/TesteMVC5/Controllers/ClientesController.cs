using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class ClientesController : Controller
    {
        /*Simular a entrada de um cliente*/

        [Route(template:"novo-cliente")]
        public ActionResult Novo(Cliente cliente)
        /*Este formato não é utilizado no dia a dia*/
        {
            /*pegar referência a criar uma nova instância > */
            cliente = new Cliente
            {
                Id = 1,
                NomeEmpresa = "Direitos Advocacia",
                CNPJ = "00000582000189",
                NomeContatoFinanceiro = "Kelly Cristina",
                Email = "kelly.cristina@direitosadv.com.br",
                Telefone = "(11) 95825-0000",
                DataMatricula = DateTime.Now,
                Ativo = true

            };

            /*passar um dado para outra Action*/
            return RedirectToAction("Index", cliente);
        }

        public ActionResult Index(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            return View(cliente);
        }


    }
}
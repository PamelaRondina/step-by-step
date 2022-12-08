using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route(template: "sobre-nos")]
        public ActionResult About()
        {
            ViewBag.Message = "Account Law.";

            return View();
        }

        [Route(template: "contatos")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Acesse nossa página.";

            return View();
        }


        [Route(template: "nossos-clientes")]
        public FileContentResult fileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/nossos_clientes.png"));

            return File(foto, contentType: "image/png", fileDownloadName: "nossos_cliente.png");
         }


        [Route(template: "agradecimentos")]
        public ContentResult ContentResult()
        {
            return Content("Agradecemos por visitar a nossa página!");
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebAppAccountLaw.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [Route(template:"sobre-nos")]
        public ActionResult About()
        {
            ViewBag.Message = "Account Law.";

            return View();
        }


        [Route(template: "contato")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Dúvidas? Estamos à disposição!.";

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
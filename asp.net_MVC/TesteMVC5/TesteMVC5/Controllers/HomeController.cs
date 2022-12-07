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

        public ActionResult Contact()
        {
            ViewBag.Message = "Acesse nossa página.";

            return View();
        }


        [Route(template: "agradecimentos")]
        public ContentResult ContentResult()
        {
            return Content("Agradecemos por visitar a nossa página!");
        }

        [Route(template: "nossos-clientes")]
        public FileContentResult FileContentResult()
        {
            var foto: byte[] = System.IO.File.ReadAllBytes(Server.MapPatch("/content/images/
        }



    }
}
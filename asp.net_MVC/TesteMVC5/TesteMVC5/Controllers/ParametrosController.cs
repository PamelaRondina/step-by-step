using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    /*Rota Pré-fixada*/
    [RoutePrefix("parametros")]

    public class ParametrosController : Controller
    {
        [Route(template:"{id2:int}/{texto:maxlength(50)}")]
        public ActionResult IndexParametros(int id2, string texto)
        {
            return View();
        }

        /*Nome da Rota, o que vai aparecer na URl*/
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
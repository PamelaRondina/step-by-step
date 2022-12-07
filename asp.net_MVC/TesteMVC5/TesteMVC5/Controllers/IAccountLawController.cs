using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public interface IAccountLawController
    {
        ActionResult About();
        ActionResult Contact();
        ActionResult Index();
    }
}
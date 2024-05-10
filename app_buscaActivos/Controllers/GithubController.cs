using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_buscaActivos.Controllers
{
    public class GithubController : Controller
    {
        // GET: GithubController
        public ActionResult Index()
        {
            return View();
        }
    }
}

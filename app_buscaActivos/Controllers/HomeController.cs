using app_buscaActivos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app_buscaActivos.Controllers
{
    public class HomeController : Controller
    {
       

       
        public IActionResult Index()
        {
            return View();
        }

    }
}
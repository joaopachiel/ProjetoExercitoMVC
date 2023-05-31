using Microsoft.AspNetCore.Mvc;

namespace ProjetoExercitoMVC.Controllers
{
    public class MilitarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

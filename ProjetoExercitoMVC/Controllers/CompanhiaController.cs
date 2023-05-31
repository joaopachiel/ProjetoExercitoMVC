using Microsoft.AspNetCore.Mvc;

namespace ProjetoExercitoMVC.Controllers
{
    public class CompanhiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

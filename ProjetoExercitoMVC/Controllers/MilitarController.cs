using Microsoft.AspNetCore.Mvc;
using ProjetoExercitoMVC.Models.Entity;
using ProjetoExercitoMVC.Models.ViewModel;
using ProjetoExercitoMVC.Services;

namespace ProjetoExercitoMVC.Controllers
{
    public class MilitarController : Controller
    {
        private readonly MilitarService _militarService;
        private readonly CompanhiaService _companhiaService;

        public MilitarController(MilitarService militarService ,CompanhiaService companhiaService)
        {
            _militarService = militarService;
            _companhiaService = companhiaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarNovo()
        {
            var companhias = _companhiaService.BuscarCompanhias();
            var militarViewModel = new MilitarViewModel { Companhias = companhias };
            return View(militarViewModel);
        }

        [HttpPost]
        public IActionResult CriarNovo(Militar militar)
        {
            _militarService.AdicionarMilitar(militar);
                return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProjetoExercitoMVC.Models.Entity;
using ProjetoExercitoMVC.Models.ViewModel;
using ProjetoExercitoMVC.Services;

namespace ProjetoExercitoMVC.Controllers
{
    public class CompanhiaController : Controller
    {
        private readonly CompanhiaService _companhiaService;

        public CompanhiaController(CompanhiaService companhiaService)
        {
            _companhiaService = companhiaService;
        }

        public IActionResult Index()
        {
            var listaCompanhias = _companhiaService.BuscarCompanhias();
            return View(listaCompanhias);
        }

        public IActionResult CriarNovo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarNovo(Companhia companhia)
        {
            _companhiaService.AdicionarCompanhia(companhia);
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int id)
        {
            var companhia = _companhiaService.BuscarCompanhiaPorId(id);

            return View(companhia);
        }

        [HttpPost]
        public IActionResult Editar(Companhia companhia)
        {
            _companhiaService.EditarCompanhia(companhia);
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var companhia = _companhiaService.BuscarCompanhiaPorId(id);
            return View(companhia);
        }

        [HttpPost]
        public IActionResult Deletar(Companhia companhia)
        {
            _companhiaService.DeletarCompanhia(companhia);
                return RedirectToAction(nameof(Index));
        }
    }
}

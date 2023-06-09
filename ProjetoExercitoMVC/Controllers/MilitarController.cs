﻿using Microsoft.AspNetCore.Mvc;
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
        

        public IActionResult BuscarMilitarPorId(int id)
        {
            var militar = _militarService.BuscarMilitarPorId(id);
            return View(militar);
        }

        public IActionResult BuscarMilitarPorPeriodo(DateTime? dataInicio, DateTime? dataFinal)
        {
            if (!dataInicio.HasValue)
            {
                dataInicio = new DateTime(1990, 1, 1);
            }
            if (!dataFinal.HasValue)
            {
                dataFinal = DateTime.Now;
            }
            ViewData["dataInicio"] = dataInicio.Value.ToString("yyyy-MM-dd");
            ViewData["dataFinal"] = dataFinal.Value.ToString("yyyy-MM-dd");

            var resultado = _militarService.BuscarMilitarPorPeriodo(dataInicio, dataFinal);
            return View(resultado);
        }

        public IActionResult Index()
        {
            var listaMilitares = _militarService.BuscarTodosMilitares();
            return View(listaMilitares.OrderBy(x => x.DataIngresso).ToList());
        }

        public IActionResult Pesquisas()
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

        public IActionResult Editar(int id)
        {
            var militar = _militarService.BuscarMilitarPorId(id);

            var companhias = _companhiaService.BuscarCompanhias();
            var militarViewModel = new MilitarViewModel { Militar = militar, Companhias = companhias };
            return View(militarViewModel);
        }

        [HttpPost]
        public IActionResult Editar(Militar militar)
        {
            _militarService.EditarMilitar(militar);
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var militar = _militarService.BuscarMilitarPorId(id);
            return View(militar);
        }

        [HttpPost]
        public IActionResult Deletar(Militar militar)
        {
            _militarService.DeletarMilitar(militar);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var militar = _militarService.BuscarMilitarPorId(id);
            return View(militar);
        }
    }
}

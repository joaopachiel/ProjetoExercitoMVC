﻿using ProjetoExercitoMVC.Data.Context;
using ProjetoExercitoMVC.Models.Entity;
using ProjetoExercitoMVC.Models.ViewModel;
using ProjetoExercitoMVC.Services.Interfaces;

namespace ProjetoExercitoMVC.Services
{
    public class CompanhiaService : ICompanhiaService
    {
        private readonly ProjetoExercitoMvcContext _context;

        public CompanhiaService(ProjetoExercitoMvcContext context)
        {
            _context = context;
        }

        public List<Companhia> BuscarCompanhias()
        {
            return _context.Companhia.OrderBy(x => x.Nome).ToList();
        }

        public Companhia BuscarCompanhiaPorId(int id)
        {
            return _context.Companhia.Find(id);
        }

        public void AdicionarCompanhia(Companhia companhia)
        {
            _context.Add(companhia);
            _context.SaveChanges();
            
        }

        public void EditarCompanhia(Companhia companhia)
        {
            _context.Update(companhia);
            _context.SaveChanges();
        }

        public void DeletarCompanhia(Companhia companhia)
        {
            _context.Remove(companhia);
            _context.SaveChanges();
        }

    }
}

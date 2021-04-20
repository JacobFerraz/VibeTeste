using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VibeTest.API.Application.Interfaces;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Services.Interfaces;

namespace VibeTest.API.Application
{
    public class ParlamentarApplication : IParlamentarApplication
    {
        private readonly IParlamentarService _parlamentarService;

        public ParlamentarApplication(IParlamentarService parlamentarService)
        {
            _parlamentarService = parlamentarService;
        }

        public async Task<Parlamentar> BuscarPorId(ParlamentarFilter filtro)
        {
            return await _parlamentarService.BuscarPorId(filtro);
        }

        
        public async Task<IEnumerable<Parlamentar>> BuscarTodos(ParlamentarFilter filtro)
        {
            return await _parlamentarService.BuscarTodos(filtro);
        }

        public async Task<ParlamentarDespesas> BuscarDespesasUltimosDoisMeses(int id)
        {
            return await _parlamentarService.BuscarDespesasUltimosDoisMeses(id);
        }

        public ParlamentarFilter MontarFiltroParlamentar(int pagina = 0, string nome = "", string partido = "", string uf = "", int id = 0)
        {
            return new ParlamentarFilter(pagina, nome, partido,uf, id);
        }

        public void Dispose()
        {
             _parlamentarService.Dispose();
        }
    }
}

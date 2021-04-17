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

        public async Task<Parlamentar> BuscarPorId(int id)
        {
            return await _parlamentarService.BuscarPorId(id);
        }

        public async Task<IEnumerable<Parlamentar>> BuscarTodos(int pagina)
        {
            return await _parlamentarService.BuscarTodos(pagina);
        }

        public async Task<ParlamentarDespesas> BuscarDespesasUltimosDoisMeses(int id)
        {
            return await _parlamentarService.BuscarDespesasUltimosDoisMeses(id);
        }

        public void Dispose()
        {
             _parlamentarService.Dispose();
        }
    }
}

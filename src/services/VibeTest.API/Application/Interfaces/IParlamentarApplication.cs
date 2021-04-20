using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VibeTest.Core.InterfacesGenerics;
using VibeTest.Domain.Models;

namespace VibeTest.API.Application.Interfaces
{
    public interface IParlamentarApplication : IApplication<Parlamentar, ParlamentarFilter>
    {
        Task<ParlamentarDespesas> BuscarDespesasUltimosDoisMeses(int id);
        ParlamentarFilter MontarFiltroParlamentar(int pagina = 0, string nome = "", string partido = "", string uf = "", int id = 0);
    }
}

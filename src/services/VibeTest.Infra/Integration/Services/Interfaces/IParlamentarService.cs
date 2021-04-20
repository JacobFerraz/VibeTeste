using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VibeTest.Core.InterfacesGenerics;
using VibeTest.Domain.Models;

namespace VibeTest.Infra.Integration.Services.Interfaces
{
    public interface IParlamentarService : IService<Parlamentar, ParlamentarFilter>
    {
        Task<ParlamentarDespesas> BuscarDespesasUltimosDoisMeses(int id);
    }
}

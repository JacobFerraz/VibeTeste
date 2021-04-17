using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Adapter.Interfaces
{
    public interface IParlamentarDespesasAdapter : IAdapter<DadosDespesas, ParlamentarDespesasUnitarias>
    {
    }
}

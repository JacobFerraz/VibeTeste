using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Services.Extensions
{
    public static class ParlamentarDetalhesAdapterExtensions
    {
        public static Parlamentar AdaptarParlamentarDetalhesResponse(this IParlamentarDetalhesAdapter _parlamentarDetalhesAdapter,
            DadosParlamentar response)
        {
            return _parlamentarDetalhesAdapter.CreateEntity(response);
        }
    }
}

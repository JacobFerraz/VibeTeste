using System;
using System.Collections.Generic;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Services.Extensions
{
    public static class ParlamentarAdapterExtensions
    {
        public static IEnumerable<Parlamentar> AdaptarListaParlamentarResponse(this IParlamentarAdapter _parlamentarAdapter, 
            IEnumerable<DadoParlamentar> response)
        {
            var parlamentares = new List<Parlamentar>();
            foreach (var parlamentarResponse in response)
            {
                parlamentares.Add(_parlamentarAdapter.CreateEntity(parlamentarResponse));
            }

            return parlamentares;
        }
    }
}

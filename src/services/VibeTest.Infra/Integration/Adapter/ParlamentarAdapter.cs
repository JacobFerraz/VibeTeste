using System;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Adapter
{
    public class ParlamentarAdapter : IParlamentarAdapter
    {
        public Parlamentar CreateEntity(DadoParlamentar responseModel)
        {
            return new Parlamentar
                (responseModel.Id, responseModel.Nome, responseModel.SiglaPartido, responseModel.SiglaUf, responseModel.Email);
        }
    }
}

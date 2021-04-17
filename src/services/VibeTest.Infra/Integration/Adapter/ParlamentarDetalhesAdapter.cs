using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Adapter
{
    public class ParlamentarDetalhesAdapter : IParlamentarDetalhesAdapter
    {
        public Parlamentar CreateEntity(DadosParlamentar responseModel)
        {
            var parlamentar = new Parlamentar(responseModel.Id, responseModel.UltimoStatus.Nome, responseModel.UltimoStatus.SiglaPartido,
                responseModel.UltimoStatus.SiglaUf, responseModel.UltimoStatus.Email);
            parlamentar.SetDetalhesParlamentar(CriarEntidadeDetalhesParlamentar(responseModel));

            return parlamentar;
        }

        private DetalhesParlamentar CriarEntidadeDetalhesParlamentar(DadosParlamentar parlamentarResponse)
        {
            return new DetalhesParlamentar(parlamentarResponse.NomeCivil, parlamentarResponse.UltimoStatus.UrlFoto,
                parlamentarResponse.Sexo, parlamentarResponse.DataNascimento, 
                parlamentarResponse.Escolaridade, parlamentarResponse.RedeSocial);
        }
    }
}

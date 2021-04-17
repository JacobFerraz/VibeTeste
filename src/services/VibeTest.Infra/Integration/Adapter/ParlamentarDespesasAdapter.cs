using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Adapter
{
    public class ParlamentarDespesasAdapter : IParlamentarDespesasAdapter
    {
        public ParlamentarDespesasUnitarias CreateEntity(DadosDespesas responseModel)
        {
            return new ParlamentarDespesasUnitarias(responseModel.TipoDocumento, responseModel.TipoDespesa,
            responseModel.DataDocumento, responseModel.NomeFornecedor, responseModel.ValorLiquido);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;

namespace VibeTest.Infra.Integration.ResponseModels
{
    public class ParlamentarDespesasResponse
    {
        public ICollection<DadosDespesas> Dados { get; set; }
    }
    public class DadosDespesas : IResponseModel
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string TipoDespesa { get; set; }
        public int CodDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public int CodTipoDocumento { get; set; }
        public string DataDocumento { get; set; }
        public string NumDocumento { get; set; }
        public decimal ValorDocumento { get; set; }
        public string UrlDocumento { get; set; }
        public string NomeFornecedor { get; set; }
        public string CnpjCpfFornecedor { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorGlosa { get; set; }
        public string NumRessarcimento { get; set; }
        public int CodLote { get; set; }
        public int Parcela { get; set; }
    }
}

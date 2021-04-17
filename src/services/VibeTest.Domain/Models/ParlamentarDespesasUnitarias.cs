using System;
using System.Collections.Generic;
using System.Text;
using VibeTest.Core.InterfacesGenerics;

namespace VibeTest.Domain.Models
{
    public class ParlamentarDespesasUnitarias : IAggregateRoot
    {
        public string TipoDocumento { get; private set; }
        public string TipoDespesa { get; private set; }
        public DateTime DataDespesa { get; private set; }
        public string  NomeDoFornecedor { get; private set; }
        public decimal ValorLiquido { get; private set; }

        public ParlamentarDespesasUnitarias(string tipoDocumento, string tipoDespesa, string dataDespesa, 
            string nomeDoFornecedor, decimal valorLiquido)
        {
            TipoDocumento = tipoDocumento;
            TipoDespesa = tipoDespesa;
            DataDespesa = Convert.ToDateTime(dataDespesa);
            NomeDoFornecedor = nomeDoFornecedor;
            ValorLiquido = valorLiquido;
        }

        public void setDataDespesa(DateTime dataDespesa)
        {
            this.DataDespesa = dataDespesa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ParlamentarDespesasUnitariasViewModel
    {
        public string TipoDocumento { get;  set; }
        public string TipoDespesa { get;  set; }
        public DateTime DataDespesa { get;  set; }
        public string NomeDoFornecedor { get;  set; }
        public decimal ValorLiquido { get;  set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ParlamentarDespesasMesViewModel
    {
        public decimal TotalDespesasMes { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public ICollection<ParlamentarDespesasUnitariasViewModel> DespesasUnitarias { get; set; }
    }
}

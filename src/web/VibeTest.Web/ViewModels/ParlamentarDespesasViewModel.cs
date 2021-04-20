using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VibeTest.Web.ViewModels
{
    public class ParlamentarDespesasViewModel
    {
        public decimal TotalDespesas { get; set; }
        public ICollection<ParlamentarDespesasMesViewModel> DespesasMes { get; set; }
    }

}

using System;
using System.Collections.Generic;
using VibeTest.Core.Objects.Entities;

namespace VibeTest.Domain.Models
{
    public class ParlamentarDespesas
    {
        public decimal TotalDespesas { get; set; }
        public ICollection<ParlamentarDespesasMes> DespesasMes { get; set; }
        //public ParlamentarDespesas() {}
        public ParlamentarDespesas(ICollection<ParlamentarDespesasMes> despesasMes)
        {
            DespesasMes = despesasMes;
        }
    }
}

using System.Collections.Generic;

namespace VibeTest.Domain.Models
{
    public class ParlamentarDespesasMes
    {
        public decimal TotalDespesasMes { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public ICollection<ParlamentarDespesasUnitarias> DespesasUnitarias { get; set; }

        public ParlamentarDespesasMes(ICollection<ParlamentarDespesasUnitarias> despesasUnitarias, int mes, int ano)
        {
            DespesasUnitarias = despesasUnitarias;
            Ano = ano;
            Mes = mes;
        }
    }
}

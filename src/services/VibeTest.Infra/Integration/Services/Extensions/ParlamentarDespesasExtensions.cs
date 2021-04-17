using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;

namespace VibeTest.Infra.Integration.Services.Extensions
{
    public static class ParlamentarDespesasExtensions
    {
        public static ParlamentarDespesas AdaptarListaParlamentarDespesasResponse(this IParlamentarDespesasAdapter parlamentarDespesasAdapter,
            ICollection<DadosDespesas> response)
        {
            if (response == null || response.Count == 0) return null;

            var parlamentarDespesasUnitarias = new List<ParlamentarDespesasUnitarias>();

            foreach (var parlamentarResponse in response)
            {
                parlamentarDespesasUnitarias.Add(parlamentarDespesasAdapter.CreateEntity(parlamentarResponse));
            }

            return ParlamentarDespesasExtensions.AdaptarDespesasMes(parlamentarDespesasUnitarias);          
        }
        private static ParlamentarDespesas AdaptarDespesasMes(IEnumerable<ParlamentarDespesasUnitarias> parlamentarDespesasUnitarias)
        {
            var despesasMes = new List<ParlamentarDespesasMes>();

            for  (int indice = 0; indice < 2 ; indice++)
            {
                var mesAtualContexto = DateTime.Now.AddMonths( (indice + 7)).Month;
                var anoAtual = DateTime.Now.Year;
                
                var despesasMesatual = parlamentarDespesasUnitarias.Where(despesa => 
                (despesa.DataDespesa.Month.Equals(mesAtualContexto) && despesa.DataDespesa.Year ==DateTime.Now.Year-1)).ToList();

                despesasMes.Add(new ParlamentarDespesasMes(despesasMesatual, mesAtualContexto, anoAtual)); ;
            }

            return new ParlamentarDespesas(despesasMes);
        }


    }
}

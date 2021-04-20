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
        private const int NUMERO_DE_MESES = 2;
        public static ParlamentarDespesas AdaptarListaParlamentarDespesasResponse(this IParlamentarDespesasAdapter parlamentarDespesasAdapter,
            ICollection<DadosDespesas> response)
        {
            if (response == null || response.Count == 0) return null;

            var parlamentarDespesasUnitarias = new List<ParlamentarDespesasUnitarias>();
            var despesasMes = new List<ParlamentarDespesasMes>();

            response = OrdenarDespesas(response);
            var ultimaDespesa = response.First();
            var penultimaDespesa = response.First(d => d.Ano == ultimaDespesa.Ano && d.Mes < ultimaDespesa.Mes);

            for (int index = 0; index < NUMERO_DE_MESES; index++)
            {
                if (index == (int)MesesEnumExtersions.MesAnterior)
                {
                    var despesasMesAnterior = response.Where(d => d.Ano == ultimaDespesa.Ano && d.Mes == ultimaDespesa.Mes).ToList();
                    despesasMes.Add(new ParlamentarDespesasMes(MontarListaEntidades(parlamentarDespesasAdapter, despesasMesAnterior), ultimaDespesa.Mes, ultimaDespesa.Ano));
                }
                else
                {
                    var despesasMesRetrasado = response.Where(d => d.Ano == penultimaDespesa.Ano && d.Mes == penultimaDespesa.Mes).ToList();
                    parlamentarDespesasUnitarias.AddRange(MontarListaEntidades(parlamentarDespesasAdapter, despesasMesRetrasado));
                    despesasMes.Add(new ParlamentarDespesasMes(MontarListaEntidades(parlamentarDespesasAdapter, despesasMesRetrasado), penultimaDespesa.Mes, penultimaDespesa.Ano));
                }
            }

            return new ParlamentarDespesas(despesasMes);
        }

        private static ICollection<ParlamentarDespesasUnitarias> MontarListaEntidades(IParlamentarDespesasAdapter parlamentarDespesasAdapter, ICollection<DadosDespesas> response)
        {
            var parlamentarDespesasUnitarias = new List<ParlamentarDespesasUnitarias>();
            
            foreach (var parlamentarResponse in response)
            {
                parlamentarDespesasUnitarias.Add(parlamentarDespesasAdapter.CreateEntity(parlamentarResponse));
            }
            return parlamentarDespesasUnitarias;
        }

        private static ICollection<DadosDespesas> OrdenarDespesas(ICollection<DadosDespesas> response)
        {
            var responseOrder = (from row in response orderby row.Ano descending, row.Mes descending select row).ToList();
            return responseOrder;
        }


    }
}

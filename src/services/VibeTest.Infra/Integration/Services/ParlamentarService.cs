using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using VibeTest.Core.InterfacesGenerics;
using VibeTest.Core.Objects.Integration;
using VibeTest.Domain.Models;
using VibeTest.Infra.Integration.Adapter.Interfaces;
using VibeTest.Infra.Integration.ResponseModels;
using VibeTest.Infra.Integration.Services.Interfaces;
using VibeTest.Infra.Integration.Services.Extensions;

namespace VibeTest.Infra.Integration.Services
{
    public class ParlamentarService : IParlamentarService
    {
        private readonly IIntegrationModel _integrationModel;
        private readonly HttpClient _httpClient;
        private readonly IParlamentarAdapter _parlamentarAdapter;
        private readonly IParlamentarDetalhesAdapter _parlamentarDetalhesAdapter;
        private readonly IParlamentarDespesasAdapter _parlamentarDespesasAdapter;

        public ParlamentarService(IIntegrationModel integrationModel, HttpClient httpClient, 
            IParlamentarAdapter parlamentarAdapter, IParlamentarDetalhesAdapter parlamentarDetalhesAdapter
            , IParlamentarDespesasAdapter parlamentarDespesasAdapter)
        {
            _integrationModel = integrationModel;
            _httpClient = httpClient;
            _parlamentarAdapter = parlamentarAdapter;
            _parlamentarDetalhesAdapter = parlamentarDetalhesAdapter;
            _parlamentarDespesasAdapter = parlamentarDespesasAdapter;
        }

        public async Task<Parlamentar> BuscarPorId(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<ParlamentarDetalhesResponse>
                ($"{_integrationModel.RequestUrl}/deputados/{id}");

            return (_parlamentarDetalhesAdapter.AdaptarParlamentarDetalhesResponse(response.Dados));

        }
        public async Task<IEnumerable<Parlamentar>> BuscarTodos(int pagina)
        {
           var response = await _httpClient.GetFromJsonAsync<ParlamentarResponse>
                ($"{_integrationModel.RequestUrl}/deputados/?pagina={pagina}&itens=5");

            var parlamentares = _parlamentarAdapter.AdaptarListaParlamentarResponse(response.Dados);
            return this.OrdenaEmOrdemAlfabetica(parlamentares);           
        }

        public async Task<ParlamentarDespesas> BuscarDespesasUltimosDoisMeses(int id)
        {
            var anoAtual = DateTime.Now.Year-1;
            var mesAnterior = DateTime.Now.AddMonths(-4).Month;
            var mesRetrasado = DateTime.Now.AddMonths(-5).Month;
            var response = await _httpClient.GetFromJsonAsync<ParlamentarDespesasResponse>
                ($"{_integrationModel.RequestUrl}/deputados/{id}/despesas?ano={anoAtual}&mes={mesAnterior}&mes={mesRetrasado}");

           var despesas = _parlamentarDespesasAdapter.AdaptarListaParlamentarDespesasResponse(response.Dados);
           this.CalcularDespesas(despesas);

           return despesas;
        }

        private IEnumerable<Parlamentar> OrdenaEmOrdemAlfabetica(IEnumerable<Parlamentar> parlamentares)
        {
            return parlamentares.OrderBy(p => p.Nome);
        }

        private void CalcularDespesas(ParlamentarDespesas despesas)
        {
            foreach (var despesasMes in despesas.DespesasMes)
            {
                this.CalcularDespesasMes(despesasMes);
            }
            despesas.TotalDespesas = despesas.DespesasMes.Sum(total => total.TotalDespesasMes);
        }
        private void CalcularDespesasMes(ParlamentarDespesasMes despesaMesParcial)
        {
           despesaMesParcial.TotalDespesasMes = despesaMesParcial.DespesasUnitarias.Sum(total => total.ValorLiquido);
        }
        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}

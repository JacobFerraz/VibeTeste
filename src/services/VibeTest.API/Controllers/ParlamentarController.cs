using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VibeTest.API.Application.Interfaces;
using VibeTest.Core.Services;

namespace VibeTest.API.Controllers
{
    [Route("api/parlamentar")]
    public class ParlamentarController : MainController
    {
        private readonly IParlamentarApplication _parlamentarApplication;

        public ParlamentarController(IParlamentarApplication parlamentarApplication)
        {
            _parlamentarApplication = parlamentarApplication;
        }

        [HttpGet("BuscarTodosParlamentares{pagina}")]
        public async Task<IActionResult> BuscarTodosParlamentares(int pagina,string nome, string partido, string uf)
        {
            var filtro = _parlamentarApplication.MontarFiltroParlamentar(pagina,nome,partido,uf);
            var result = await _parlamentarApplication.BuscarTodos(filtro);

            if(result == null)
            {
                AdicionaErroBase();
                return CustomResponse();
            }

            return CustomResponse(result);
        }

        [HttpGet("BuscarParlamentar{id}")]
        public async Task<IActionResult> BuscarParlamentar(int id)
        {
            var filtro = _parlamentarApplication.MontarFiltroParlamentar(id: id);
            var result = await _parlamentarApplication.BuscarPorId(filtro);

            if (result == null)
            {
                AdicionaErroBase();
                return CustomResponse();
            }

            return CustomResponse(result);
        }

        [HttpGet("BuscarDespesasUltimosDoisMeses{idParlamentar}")]
        public async Task<IActionResult> BuscarDespesasUltimosDoisMeses(int idParlamentar)
        {
            var result = await _parlamentarApplication.BuscarDespesasUltimosDoisMeses(idParlamentar);

            if (result == null)
            {
                AdicionaErroBase();
                return CustomResponse();
            }

            return CustomResponse(result);
        }

    }
}

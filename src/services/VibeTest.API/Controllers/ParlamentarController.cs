using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VibeTest.API.Application.Interfaces;
using VibeTest.Core.Services;
using VibeTest.Domain.Models;

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
        public async Task<IActionResult> BuscarTodosParlamentares(int pagina)
        {
            var result = await _parlamentarApplication.BuscarTodos(pagina);

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
            var result = await _parlamentarApplication.BuscarPorId(id);

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

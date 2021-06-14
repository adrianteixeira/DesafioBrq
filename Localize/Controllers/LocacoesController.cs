using System;
using System.Net;
using System.Threading.Tasks;
using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Localize.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocacoesController : ControllerBase
    {
        private readonly ILocacaoService _locacaoService;

        public LocacoesController(ILocacaoService locacaoService)
        {
            _locacaoService = locacaoService;
        }

        [HttpPost("Alugar")]
        public async Task<IActionResult> AlugarFilme(Locacao locacao)
        {
            if(!await _locacaoService.AlugarFilme(locacao))
            {
                return Conflict("Filme já alugado");
            }
            return Created($"api/locacao/{locacao.Id}", locacao);
        }

        [HttpPatch("Devolver/{codigoMidia}")]
        public async Task<IActionResult> DevolverFilme(Guid codigoMidia)
        {
            var horasAtrasadas = await _locacaoService.DevolverFilme(codigoMidia);
            if (horasAtrasadas > 0)
            {
                return Ok($"Filme devolvido com atraso de {horasAtrasadas} horas.");
            }

            return Ok();
        }

    }
}

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

        [HttpPost("Devolver")]
        public async Task<IActionResult> AlugarFilme(Locacao locacao)
        {
            await _locacaoService.AlugarFilme(locacao);
            //cpf.cliente, cpf.funcionario, midia.codigoBarras

            return Created($"api/locacao/{locacao.Id}", locacao);
        }

        [HttpPost("Devolver")]
        public async Task<IActionResult> DevolverFilme(Locacao locacao)
        {
            await _locacaoService.DevolverFilme(locacao);
            //cpf.cliente, cpf.funcionario, midia.codigoBarras

            return Created($"api/locacao/{locacao.LocadorId}", locacao);
        }


    }
}

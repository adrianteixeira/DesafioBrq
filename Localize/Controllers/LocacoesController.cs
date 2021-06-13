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
        private readonly ILocadorService _locacaoService;

        public LocacoesController(ILocadorService locacaoService)
        {
            _locacaoService = locacaoService;
        }

        [HttpPost("Filme")]
        public async Task<IActionResult> AlugarFilme(Locador locacao)
        {
            await _locacaoService.AlugarFilme(locacao);
            //cpf.cliente, cpf.funcionario, midia.codigoBarras

            return Created($"api/locacao/{locacao.}", locacao);
        }

        [HttpPost("Filme")]
        public async Task<IActionResult> DevolverFilme(string cpfCliente, string cpfFuncionario, string codigoMidia)
        {
            await _locacaoService.DevolverFilme(locacao);
            //cpf.cliente, cpf.funcionario, midia.codigoBarras

            return Created($"api/locacao/{locacao.}", locacao);
        }

        [HttpPost("Filme")]
        public async Task<IActionResult> VerificarDisponibilidadeFilme(Locador locacao)
        {
            await _locacaoService.VerificarDisponibilidade(locacao);
            //cpf.cliente, cpf.funcionario, midia.codigoBarras

            return Created($"api/locacao/{locacao.}", locacao);
        }


    }
}

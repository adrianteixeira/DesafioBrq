using System.Threading.Tasks;
using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Localize.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocadoresController : ControllerBase
    {
        private readonly ILocadorService _locadorService;

        public LocadoresController(ILocadorService locadorService)
        {
            _locadorService = locadorService;
        }

        [HttpPost("Locador")]
        public async Task<IActionResult> CreateLocador(Locador locador)
        {
            if(!await _locadorService.CadastrarLocador(locador))
                return Conflict($"Locador com o cpf {locador.Cpf} já cadastrado");

            return Created($"api/filmes/{locador.Cpf}", locador);
        }
    }
}

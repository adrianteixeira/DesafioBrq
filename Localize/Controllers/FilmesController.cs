using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Localize.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmeService _filmeService;

        public FilmesController(IFilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpPost("Filme")]
        public async Task<IActionResult> CadastrarFilme(Filme filme)
        {
            await _filmeService.CadastrarFilme(filme);

            return Created($"api/filmes/{filme.Nome}", filme);
        }

    }
}
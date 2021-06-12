using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Localize.Application.Services;
using Localize.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> CreateFilme(Filme filme)
        {
            await _filmeService.CadastrarFilme(filme);

            return Created($"api/cities/{filme.Nome}", filme);
        }
    }
}

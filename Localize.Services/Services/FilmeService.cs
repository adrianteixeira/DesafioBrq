using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Localize.Infra.Sql.Interfaces;
using System.Threading.Tasks;

namespace Localize.Application.Services
{

    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public async Task CadastrarFilme(Filme filme)
        {
           await _filmeRepository.Cadastrar(filme);
        }

    }
}

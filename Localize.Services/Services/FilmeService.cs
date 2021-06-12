using Localize.Domain.Models;
using Localize.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Localize.Application.Services
{
    public interface IFilmeService
    {
        Task CadastrarFilme(Filme filme);
    }

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

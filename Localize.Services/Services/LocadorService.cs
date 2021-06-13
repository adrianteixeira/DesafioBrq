using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Localize.Domain.Interfaces;
using System.Threading.Tasks;

namespace Localize.Application.Services
{
    public class LocadorService : ILocadorService
    {
        private readonly ILocadorRepository _locadorRepository;

        public LocadorService(ILocadorRepository locadorRepository)
        {
            _locadorRepository = locadorRepository;
        }

        public async Task CadastrarLocador(Locador locador)
        {
            //Regra 1 • Um locador não pode se repetir
            await _locadorRepository.Cadastrar(locador);
        }
    }
}

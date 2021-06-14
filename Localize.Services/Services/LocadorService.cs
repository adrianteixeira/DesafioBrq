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

        public async Task<bool> CadastrarLocador(Locador locador)
        {
            if (await _locadorRepository.Existe(locador.Cpf))
                return false;
            await _locadorRepository.Cadastrar(locador);
            return true;
        }
    }
}

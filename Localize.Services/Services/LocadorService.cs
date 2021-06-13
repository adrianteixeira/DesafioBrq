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
            //TODO - Regra 1 - locador nao pode se repetir
            //await _locadorRepository.Get(cpf);
            await _locadorRepository.Cadastrar(locador);
        }
    }
}

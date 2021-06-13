using Localize.Application.Interfaces;
using Localize.Domain.Models;
using Localize.Infra.Sql.Interfaces;
using System.Threading.Tasks;

namespace Localize.Application.Services
{

    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task CadastrarCliente(Cliente cliente)
        {
            await _clienteRepository.Cadastrar(cliente);
        }

    }
}

using Localize.Domain.Models;
using System.Threading.Tasks;

namespace Localize.Application.Interfaces
{
    public interface IClienteService
    {
        Task CadastrarCliente(Cliente cliente);
    }
}

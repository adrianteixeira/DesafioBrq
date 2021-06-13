using Localize.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Localize.Infra.Sql.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> Obter();
        Task<Cliente> Obter(int id);
        Task Cadastrar(Cliente cliente);
        Task Atualizar(int id, Cliente cliente);
        Task Deletar(int id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Localize.Domain.Models;

namespace Localize.Domain.Interfaces
{
    public interface ILocadorRepository
    {
        Task<IEnumerable<Locador>> Obter();
        Task<Locador> Obter(int id);
        Task<Locador> Obter(string cpf);
        Task Cadastrar(Locador locador);
        Task Atualizar(int id, Locador locador);
        Task Deletar(int id);
        Task Deletar(string cpf);
        Task<bool> Existe(string cpf);
    }
}

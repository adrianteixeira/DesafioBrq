using System.Collections.Generic;
using System.Threading.Tasks;
using Localize.Domain.Models;

namespace Localize.Infra.Sql.Interfaces
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<Filme>> Obter();
        Task<Filme> Obter(int id);
        Task Cadastrar(Filme filme);
        Task Atualizar(Filme filme, int id);
        Task Deletar(int id);
        Task<bool> AlterarDisponibilidade(int id, bool disponivel);
    }
}

using Localize.Domain.Models;
using System.Threading.Tasks;

namespace Localize.Application.Interfaces
{
    public interface IFilmeService
    {
        Task CadastrarFilme(Filme filme);
    }
}

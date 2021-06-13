using Localize.Domain.Models;
using System.Threading.Tasks;

namespace Localize.Application.Interfaces
{
    public interface ILocadorService
    {
        Task CadastrarLocador(Locador locador);
    }
}

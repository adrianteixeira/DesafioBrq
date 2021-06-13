using Localize.Domain.Models;
using System.Threading.Tasks;

namespace Localize.Application.Interfaces
{
    public interface ILocacaoService
    {
        Task AlugarFilme(Locacao locacao);
        Task DevolverFilme(Locacao locacao);
    }
}

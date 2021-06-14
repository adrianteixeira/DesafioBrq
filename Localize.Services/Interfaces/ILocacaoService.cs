using Localize.Domain.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Localize.Application.Interfaces
{
    public interface ILocacaoService
    {
        Task<bool> AlugarFilme(Locacao locacao);
        Task<double> DevolverFilme(Guid codigoMidia);
    }
}

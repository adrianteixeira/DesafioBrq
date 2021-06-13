using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Localize.Domain.Models;

namespace Localize.Domain.Interfaces
{
    public interface IMidiaRepository
    {
        Task<IEnumerable<Midia>> Obter();
        Task<Midia> Obter(int id);
        Task<Midia> Obter(Guid codigoBarras);
        Task Cadastrar(Midia midia);
        Task Atualizar(int id, Midia midia);
        Task Deletar(int id);
        Task Deletar(string codigoBarras);
        Task AlterarDisponibilidade(int id, bool disponivel);
    }
}

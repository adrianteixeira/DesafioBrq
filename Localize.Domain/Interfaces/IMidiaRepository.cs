using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Localize.Domain.Models;

namespace Localize.Domain.Interfaces
{
    public interface IMidiaRepository
    {
        Task<IEnumerable<Locador>> Obter();
        Task<Locador> Obter(Guid codigoBarras);
        Task Cadastrar(Locador locador);
        Task Atualizar(int id, Locador locador);
        Task Deletar(int id);
        Task Deletar(string cpf);
    }
}

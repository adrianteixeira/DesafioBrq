using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Localize.Domain.Models;

namespace Localize.Domain.Interfaces
{
    public interface ILocacaoRepository
    {
        Task<IEnumerable<Locacao>> Obter();
        Task<Locacao> Obter(int id);
        Task<Locacao> Obter(string cpf);
        Task Cadastrar(Locacao locacao);
        Task Atualizar(Locacao locacao);
        Task Atualizar(Locacao locacao, DateTime dataDevolvida);
        Task Deletar(int id);
        Task DeletarPorCliente(int clienteId);
        Task DeletarPorMidia(int midiaId);
    }
}

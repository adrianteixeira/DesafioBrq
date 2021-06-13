using Dapper;
using Localize.Domain.Models;
using Localize.Domain.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System;

namespace Localize.Infra.Sql.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly IDbConnection _dbConnection;
        public LocacaoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        #region Crud

        public async Task<IEnumerable<Locacao>> Obter()
        {
            string sql = "SELECT * FROM Locacao";
            return await _dbConnection.QueryAsync<Locacao>(sql);
        }

        public async Task<Locacao> Obter(int id)
        {
            string sql = "SELECT * FROM Locacao where id = @id";
            return await _dbConnection.QuerySingleAsync<Locacao>(sql, new { id });
        }

        public async Task<Locacao> Obter(string cpf)
        {
            string sql = "SELECT * FROM Locacao where cpf = @cpf";
            return await _dbConnection.QuerySingleAsync<Locacao>(sql, new { cpf });
        }

        public async Task Cadastrar(Locacao locacao)
        {
            string sql = @"INSERT INTO Locacao 
                            VALUES (@MidiaId, @ClienteId, @LocacaoId, @DataEmprestimo, @DataDevolucao
                          , @Preco, @Desconto)";
            await _dbConnection.ExecuteAsync(sql, locacao);
        }

        public async Task Atualizar(Locacao locacao)
        {
            string sql = @"UPDATE FROM Locacao VALUES (@MidiaId, @ClienteId, @LocacaoId, @DataEmprestimo
                            ,@DataDevolucao, null, @Preco, @Desconto) WHERE Id = @id";
            await _dbConnection.ExecuteAsync(sql, new { locacao });
        }

        public async Task Atualizar(Locacao locacao, DateTime dataDevolvida)
        {
            string sql = @"UPDATE FROM Locacao VALUES (@MidiaId, @ClienteId, @LocacaoId, @DataEmprestimo
                            ,@DataDevolucao, @DataDevolvida, @Preco, @Desconto) WHERE Id = @id";
            await _dbConnection.ExecuteAsync(sql, new { locacao, dataDevolvida });
        }

        public async Task Deletar(int id)
        {
            var sql = "DELETE FROM Locacao WHERE id = @id";
            await _dbConnection.ExecuteAsync(sql, id);
        }

        public async Task DeletarPorCliente(int clienteId)
        {
            var sql = "DELETE FROM Locacao WHERE clienteId = @clienteId";
            await _dbConnection.ExecuteAsync(sql, clienteId);
        }
        public async Task DeletarPorMidia(int midiaId)
        {
            var sql = "DELETE FROM Locacao WHERE midiaId = @midiaId";
            await _dbConnection.ExecuteAsync(sql, midiaId);
        }
        #endregion
    }
}

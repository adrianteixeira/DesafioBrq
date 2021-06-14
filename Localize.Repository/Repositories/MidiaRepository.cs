using Dapper;
using Localize.Domain.Models;
using Localize.Domain.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System;

namespace Localize.Infra.Sql.Repositories
{
    public class MidiaRepository : IMidiaRepository
    {
        private readonly IDbConnection _dbConnection;
        public MidiaRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        #region Crud

        public async Task<IEnumerable<Midia>> Obter()
        {
            string sql = "SELECT * FROM Midia";
            return await _dbConnection.QueryAsync<Midia>(sql);
        }

        public async Task<Midia> Obter(int id)
        {
            string sql = "SELECT * FROM Midia where id = @id";
            return await _dbConnection.QuerySingleAsync<Midia>(sql, new { id });
        }

        public async Task<Midia> Obter(Guid codigoBarras)
        {
            string sql = "SELECT * FROM Midia where CodigoBarras = @CodigoBarras";
            return await _dbConnection.QuerySingleAsync<Midia>(sql, new { codigoBarras });
        }


        public async Task Cadastrar(Midia midia)
        {
            string sql = @"INSERT INTO Midia VALUES (@FilmeId, @CodigoBarras, @Tipo, 1)";
            await _dbConnection.ExecuteAsync(sql, midia);
        }

        public async Task Atualizar(int id, Midia midia)
        {
            string sql = @"UPDATE FROM Midia VALUES (@FilmeId, @CodigoBarras, @Tipo, @Disponivel)
                                                   WHERE Id = @id";
            await _dbConnection.ExecuteAsync(sql, new { id, midia});
        }

        public async Task Deletar(int id)
        {
            var sql = "DELETE FROM Midia WHERE id = @id";
            await _dbConnection.ExecuteAsync(sql, new { id});
        }

        public async Task Deletar(string codigoBarras)
        {
            var sql = "DELETE FROM Midia WHERE codigoBarras = @codigoBarras";
            await _dbConnection.ExecuteAsync(sql, codigoBarras);
        }
        #endregion

        public async Task<IEnumerable<Midia>> ObterDisponiveisPorFilme(int filmeId)
        {
            string sql = "SELECT * FROM Midia where filmeId = @filmeId";
            return await _dbConnection.QueryAsync<Midia>(sql, filmeId);
        }

        public async Task AlterarDisponibilidade(int id, bool disponivel)
        {
            string sql = @"UPDATE Midia
                                SET disponivel = @disponivel
                                    WHERE Id = @id";
            await _dbConnection.ExecuteAsync(sql, new { id, disponivel });
        }

    }
}

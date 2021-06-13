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

        public async Task<IEnumerable<Locador>> Obter()
        {
            string sql = "SELECT * FROM Midia";
            return await _dbConnection.QueryAsync<Locador>(sql);
        }

        public async Task<Locador> Obter(int id)
        {
            string sql = "SELECT * FROM Midia where id = @id";
            return await _dbConnection.QuerySingleAsync<Locador>(sql, new { id });
        }

        public async Task<Locador> Obter(Guid codigoBarras)
        {
            string sql = "SELECT * FROM Midia where CodigoBarras = @CodigoBarras";
            return await _dbConnection.QuerySingleAsync<Locador>(sql, new { codigoBarras });
        }

        public async Task Cadastrar(Locador locador)
        {
            string sql = @"INSERT INTO Locador VALUES (@Nome, @Cpf, @Salario, @Telefone)";
            await _dbConnection.ExecuteAsync(sql, locador);
        }

        public async Task Atualizar(int id, Locador locador)
        {
            string sql = @"UPDATE FROM Locador VALUES (@Nome, @Cpf, @Salario, @Telefone)
                                                   WHERE Id = @id";
            await _dbConnection.ExecuteAsync(sql, new { id, locador});
        }

        public async Task Deletar(int id)
        {
            var sql = "DELETE FROM Locador WHERE id = @id";
            await _dbConnection.ExecuteAsync(sql, new { id});
        }

        public async Task Deletar(string cpf)
        {
            var sql = "DELETE FROM Locador WHERE cpf = @cpf";
            await _dbConnection.ExecuteAsync(sql, cpf);
        }
        #endregion

    }
}

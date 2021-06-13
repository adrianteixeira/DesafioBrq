using Dapper;
using Localize.Domain.Models;
using Localize.Domain.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Localize.Infra.Sql.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbConnection _dbConnection;
        public ClienteRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        #region Crud

        public async Task<IEnumerable<Cliente>> Obter()
        {
            string sql = "SELECT * FROM CLIENTE";
            return await _dbConnection.QueryAsync<Cliente>(sql);
        }

        public async Task<Cliente> Obter(int id)
        {
            string sql = "SELECT * FROM CLIENTE where id = @id";
            return await _dbConnection.QuerySingleAsync<Cliente>(sql, new { id });
        }

        public async Task Cadastrar(Cliente cliente)
        {
            string sql = @"INSERT INTO Cliente VALUES (@Nome, @DataNascimento, @Cpf, @Email, @Telefone)";
            await _dbConnection.ExecuteAsync(sql, cliente);
        }

        public async Task Atualizar(int id, Cliente cliente)
        {
            string sql = @"UPDATE FROM Cliente VALUES (@Nome, @DataNascimento, @Cpf, @Email, @Telefone)
                                    WHERE Id = @id";

            await _dbConnection.ExecuteAsync(sql, new
            {
                id, cliente
            });
        }

        public async Task Deletar(int id)
        {
            var sql = "DELETE FROM Cliente WHERE id = @id";
            await _dbConnection.ExecuteAsync(sql, new { name = id });
        }

        #endregion
    }
}

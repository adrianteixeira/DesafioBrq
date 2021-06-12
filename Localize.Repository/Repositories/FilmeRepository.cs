using Dapper;
using Localize.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace Localize.Repository
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<Filme>> Obter();
        Task<Filme> Obter(int id);
        Task Cadastrar(Filme filme);
        Task Atualizar(Filme filme, int id);
        Task Delete(int id);
        Task<bool>AlterarDisponibilidade(int id, bool disponivel);
    }
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IDbConnection _dbConnection;
        public FilmeRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        #region Crud

        public async Task<IEnumerable<Filme>> Obter()
        {
            string sql = "SELECT * FROM FILME";
            return await _dbConnection.QueryAsync<Filme>(sql);
        }

        public async Task<Filme> Obter(int id)
        {
            string sql = "SELECT * FROM FILME where id = @id";

            return await _dbConnection.QuerySingleAsync<Filme>(sql, new { id });
        }

        public async Task Cadastrar(Filme filme)
        {
            string sql = @"INSERT INTO Filme (Nome, Categoria, Descricao, Disponivel)
                                  VALUES (@Nome, @Categoria, @Descricao, @Disponivel)";
            
            await _dbConnection.ExecuteAsync(sql, new
            {
                filme.Nome,
                filme.Categoria,
                filme.Descricao,
                filme.Disponivel
            });
        }

        public async Task Atualizar(Filme filme, int id)
        {
            string sql = "UPDATE FROM Filme VALUES @Nome, @Categoria, @Descricao, @Disponivel WHERE Id = @id";
            
            await _dbConnection.ExecuteAsync(sql, new
            {
                id,
                filme.Nome,
                filme.Categoria,
                filme.Descricao,
                filme.Disponivel
            });
        }

        public async Task Delete(int id)
        {
            var sql = "DELETE FROM Filme WHERE id = @id";

            await _dbConnection.ExecuteAsync(sql, new { name = id });
        }

        #endregion

        public async Task<bool> AlterarDisponibilidade(int id, bool disponivel)
        {
            string sql = "UPDATE FROM Filme (Nome) VALUES(@Disponivel) WHERE Id = @id";

            int affectedRows = await _dbConnection.ExecuteAsync(sql, new
            {
                id,
                disponivel
            });

            return affectedRows > 0;
        }

    }

}

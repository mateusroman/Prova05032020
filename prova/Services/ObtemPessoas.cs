using Dapper;
using Npgsql;
using prova.Data;
using prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prova.Services
{
    public class ObtemPessoas
    {
        public List<Pessoa> ListarTodos()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Connection.ConnectionString))
            {
                try
                {
                    var query = "SELECT * FROM PESSOA ORDER BY ID";
                    var pessoas = conexao.Query<Pessoa>(query).ToList();
                    return pessoas;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

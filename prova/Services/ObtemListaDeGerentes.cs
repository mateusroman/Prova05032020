using Dapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Npgsql;
using prova.Data;
using prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Services
{
    public class ObtemListaDeGerentes
    {
        public List<SelectListItem> ListarTodos()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(Connection.ConnectionString))
            {
                try
                {
                    var query = "SELECT * FROM PESSOA WHERE FUNCIONARIO = FALSE";
                    var funcionarios = conexao.Query<Pessoa>(query).ToList();
                    var funcionariosParaComboBox =
                        (from funcionario in funcionarios
                         select new
                         {
                             TextoCandidato = funcionario.Nome,
                             ValorCandidato = funcionario.Id
                         }).AsEnumerable().Select(valoresCandidatos => new SelectListItem { 
                            Text = valoresCandidatos.TextoCandidato,
                            Value = valoresCandidatos.ValorCandidato.ToString()
                         }).ToList();

                    return funcionariosParaComboBox;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

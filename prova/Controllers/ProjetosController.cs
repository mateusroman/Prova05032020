using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using prova.Data;
using prova.Models;
using prova.ViewModels;

namespace prova.Controllers
{
    public class ProjetosController : Controller
    {
        public IActionResult Cadastrar(ProjetoViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);

            using (NpgsqlConnection conexao = new NpgsqlConnection(Connection.ConnectionString))
            {
                try
                {
                    long idGerente = 0;
                    long.TryParse(viewModel.GerenteSelecionado, out idGerente);

                    var query = $@"INSERT INTO PROJETO (Nome, Data_Inicio, Data_Previsao_Fim, Data_Fim, Descricao, Status, Orcamento, Risco, IdGerente)
                                               VALUES ('{viewModel.Nome}', '{viewModel.DataInicio}', '{viewModel.DataPrevisaoFim}', '{viewModel.DataFim}',
                                               '{viewModel.Descricao}', '{viewModel.Status}', '{viewModel.Orcamento}', '{viewModel.Risco}', {idGerente})";

                    conexao.Query<Pessoa>(query);

                    return View("~/Views/Cadastros/Index.cshtml");
                }
                catch (Exception ex)
                {
                    viewModel.Excessao = ex.Message;
                    return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);
                }
            }
        }
    }
}
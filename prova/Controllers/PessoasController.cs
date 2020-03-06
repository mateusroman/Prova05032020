using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using prova.Data;
using prova.Models;
using prova.Services;
using prova.ViewModels;

namespace prova.Controllers
{
    public class PessoasController : Controller
    {
        public IActionResult Cadastrar(PessoaViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);

            using (NpgsqlConnection conexao = new NpgsqlConnection(Connection.ConnectionString))
            {
                try
                {
                    string query = string.Empty;

                    if (viewModel.Id > 0)
                    {
                        query = $@"UPDATE PESSOA SET Nome = '{viewModel.Nome}', 
                                   DataNascimento = '{viewModel.DataNascimento}', CPF = '{viewModel.CPF}', 
                                   Funcionario = {viewModel.Funcionario} WHERE ID = {viewModel.Id}";
                    }
                    else
                    {
                        query = $@"INSERT INTO PESSOA (Nome, DataNascimento, CPF, Funcionario)
                                               VALUES ('{viewModel.Nome}', '{viewModel.DataNascimento}', '{viewModel.CPF}', {viewModel.Funcionario})";
                    }

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

        public IActionResult Editar(long? id)
        {
            if (id.GetValueOrDefault() == 0)
                return View();

            var viewModel = new PessoaViewModel();

            using (NpgsqlConnection conexao = new NpgsqlConnection(Connection.ConnectionString))
            {
                try
                {
                    var query = $@"SELECT * FROM PESSOA WHERE ID = {id}";
                    var pessoa = conexao.Query<Pessoa>(query).FirstOrDefault();
                    viewModel.Id = pessoa.Id;
                    viewModel.Nome = pessoa.Nome;
                    viewModel.CPF = pessoa.CPF;
                    viewModel.DataNascimento = pessoa.DataNascimento;
                    viewModel.Funcionario = pessoa.Funcionario;
                    viewModel.TituloPagina = "Editando Pessoa";
                    viewModel.EstaVisualizando = false;
                    return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);
                }
                catch (Exception ex)
                {
                    viewModel.Excessao = ex.Message;
                    return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);
                }
            }
        }

        public IActionResult Visualizar(long? id)
        {
            if (id.GetValueOrDefault() == 0)
                return View();

            var viewModel = new PessoaViewModel();

            using (NpgsqlConnection conexao = new NpgsqlConnection(Connection.ConnectionString))
            {
                try
                {
                    var query = $@"SELECT * FROM PESSOA WHERE ID = {id}";
                    var pessoa = conexao.Query<Pessoa>(query).FirstOrDefault();
                    viewModel.Id = pessoa.Id;
                    viewModel.Nome = pessoa.Nome;
                    viewModel.CPF = pessoa.CPF;
                    viewModel.DataNascimento = pessoa.DataNascimento;
                    viewModel.Funcionario = pessoa.Funcionario;
                    viewModel.TituloPagina = "Visualizando Pessoa";
                    viewModel.EstaVisualizando = true;
                    return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);
                }
                catch (Exception ex)
                {
                    viewModel.Excessao = ex.Message;
                    return View("~/Views/Cadastros/Pessoas.cshtml", viewModel);
                }
            }
        }

        public IActionResult Excluir(long? id)
        {
            if (id.GetValueOrDefault() == 0)
                return View();

            return View();
        }
    }
}
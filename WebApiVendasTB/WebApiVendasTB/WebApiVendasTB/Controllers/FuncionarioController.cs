using Microsoft.AspNetCore.Mvc;
using WebApiVendasTB.Dominio;

namespace WebApiVendasTB.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpPost("AdicionarFuncionario")]
        public string AdicionarFuncionario(Int32 idFuncionario,
                                                  string nomeFuncionario,
                                                  string cpfFuncionario,
                                                  string emailFuncionario,
                                                  string cargoFuncionario,
                                                  double salarioFuncionario,
                                                  DateTime dataAdmissao)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = idFuncionario;
            funcionario.Nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Email = emailFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.Salario = salarioFuncionario;
            funcionario.DataAdmissao = dataAdmissao;

            return "O registro foi salvo com sucesso.";
        }

        [HttpPut("AlterarFuncionario")]
        public string AlterarFuncionario(Int32 idFuncionario,
                                                  string nomeFuncionario,
                                                  string cpfFuncionario,
                                                  string emailFuncionario,
                                                  string cargoFuncionario,
                                                  double salarioFuncionario,
                                                  DateTime dataAdmissao)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = idFuncionario;
            funcionario.Nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Email = emailFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.Salario = salarioFuncionario;
            funcionario.DataAdmissao = dataAdmissao;

            return "O registro foi salvo com sucesso.";
        }

        [HttpDelete("ExcluirFuncionario")]
        public string ExcluirFuncionario(Int32 idFuncionario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Excluir(idFuncionario);
            return "O registro foi excluído com sucesso.";
        }

        [HttpGet("PesquisarFuncionarioPorId")]
        public string PesquisaFuncionarioPorId(Int32 idFuncionario,
                                                  string nomeFuncionario,
                                                  string cpfFuncionario,
                                                  string emailFuncionario,
                                                  string cargoFuncionario,
                                                  double salarioFuncionario,
                                                  DateTime dataAdmissao)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = idFuncionario;
            funcionario.Nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Email = emailFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.Salario = salarioFuncionario;
            funcionario.DataAdmissao = dataAdmissao;

            return funcionario.PesquisarPorId(idFuncionario);
        }

        [HttpGet("PesquisarFuncionarioPorNome")]
        public string PesquisaFuncionarioPorNome(Int32 idFuncionario,
                                                  string nomeFuncionario,
                                                  string cpfFuncionario,
                                                  string emailFuncionario,
                                                  string cargoFuncionario,
                                                  double salarioFuncionario,
                                                  DateTime dataAdmissao)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = idFuncionario;
            funcionario.Nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Email = emailFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.Salario = salarioFuncionario;
            funcionario.DataAdmissao = dataAdmissao;

            return funcionario.PesquisarPorNome(nomeFuncionario);
        }

        [HttpGet("ListarTodos")]
        public string ListarTodos(Int32 idFuncionario,
                                                  string nomeFuncionario,
                                                  string cpfFuncionario,
                                                  string emailFuncionario,
                                                  string cargoFuncionario,
                                                  double salarioFuncionario,
                                                  DateTime dataAdmissao)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = idFuncionario;
            funcionario.Nome = nomeFuncionario;
            funcionario.Cpf = cpfFuncionario;
            funcionario.Email = emailFuncionario;
            funcionario.Cargo = cargoFuncionario;
            funcionario.Salario = salarioFuncionario;
            funcionario.DataAdmissao = dataAdmissao;

            return funcionario.ListarTodos();   
        }

    }
}

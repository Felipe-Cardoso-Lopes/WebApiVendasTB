namespace WebApiVendasTB.Dominio
{
    public class Funcionario
    {
        private Int32 id;
        private string nome;
        private string cpf;
        private string email;
        private string cargo;
        private double salario;
        private DateTime dataAdmissao;

        public Funcionario()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }

        public void Adicionar()
        {

        }
        public void Alterar(Int32 idFuncionario)
        {

        }
        public void Excluir(int idFuncionario)
        {

        }
        public string PesquisarPorId(Int32 idFuncionario)
        {
            string resultado;
            resultado = $"IdFuncionario: {id}\r\n" +
                $"Nome: {nome}\r\n" +
                $"CPF: {cpf}\r\n" +
                $"e-mail: {email}\r\n" +
                $"Cargo: {cargo}\r\n" +
                $"Salário R${salario}";

            return resultado;
        }

        public string PesquisarPorNome(string NomeFuncionario)
        {
            string resultado;
            resultado = $"IdFuncionario: {id}\r\n" +
                $"Nome: {nome}\r\n" +
                $"CPF: {cpf}\r\n" +
                $"e-mail: {email}\r\n" +
                $"Cargo: {cargo}\r\n" +
                $"Salário R${salario}";

            return resultado;
        }

        public string ListarTodos()
        {
            string resultado;
            resultado = $"IdFuncionario: {id}\r\n" +
                        $"Nome: {nome}\r\n" +
                        $"CPF: {cpf}\r\n" +
                        $"e-mail: {email}\r\n" +
                        $"Cargo: {cargo}\r\n" +
                        $"Salário R${salario}";

            return resultado;
        }

    }
}

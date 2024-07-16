using ClienteEndereco.Entidades;
using System.Data.SqlClient;

namespace ClienteEndereco
{
    public class FuncionarioDados
    {
        private SqlConnection _connection = new("data source=MADARA\\SQLEXPRESS;initial catalog=CLIENTEENDERECO;trusted_connection=true");

        public void Inserir(Funcionario funcionario)
        {
            var queryInserirEndereco = $"INSERT INTO ENDERECO(RUA, CEP, BAIRRO, CIDADE, UF, COMPLEMENTO) " +
                                $"VALUES (" +
                                $"'{funcionario.Endereco.Rua}', " +
                                $"'{funcionario.Endereco.CEP}', " +
                                $"'{funcionario.Endereco.Bairro}', " +
                                $"'{funcionario.Endereco.Cidade}', " +
                                $"'{funcionario.Endereco.UF}', " +
                                $"'{funcionario.Endereco.Complemento}'); " +
                                " SELECT SCOPE_IDENTITY()";
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand(queryInserirEndereco, _connection);
            var idEndereco = sqlCommand.ExecuteScalar();

            var queryInserirFuncionario = $"INSERT INTO FUNCIONARIO(NOME, CARGO, EMAIL, ENDERECOID) " +
                               $"VALUES (" +
                               $"'{funcionario.Nome}', " +
                               $"{funcionario.Cargo}, " +
                               $"'{funcionario.Login.Email}', " +
                               $"{idEndereco}) "+
                               " SELECT SCOPE_IDENTITY()";
            _connection.Open();
            SqlCommand sqlCommandFunc = new SqlCommand(queryInserirFuncionario, _connection);
            var idFuncionario = sqlCommandFunc.ExecuteScalar();

            var queryInserirLogin = $"INSERT INTO Login(EMAIL, SENHA, FUNCIONARIOID) " +
                              $"VALUES (" +
                              $"'{funcionario.Login.Email}', " +
                              $"{funcionario.Login.Senha}, " +
                              $"{idFuncionario})";


            SqlCommand sqlCommandCliente = new SqlCommand(queryInserirLogin, _connection);
            sqlCommandCliente.ExecuteNonQuery();
            _connection.Close();
        }
    }
}





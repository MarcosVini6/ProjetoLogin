using ClienteEndereco.Entidades;
using System.Data.SqlClient;

namespace ClienteEndereco.Dados
{
    public class ClienteDados
    {
        private SqlConnection _connection = new("data source=MADARA\\SQLEXPRESS;initial catalog=CLIENTEENDERECO;trusted_connection=true");

        public void Inserir(Cliente cliente) 
        {
            var queryInserirEndereco = $"INSERT INTO ENDERECO(RUA, CEP, BAIRRO, CIDADE, UF, COMPLEMENTO) " +
                                $"VALUES (" +
                                $"'{cliente.Endereco.Rua}', " +
                                $"'{cliente.Endereco.CEP}', " +
                                $"'{cliente.Endereco.Bairro}', " +
                                $"'{cliente.Endereco.Cidade}', " +
                                $"'{cliente.Endereco.UF}', " +
                                $"'{cliente.Endereco.Complemento}'); "+
                                " SELECT SCOPE_IDENTITY()";
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand(queryInserirEndereco, _connection);
            var idRetorno = sqlCommand.ExecuteScalar();

            var queryInserirCliente = $"INSERT INTO CLIENTE(NOME, IDADE, CPF, ENDERECOID) " +
                               $"VALUES (" +
                               $"'{cliente.Nome}', " +
                               $"{cliente.Idade}, " +
                               $"'{cliente.CPF}', " +
                               $"{idRetorno})";

            SqlCommand sqlCommandCliente = new SqlCommand(queryInserirCliente, _connection);
            sqlCommandCliente.ExecuteNonQuery();
            _connection.Close();
        }
    }
}

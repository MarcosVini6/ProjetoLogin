using ClienteEndereco.Entidades;
using ClienteEndereco.Servisos;

namespace ProjetoLogin.Servicos
{
    public class ValidacaoFuncionario
    {
        public bool ValidarFuncionario(Funcionario funcionario)
        {
            if (string.IsNullOrEmpty(funcionario.Nome))
            {
                return false; 
            }
            var endereco = new ValidacaoEndereco();
            endereco.ValidarBairro(funcionario.Endereco.Bairro);

            return true;
          
        }
    }
}

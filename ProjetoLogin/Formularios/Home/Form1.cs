using ClienteEndereco;
using ClienteEndereco.Entidades;
using ClienteEndereco.Enums;
using ProjetoLogin.Servicos;

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var func = new Funcionario();
            func.Nome = txtNome.Text;

            var servicoValidar = new ValidacaoFuncionario().ValidarFuncionario(func);
            if (servicoValidar == false)
            {
                MessageBox.Show("ERRO");
                return;
            }

            var dados = new FuncionarioDados();
            dados.Inserir(func);
        }

        private void listCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargo[] cargos = (Cargo[])Enum.GetValues(typeof(Cargo));
            foreach (Cargo cargo in cargos)
            {
                Console.WriteLine(cargo);
            }
        }
    }
}
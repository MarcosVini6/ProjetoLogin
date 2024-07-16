namespace ClienteEndereco.Servisos
{
    public class ValidacaoEndereco
    {
        public bool ValidarNome(string nome)
        {
            return !string.IsNullOrEmpty(nome);
        }
        public bool ValidarIdade(int idade)
        {
            return idade >= 18 && idade <= 120;
        }
        public bool ValidarCPF(string cpf)
        {
            return cpf.Length == 11;
        }
        public bool ValidarRua(string rua)
        {
            return !string.IsNullOrEmpty(rua);
        }

        public bool ValidarCEP(string cep)
        {
            return cep.Length == 8 && int.TryParse(cep, out _);
        }

        public bool ValidarBairro(string bairro)
        {
            return !string.IsNullOrEmpty(bairro);
        }

        public bool ValidarCidade(string cidade)
        {
            return !string.IsNullOrEmpty(cidade);
        }

        public bool ValidarUF(string uf)
        {

            string[] ufsValidas = { "SP", "RJ", "MG", "RS", "PR", "SC", "DF","GO","PB","PE","RN","MA","PA","AM","AC","RR","RO","BA","CE","MT","MS","ES"};
            return Array.Exists(ufsValidas, x => x == uf);
        }

        public bool ValidarComplemento(string complemento)
        {
            return true;
        }
    }
}
    


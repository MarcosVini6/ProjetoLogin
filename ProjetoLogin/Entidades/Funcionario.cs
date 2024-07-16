using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteEndereco.Enums;

namespace ClienteEndereco.Entidades
{
    public class Funcionario
    {   
        public int Id { get; set; }
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
        public Login Login { get; set; }

        public Cargo Cargo { get; set; }
    }
}

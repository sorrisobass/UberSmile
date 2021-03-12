using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Entitys
{
    public class Passageiros : Base
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool IsAtivo { get; set; }
    }
}

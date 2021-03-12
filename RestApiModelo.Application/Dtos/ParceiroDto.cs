using System;

namespace RestApiModelo.Application.Dtos
{
    public class ParceiroDto
    {
        //public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool IsAtivo { get; set; }
    }
}
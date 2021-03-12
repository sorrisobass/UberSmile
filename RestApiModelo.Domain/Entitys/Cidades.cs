using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Entitys
{
    public class Cidades : Base
    {
        public string Descricao { get; set; }
        public decimal Longitude { get; set; }
        public Double Latitude { get; set; }
        public Double Altura { get; set; }
        public Double PrecisaoH { get; set; }
        public Double PrecisaoV { get; set; }
        public string Caracteristica { get; set; }
    }
}

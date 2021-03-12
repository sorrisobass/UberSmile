using System;

namespace RestApiModelo.Application.Dtos
{
    public class DimensaoDto
    {
       // public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Longitude { get; set; }
        public Double Latitude { get; set; }
        public Double Altura { get; set; }
        public Double PrecisaoH { get; set; }
        public Double PrecisaoV { get; set; }
        public string Caracteristica { get; set; }
    }
}
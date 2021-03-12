using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Entitys
{
    public class Montadoras : Base
    {
        public string Descricao { get; set; }
        public int Id_Person_Parc { get; set; }
        public int Id_Dimensao { get; set; }
        public DateTime Dth_Local { get; set; }
        public DateTime Dth_Destino { get; set; }
    }
}

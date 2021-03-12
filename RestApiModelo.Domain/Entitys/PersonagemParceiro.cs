using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Entitys
{
    public class PersonagemParceiro : Base
    {
        public int Id_Personagem { get; set; }
        public int Id_Parceiro { get; set; }
        public int Id_Dimensao { get; set; }
    }
}

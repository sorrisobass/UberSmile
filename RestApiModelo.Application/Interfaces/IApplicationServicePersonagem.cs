using RestApiModelo.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelo.Application.Interfaces
{
    public interface IApplicationServicePersonagem
    {
        void Add(PersonagemDto personagemDto);

        void Update(PersonagemDto personagemDto);

        void Remove(PersonagemDto personagemDto);

        IEnumerable<PersonagemDto> GetAll();

        PersonagemDto GetById(int id);
    }
}
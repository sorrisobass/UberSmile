using RestApiModelo.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelo.Application.Interfaces
{
    public interface IApplicationServicePersonagemParceiro
    {
        void Add(PersonagemParceiroDto personagemParceiroDto);

        void Update(PersonagemParceiroDto personagemParceiroDto);

        void Remove(PersonagemParceiroDto personagemParceiroDto);

        IEnumerable<PersonagemParceiroDto> GetAll();

        PersonagemParceiroDto GetById(int id);
    }
}
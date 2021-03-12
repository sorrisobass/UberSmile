using RestApiModelo.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelo.Application.Interfaces
{
    public interface IApplicationServiceViagem
    {
        void Add(ViagemDto viagemDto);

        void Update(ViagemDto viagemDto);

        void Remove(ViagemDto viagemDto);

        IEnumerable<ViagemDto> GetAll();

        ViagemDto GetById(int id);
    }
}
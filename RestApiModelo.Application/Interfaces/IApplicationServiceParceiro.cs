using RestApiModelo.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelo.Application.Interfaces
{
    public interface IApplicationServiceParceiro
    {
        void Add(ParceiroDto parceiroDto);

        void Update(ParceiroDto parceiroDto);

        void Remove(ParceiroDto parceiroDto);

        IEnumerable<ParceiroDto> GetAll();

        ParceiroDto GetById(int id);
    }
}
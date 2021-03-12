using RestApiModelo.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModelo.Application.Interfaces
{
    public interface IApplicationServiceDimensao
    {
        void Add(DimensaoDto dimensaoDto);

        void Update(DimensaoDto dimensaoDto);

        void Remove(DimensaoDto dimensaoDto);

        IEnumerable<DimensaoDto> GetAll();

        DimensaoDto GetById(int id);
    }
}
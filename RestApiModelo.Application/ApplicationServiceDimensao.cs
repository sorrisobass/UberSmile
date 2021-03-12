using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelo.Application
{
    public class ApplicationServiceDimensao : IApplicationServiceDimensao
    {
        private readonly IServiceDimensao serviceDimensao;
        private readonly IMapper mapper;

        public ApplicationServiceDimensao(IServiceDimensao serviceDimensao
                                        , IMapper mapper)
        {
            this.serviceDimensao = serviceDimensao;
            this.mapper = mapper;
        }

        public void Add(DimensaoDto dimensaoDto)
        {
            var dimensao = mapper.Map<Cidades>(dimensaoDto);
            serviceDimensao.Add(dimensao);
        }

        public IEnumerable<DimensaoDto> GetAll()
        {
            var dimensao = serviceDimensao.GetAll();
            var dimensaoDto = mapper.Map<IEnumerable<DimensaoDto>>(dimensao);
            return dimensaoDto;
        }

        public DimensaoDto GetById(int id)
        {
            var dimensao = serviceDimensao.GetById(id);
            var dimensaoDto = mapper.Map<DimensaoDto>(dimensao);
            return dimensaoDto;
        }

        public void Remove(DimensaoDto dimensaoDto)
        {
            var dimensao = mapper.Map<Cidades>(dimensaoDto);
            serviceDimensao.Remove(dimensao);
        }

        public void Update(DimensaoDto dimensaoDto)
        {
            var dimensao = mapper.Map<Cidades>(dimensaoDto);
            serviceDimensao.Update(dimensao);
        }
    }
}
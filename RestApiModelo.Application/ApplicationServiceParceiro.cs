using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelo.Application
{
    public class ApplicationServiceParceiro : IApplicationServiceParceiro
    {
        private readonly IServiceParceiro serviceParceiro;
        private readonly IMapper mapper;
        public ApplicationServiceParceiro(IServiceParceiro serviceParceiro
                                       , IMapper mapper)
        {
            this.serviceParceiro = serviceParceiro;
            this.mapper = mapper;
        }
        public void Add(ParceiroDto parceiroDto)
        {
            var parceiro = mapper.Map<Parceiros>(parceiroDto);
            serviceParceiro.Add(parceiro);
        }

        public IEnumerable<ParceiroDto> GetAll()
        {
            var parceiro = serviceParceiro.GetAll();
            var parceiroDto = mapper.Map<IEnumerable<ParceiroDto>>(parceiro);

            return parceiroDto;
        }

        public ParceiroDto GetById(int id)
        {
            var parceiro = serviceParceiro.GetById(id);
            var parceiroDto = mapper.Map<ParceiroDto>(parceiro);

            return parceiroDto;
        }

        public void Remove(ParceiroDto parceiroDto)
        {
            var parceiro = mapper.Map<Parceiros>(parceiroDto);
            serviceParceiro.Remove(parceiro);
        }

        public void Update(ParceiroDto parceiroDto)
        {
            var parceiro = mapper.Map<Parceiros>(parceiroDto);
            serviceParceiro.Update(parceiro);
        }
    }
}

using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelo.Application
{
    public class ApplicationServiceViagem : IApplicationServiceViagem
    {
        private readonly IServiceViagem serviceViagem;
        private readonly IMapper mapper;
        public ApplicationServiceViagem(IServiceViagem serviceViagem
                                       , IMapper mapper)
        {
            this.serviceViagem = serviceViagem;
            this.mapper = mapper;
        }
        public void Add(ViagemDto viagemDto)
        {
            var viagem = mapper.Map<Viagem>(viagemDto);
            serviceViagem.Add(viagem);
        }

        public IEnumerable<ViagemDto> GetAll()
        {
            var viagem = serviceViagem.GetAll();
            var viagemDto = mapper.Map<IEnumerable<ViagemDto>>(viagem);

            return viagemDto;
        }

        public ViagemDto GetById(int id)
        {
            var viagem = serviceViagem.GetById(id);
            var viagemDto = mapper.Map<ViagemDto>(viagem);

            return viagemDto;
        }

        public void Remove(ViagemDto viagemDto)
        {
            var viagem = mapper.Map<Viagem>(viagemDto);
            serviceViagem.Remove(viagem);
        }

        public void Update(ViagemDto viagemDto)
        {
            var viagem = mapper.Map<Viagem>(viagemDto);
            serviceViagem.Update(viagem);
        }
    }
}

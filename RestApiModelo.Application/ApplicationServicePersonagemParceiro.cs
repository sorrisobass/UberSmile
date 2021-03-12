using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelo.Application
{
    public class ApplicationServicePersonagemParceiro : IApplicationServicePersonagemParceiro
    {
        private readonly IServicePersonagemParceiro servicePersonagemParceiro;
        private readonly IMapper mapper;
        public ApplicationServicePersonagemParceiro(IServicePersonagemParceiro servicePersonagemParceiro
                                       , IMapper mapper)
        {
            this.servicePersonagemParceiro = servicePersonagemParceiro;
            this.mapper = mapper;
        }
        public void Add(PersonagemParceiroDto personagemParceiroDto)
        {
            var personagemParceiro = mapper.Map<PersonagemParceiro>(personagemParceiroDto);
            servicePersonagemParceiro.Add(personagemParceiro);
        }

        public IEnumerable<PersonagemParceiroDto> GetAll()
        {
            var personagemParceiro = servicePersonagemParceiro.GetAll();
            var personagemParceiroDto = mapper.Map<IEnumerable<PersonagemParceiroDto>>(personagemParceiro);

            return personagemParceiroDto;
        }

        public PersonagemParceiroDto GetById(int id)
        {
            var personagemParceiro = servicePersonagemParceiro.GetById(id);
            var personagemParceiroDto = mapper.Map<PersonagemParceiroDto>(personagemParceiro);

            return personagemParceiroDto;
        }

        public void Remove(PersonagemParceiroDto personagemParceiroDto)
        {
            var personagemParceiro = mapper.Map<PersonagemParceiro>(personagemParceiroDto);
            servicePersonagemParceiro.Remove(personagemParceiro);
        }

        public void Update(PersonagemParceiroDto personagemParceiroDto)
        {
            var personagemParceiro = mapper.Map<PersonagemParceiro>(personagemParceiroDto);
            servicePersonagemParceiro.Update(personagemParceiro);
        }
    }
}

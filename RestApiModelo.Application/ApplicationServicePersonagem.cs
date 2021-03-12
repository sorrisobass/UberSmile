using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Application.Interfaces;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModelo.Application
{
    public class ApplicationServicePersonagem : IApplicationServicePersonagem
    {
        private readonly IServicePersonagem servicePersonagem;
        private readonly IMapper mapper;
        public ApplicationServicePersonagem(IServicePersonagem servicePersonagem
                                       , IMapper mapper)
        {
            this.servicePersonagem = servicePersonagem;
            this.mapper = mapper;
        }
        public void Add(PersonagemDto personagemDto)
        {
            var cliente = mapper.Map<Passageiros>(personagemDto);
            servicePersonagem.Add(cliente);
        }

        public IEnumerable<PersonagemDto> GetAll()
        {
            var personagem = servicePersonagem.GetAll();
            var personagemDto = mapper.Map<IEnumerable<PersonagemDto>>(personagem);

            return personagemDto;
        }

        public PersonagemDto GetById(int id)
        {
            var personagem = servicePersonagem.GetById(id);
            var personagemDto = mapper.Map<PersonagemDto>(personagem);

            return personagemDto;
        }

        public void Remove(PersonagemDto personagemDto)
        {
            var personagem = mapper.Map<Passageiros>(personagemDto);
            servicePersonagem.Remove(personagem);
        }

        public void Update(PersonagemDto personagemDto)
        {
            var personagem = mapper.Map<Passageiros>(personagemDto);
            servicePersonagem.Update(personagem);
        }
    }
}

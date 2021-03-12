using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class ModelToDtoMappingPersonagemParceiro : Profile
    {

        public ModelToDtoMappingPersonagemParceiro()
        {
            PersonagemParceiroDtoMap();
        }

        private void PersonagemParceiroDtoMap()
        {
            CreateMap<PersonagemParceiro, PersonagemParceiroDto>()
                .ForMember(dest => dest.Id_Personagem, opt => opt.MapFrom(x => x.Id_Personagem))
                .ForMember(dest => dest.Id_Parceiro, opt => opt.MapFrom(x => x.Id_Parceiro))
                .ForMember(dest => dest.Id_Dimensao, opt => opt.MapFrom(x => x.Id_Dimensao));
        }
    }
}

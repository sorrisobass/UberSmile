using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class DtoToModelMappingPersonagemParceiro : Profile
    {
        public DtoToModelMappingPersonagemParceiro()
        {
            ClienteMap();
        }

        private void ClienteMap()
        {
            CreateMap<PersonagemParceiroDto, PersonagemParceiro>()
                .ForMember(dest => dest.Id_Personagem, opt => opt.MapFrom(x => x.Id_Personagem))
                .ForMember(dest => dest.Id_Parceiro, opt => opt.MapFrom(x => x.Id_Parceiro))
                .ForMember(dest => dest.Id_Dimensao, opt => opt.MapFrom(x => x.Id_Dimensao));
        }
    }
}

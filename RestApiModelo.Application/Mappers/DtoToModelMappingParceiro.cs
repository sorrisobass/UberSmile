using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class DtoToModelMappingParceiro : Profile
    {
        public DtoToModelMappingParceiro()
        {
            ParceiroMap();
        }

        private void ParceiroMap()
        {
            CreateMap<ParceiroDto, Parceiros>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Apelido, opt => opt.MapFrom(x => x.Apelido))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.DataCadastro, opt => opt.Ignore())
                .ForMember(dest => dest.IsAtivo, opt => opt.Ignore());

        }
    }
}

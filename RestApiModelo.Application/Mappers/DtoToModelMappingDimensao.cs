using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class DtoToModelMappingDimensao : Profile
    {
        public DtoToModelMappingDimensao()
        {
            DimensaoMap();
        }

        private void DimensaoMap()
        {
            CreateMap<DimensaoDto, Cidades>()
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Caracteristica, opt => opt.MapFrom(x => x.Caracteristica))
                .ForMember(dest => dest.Altura, opt => opt.MapFrom(x => x.Altura))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(x => x.Longitude))
                .ForMember(dest => dest.Latitude, opt => opt.Ignore());
        }
    }
}

using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class ModelToDtoMappingDimensao : Profile
    {
        public ModelToDtoMappingDimensao()
        {
            DimensaoDtoMap();
        }
        private void DimensaoDtoMap()
        {
            CreateMap<Cidades, DimensaoDto>()
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Caracteristica, opt => opt.MapFrom(x => x.Caracteristica))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(x => x.Longitude))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(x => x.Latitude))
                .ForMember(dest => dest.Altura, opt => opt.MapFrom(x => x.Altura));
        }
    }
}

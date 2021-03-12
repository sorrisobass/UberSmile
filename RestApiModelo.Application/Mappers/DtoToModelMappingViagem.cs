using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class DtoToModelMappingViagem : Profile
    {
        public DtoToModelMappingViagem()
        {
            ViagemMap();
        }

        private void ViagemMap()
        {
            CreateMap<ViagemDto, Viagem>()
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(x => x.Descricao))
                .ForMember(dest => dest.Id_Person_Parc, opt => opt.MapFrom(x => x.Id_Person_Parc))
                .ForMember(dest => dest.Id_Dimensao, opt => opt.MapFrom(x => x.Id_Dimensao))
                .ForMember(dest => dest.Dth_Local, opt => opt.MapFrom(x => x.Dth_Local))
                .ForMember(dest => dest.Dth_Destino, opt => opt.MapFrom(x => x.Dth_Destino));

        }
    }
}

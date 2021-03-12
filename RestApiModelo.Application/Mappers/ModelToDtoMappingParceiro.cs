using AutoMapper;
using RestApiModelo.Application.Dtos;
using RestApiModelo.Domain.Entitys;

namespace RestApiModelo.Application.Mappers
{
    public class ModelToDtoMappingParceiro : Profile
    {

        public ModelToDtoMappingParceiro()
        {
            ParceiroDtoMap();
        }

        private void ParceiroDtoMap()
        {
            CreateMap<Parceiros, ParceiroDto>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Apelido, opt => opt.MapFrom(x => x.Apelido))
                .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(x => x.DataNascimento))
                .ForMember(dest => dest.DataCadastro, opt => opt.MapFrom(x => x.DataCadastro))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email));
        }
    }
}

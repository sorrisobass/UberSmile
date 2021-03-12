using Autofac;
using AutoMapper;
using RestApiModelo.Application;
using RestApiModelo.Application.Interfaces;
using RestApiModelo.Application.Mappers;
using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Services;
using RestApiModelo.Infrastructure.Data.Repositorys;

namespace RestApiModelo.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServicePersonagem>().As<IApplicationServicePersonagem>();
            builder.RegisterType<ApplicationServiceDimensao>().As<IApplicationServiceDimensao>();
            builder.RegisterType<ApplicationServicePersonagemParceiro>().As<IApplicationServicePersonagemParceiro>();
            builder.RegisterType<ApplicationServiceParceiro>().As<IApplicationServiceParceiro>();
            builder.RegisterType<ApplicationServiceViagem>().As<IApplicationServiceViagem>();

            builder.RegisterType<ServicePersonagem>().As<IServicePersonagem>();
            builder.RegisterType<ServiceDimensao>().As<IServiceDimensao>();
            builder.RegisterType<ServiceParceiro>().As<IServiceParceiro>();
            builder.RegisterType<ServicePersonagemParceiro>().As<IServicePersonagemParceiro>();
            builder.RegisterType<ServiceViagem>().As<IServiceViagem>();

            builder.RegisterType<RepositoryPassageiros>().As<IRepositoryPersonagem>();
            builder.RegisterType<RepositoryCidades>().As<IRepositoryDimensao>();
            builder.RegisterType<RepositoryParceiros>().As<IRepositoryParceiro>();
            builder.RegisterType<RepositoryPersonagemParceiro>().As<IRepositoryPersonagemParceiro>();
            builder.RegisterType<RepositoryFormasPagto>().As<IRepositoryViagem>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingPersonagem());
                cfg.AddProfile(new ModelToDtoMappingPersonagem());

                cfg.AddProfile(new DtoToModelMappingDimensao());
                cfg.AddProfile(new ModelToDtoMappingDimensao());

                cfg.AddProfile(new DtoToModelMappingPersonagemParceiro());
                cfg.AddProfile(new ModelToDtoMappingPersonagemParceiro());

                cfg.AddProfile(new DtoToModelMappingParceiro());
                cfg.AddProfile(new ModelToDtoMappingParceiro());

                cfg.AddProfile(new DtoToModelMappingViagem());
                cfg.AddProfile(new ModelToDtoMappingViagem());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}
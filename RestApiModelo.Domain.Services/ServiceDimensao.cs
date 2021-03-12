using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Services
{
    public class ServiceDimensao : ServiceBase<Cidades>, IServiceDimensao
    {
        private readonly IRepositoryDimensao repositoryDimensao;

        public ServiceDimensao(IRepositoryDimensao repositoryDimensao) : base(repositoryDimensao)
        {
            this.repositoryDimensao = repositoryDimensao;
        }
    }
}

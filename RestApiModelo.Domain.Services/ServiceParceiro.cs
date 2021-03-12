using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Services
{
    public class ServiceParceiro : ServiceBase<Parceiros>, IServiceParceiro
    {
        private readonly IRepositoryParceiro repositoryParceiro;

        public ServiceParceiro(IRepositoryParceiro repositoryparceiro) : base(repositoryparceiro)
        {
            this.repositoryParceiro = repositoryparceiro;
        }
    }
}

using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Services
{
    public class ServiceViagem : ServiceBase<Viagem>, IServiceViagem
    { 
        private readonly IRepositoryViagem repositoryViagem;

        public ServiceViagem(IRepositoryViagem repositoryviagem) : base(repositoryviagem)
        {
            this.repositoryViagem = repositoryviagem;
        }
    }
}

using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Services
{
    public class ServicePersonagem : ServiceBase<Passageiros>, IServicePersonagem
    {
        private readonly IRepositoryPersonagem repositoryPersonagem;

        public ServicePersonagem(IRepositoryPersonagem repositoryPersonagem) : base(repositoryPersonagem)
        {
            this.repositoryPersonagem = repositoryPersonagem;
        }
    }
}

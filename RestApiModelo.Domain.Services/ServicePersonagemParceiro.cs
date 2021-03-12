using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Core.Interfaces.Services;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Domain.Services
{
    public class ServicePersonagemParceiro : ServiceBase<PersonagemParceiro>, IServicePersonagemParceiro
    {
        private readonly IRepositoryPersonagemParceiro repositoryPersonagemParceiro;

        public ServicePersonagemParceiro(IRepositoryPersonagemParceiro repositorypersonagemparceiro) : base(repositorypersonagemparceiro)
        {
            this.repositoryPersonagemParceiro = repositorypersonagemparceiro;
        }
    }
}

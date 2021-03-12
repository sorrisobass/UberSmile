using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Infrastructure.Data.Repositorys
{
    public class RepositoryPassageiros : RepositoryBase<Passageiros>, IRepositoryPersonagem
    {
        private readonly SqlContext sqlContext;

        public RepositoryPassageiros(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}

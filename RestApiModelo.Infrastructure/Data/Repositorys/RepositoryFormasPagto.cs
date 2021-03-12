using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Infrastructure.Data.Repositorys
{
    public class RepositoryFormasPagto : RepositoryBase<Viagem>, IRepositoryViagem
    {
        private readonly SqlContext sqlContext;

        public RepositoryFormasPagto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}

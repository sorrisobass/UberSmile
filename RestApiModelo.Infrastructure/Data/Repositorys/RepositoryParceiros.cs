using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Infrastructure.Data.Repositorys
{
    public class RepositoryParceiros : RepositoryBase<Parceiros>, IRepositoryParceiro
    {
        private readonly SqlContext sqlContext;

        public RepositoryParceiros(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}

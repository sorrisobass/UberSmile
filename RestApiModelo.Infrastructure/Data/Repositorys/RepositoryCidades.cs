using RestApiModelo.Domain.Core.Interfaces.Repositorys;
using RestApiModelo.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelo.Infrastructure.Data.Repositorys
{
    public class RepositoryCidades : RepositoryBase<Cidades>, IRepositoryDimensao
    {
        private readonly SqlContext sqlContext;

        public RepositoryCidades(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}

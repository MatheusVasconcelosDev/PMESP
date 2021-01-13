using PMESMP.Domain.Core.Interfaces.Repository;
using PMESP.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMESP.Infrastructure.Data.Repository
{
    public class RepositoryImportacao : RepositoryBase<Planilha>, IRepositoryImportacao
    {
        private readonly SqlContext sqlContext;

        public RepositoryImportacao(SqlContext sqlContext)
            :base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }


       
    }
}

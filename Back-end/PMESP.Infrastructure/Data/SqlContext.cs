using Microsoft.EntityFrameworkCore;
using PMESP.Domain.Entitys;
using System.Linq;

namespace PMESP.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Planilha> Planilhas { get; set; }

    }
}

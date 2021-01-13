using PMESMP.Domain.Core.Interfaces.Repository;
using PMESMP.Domain.Core.Interfaces.Services;
using PMESP.Domain.Entitys;

namespace PMESP.Domain.Services
{
    public class ServiceImportacao : ServiceBase<Planilha>, IServiceImportacao
    {
        private readonly IRepositoryImportacao repositoryImportacao;

        public ServiceImportacao(IRepositoryImportacao repositoryImportacao)
            : base(repositoryImportacao)
        {
            this.repositoryImportacao = repositoryImportacao;
        }
    }
}

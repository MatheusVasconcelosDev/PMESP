using PMESP.Application.DTO;
using System.Collections.Generic;

namespace PMESP.Application.Interfaces
{
    public interface IApplicationServiceImportacao
    {
        void Add(PlanilhaDTO planilhaDTO);

        void Update(PlanilhaDTO planilhaDTO);

        void Remove(PlanilhaDTO planilhaDTO);

        IEnumerable<PlanilhaDTO> GetAll();

        PlanilhaDTO GetById(int id);
    }
}

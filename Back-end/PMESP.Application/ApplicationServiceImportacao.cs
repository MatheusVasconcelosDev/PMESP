using AutoMapper;
using PMESMP.Domain.Core.Interfaces.Services;
using PMESP.Application.DTO;
using PMESP.Application.Interfaces;
using PMESP.Domain.Entitys;
using System;
using System.Collections.Generic;

namespace PMESP.Application
{
    public class ApplicationServiceImportacao : IApplicationServiceImportacao
    {
        private readonly IServiceImportacao serviceImportacao;
        private readonly IMapper mapper;
        public ApplicationServiceImportacao(IServiceImportacao serviceImportacao
                                       ,IMapper mapper)
        {
            this.serviceImportacao = serviceImportacao;
            this.mapper = mapper;
        }
        public void Add(PlanilhaDTO planilhaDTO)
        {
            var dataEntregaDTO = planilhaDTO.DataEntrega.ToString("dd/MM/yyyy HH:mm:ss");
            var dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            if (DateTime.Parse(dataEntregaDTO) <= DateTime.Parse(dataAtual))
            {
                var planilha = mapper.Map<Planilha>(planilhaDTO);
                serviceImportacao.Add(planilha);
            }
           
        }

        public IEnumerable<PlanilhaDTO> GetAll()
        {
            var planilhas = serviceImportacao.GetAll();
            var planilhaDTOs = mapper.Map<IEnumerable<PlanilhaDTO>>(planilhas);

            return planilhaDTOs;
        }

        public PlanilhaDTO GetById(int id)
        {
            var planilha = serviceImportacao.GetById(id);
            var planilhaDTO = mapper.Map<PlanilhaDTO>(planilha);

            return planilhaDTO;
        }

        public void Remove(PlanilhaDTO planilhaDTO)
        {
            var planilha = mapper.Map<Planilha>(planilhaDTO);
            serviceImportacao.Remove(planilha);
        }

        public void Update(PlanilhaDTO planilhaDTO)
        {
            var planilha = mapper.Map<Planilha>(planilhaDTO);
            serviceImportacao.Update(planilha);
        }
    }
}

using PMESP.Application.DTO;
using PMESP.Domain.Entitys;
using AutoMapper;
using System;

namespace PMESP.Application.Mappers
{
    public class DtoToModelMappingPlanilha: Profile
    {
        public DtoToModelMappingPlanilha()
        {
            PlanilhaMap();
        }

        private void PlanilhaMap()
        {
            CreateMap<PlanilhaDTO, Planilha>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.NomeProduto, opt => opt.MapFrom(x => x.NomeProduto))
                .ForMember(dest => dest.Quantidade, opt => opt.MapFrom(x => x.Quantidade))
                .ForMember(dest => dest.DataEntrega, opt => opt.MapFrom(x => x.DataEntrega))
                .ForMember(dest => dest.ValorUnitario, opt => opt.MapFrom(x => x.ValorUnitario));
        }
    }
}

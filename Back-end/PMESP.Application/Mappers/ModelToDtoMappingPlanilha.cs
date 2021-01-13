using AutoMapper;
using PMESP.Application.DTO;
using PMESP.Domain.Entitys;

namespace PMESP.Application.Mappers
{
    public class ModelToDtoMappingPlanilha : Profile
    {
        public ModelToDtoMappingPlanilha()
        {
            PlanilhaDtoMap();
        }

        private void PlanilhaDtoMap()
        {
            CreateMap<Planilha, PlanilhaDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.DataEntrega, opt => opt.MapFrom(x => x.DataEntrega))
                .ForMember(dest => dest.NomeProduto, opt => opt.MapFrom(x => x.NomeProduto))
                .ForMember(dest => dest.Quantidade, opt => opt.MapFrom(x => x.Quantidade))
                .ForMember(dest => dest.ValorUnitario, opt => opt.MapFrom(x => x.ValorUnitario));
        }
    }
}

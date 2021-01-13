using System;

namespace PMESP.Application.DTO
{
    public class PlanilhaDTO: BaseDTO
    {
        public DateTime DataEntrega { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
    }
}
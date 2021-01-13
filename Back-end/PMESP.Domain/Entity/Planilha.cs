using System;

namespace PMESP.Domain.Entitys
{
    public class Planilha : Base
    {
        public DateTime DataEntrega { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
    }
}

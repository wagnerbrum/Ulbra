using System;

namespace TrabalhoG1.Models.Entities
{
    public class ContaLuz : BaseEntity
    {
        public ContaLuz() { }

        public ContaLuz(int id, DateTime dataLeitura, int kwGasto, double valorAPagar, DateTime dataPagamento, double mediaConsumo)
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.kwGasto = kwGasto;
            this.valorAPagar = valorAPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
        }

        public DateTime dataLeitura { get; set; }

        public int kwGasto { get; set; }

        public double valorAPagar { get; set; }

        public DateTime dataPagamento { get; set; }

        public double mediaConsumo { get; set; }
    }
}
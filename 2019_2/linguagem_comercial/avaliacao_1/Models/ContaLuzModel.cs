using System;

namespace avaliacao_1.Models
{
    public class ContaLuzModel
    {
        public ContaLuzModel()
        {
        }

        public ContaLuzModel(DateTime dataLeitura, int kwGasto, decimal valorAPagar, DateTime dataPagamento, decimal mediaConsumo)
        {
            this.dataLeitura = dataLeitura;
            this.kwGasto = kwGasto;
            this.valorAPagar = valorAPagar;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
        }

        public int id { get; set; }
        public DateTime dataLeitura { get; set; }
        public int kwGasto { get; set; }
        public decimal valorAPagar { get; set; }
        public DateTime dataPagamento { get; set; }
        public decimal mediaConsumo { get; set; }
    }
}
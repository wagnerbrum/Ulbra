using System;

namespace aula03_exercicio
{
    public class Reservas
    {
        public Reservas(DateTime dataReservada, DateTime dataValidade, Materiais material)
        {
            this.dataReservada = dataReservada;
            this.dataValidade = dataValidade;
            this.material = material;
        }

        public DateTime dataReservada { get; private set; }

        public DateTime dataValidade { get; private set; }

        public Materiais material { get; private set; }

        public bool Criar()
        {
            return true;
        }

        public bool Cancelar()
        {
            return true;
        }
    }
}
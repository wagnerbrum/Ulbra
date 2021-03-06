using System;
using System.Collections.Generic;
using System.Linq;

namespace avaliacao_1.Models
{
    public class ContaLuzRepository
    {
        public static int _autoIncrement = 1;
        public static int count = 0;
        public List<ContaLuzModel> contasLuz = new List<ContaLuzModel>();

        public ContaLuzRepository()
        {
            // DateTime dataLeitura, int kwGasto, decimal valorAPagar, DateTime dataPagamento, decimal mediaConsumo
            this.CreateContaLuz(new ContaLuzModel(
                new DateTime(2019, 04, 10),
                100,
                (decimal) 150.50,
                new DateTime(2019, 05, 05),
                100
            ));

            this.CreateContaLuz(new ContaLuzModel(
                new DateTime(2019, 05, 09),
                120,
                (decimal) 250,
                new DateTime(2019, 06, 06),
                120
            ));

            this.CreateContaLuz(new ContaLuzModel(
                new DateTime(2019, 06, 10),
                90,
                (decimal) 80.5,
                new DateTime(2019, 07, 09),
                90
            ));
        }

        public void CreateContaLuz(ContaLuzModel contaLuzModelo)
        {
            contaLuzModelo.id = ContaLuzRepository._autoIncrement++;
            contasLuz.Add(contaLuzModelo);
            ContaLuzRepository.count++;
        }

        public void UpdateContaLuz(ContaLuzModel contaLuzModelo)
        {
            int index = contasLuz.FindIndex(cont => cont.id == contaLuzModelo.id);
            contasLuz[index].dataLeitura = contaLuzModelo.dataLeitura;
            contasLuz[index].kwGasto = contaLuzModelo.kwGasto;
            contasLuz[index].valorAPagar = contaLuzModelo.valorAPagar;
            contasLuz[index].dataPagamento = contaLuzModelo.dataPagamento;
            contasLuz[index].mediaConsumo = contaLuzModelo.mediaConsumo;
        }

        public ContaLuzModel GetContaLuz(int id)
        {
            ContaLuzModel _contaLuz = contasLuz.Find(cont => cont.id == id);
            return _contaLuz;
        }

        public List<ContaLuzModel> GetAllContaLuz()
        {
            return contasLuz;
        }

        public void DeleteContaLuz(int id)
        {
            contasLuz.Remove(contasLuz.Find(cont => cont.id == id));
        }

        public ContaLuzModel menorConsumo()
        {
            // contasLuz.OrderBy(cont => cont.kwGasto).First();
            // contasLuz.OrderByDescending(cont => cont.kwGasto).Last();
            return contasLuz.Find(cont => cont.kwGasto == contasLuz.Min(conta => conta.kwGasto));
        }

        public ContaLuzModel maiorConsumo()
        {
            // contasLuz.OrderBy(cont => cont.kwGasto).Last();
            // contasLuz.OrderByDescending(cont => cont.kwGasto).First();
            return contasLuz.Find(cont => cont.kwGasto == contasLuz.Max(conta => conta.kwGasto));
        }
    }
}
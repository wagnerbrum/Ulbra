using System;
using System.Collections.Generic;
using avaliacao_1.Models;

// ContaLuzViewModel

namespace avaliacao_1.Models
{
    public class ContaLuzViewModel
    {
        public ContaLuzViewModel(ContaLuzRepository _listaContaLuz)
        {
            this.listaContasLuz = _listaContaLuz.GetAllContaLuz();
            this.maiorConsumo = _listaContaLuz.maiorConsumo();
            this.menorConsumo = _listaContaLuz.menorConsumo();
        }

        public IEnumerable<ContaLuzModel> listaContasLuz { get; set; }

        public ContaLuzModel maiorConsumo { get; set; }

        public ContaLuzModel menorConsumo { get; set; }
    }
}
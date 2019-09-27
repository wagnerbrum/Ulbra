using System.Collections.Generic;
using TrabalhoG1.Models.Entities;

namespace TrabalhoG1.Models.Interfaces
{
    public interface IContaLuzRepository : IRepository<ContaLuz>
    {
        ContaLuz GetMenorConsumo();
        ContaLuz GetMaiorConsumo();
    }
}
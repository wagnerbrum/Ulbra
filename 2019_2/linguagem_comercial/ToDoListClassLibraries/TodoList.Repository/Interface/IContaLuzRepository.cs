using System.Collections.Generic;
using TodoList.Domain.Entity;

namespace TodoList.Repository.Interface
{
    public interface IContaLuzRepository : IRepository<ContaLuz>
    {
        ContaLuz GetMenorConsumo();
        ContaLuz GetMaiorConsumo();
    }
}
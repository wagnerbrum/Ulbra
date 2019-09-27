using System.Collections.Generic;
using TrabalhoG1.Models.Entities;

namespace TrabalhoG1.Models.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        List<T> Get();
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
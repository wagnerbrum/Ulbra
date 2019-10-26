using System.Collections.Generic;
using TodoList.Domain.Entity;

namespace TodoList.Repository.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
using Microsoft.EntityFrameworkCore;
using TodoList.Domain.Entity;

namespace TodoList.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<ContaLuz> ContasLuz { get; set; }
    }
}
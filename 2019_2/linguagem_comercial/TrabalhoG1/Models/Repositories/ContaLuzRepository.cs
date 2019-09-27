using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TrabalhoG1.Context;
using TrabalhoG1.Models.Entities;
using TrabalhoG1.Models.Interfaces;

namespace TrabalhoG1.Models.Repositories
{
    public class ContaLuzRepository : IRepository<ContaLuz>
    {
        private DataContext context;

        public ContaLuzRepository(DataContext context)
        {
            this.context = context;
        }

        public ContaLuz Get(int id)
        {
            return context.ContasLuz.SingleOrDefault(x => x.id == id);
        }

        public List<ContaLuz> Get()
        {
            return context.ContasLuz.ToList();
        }

        public void Insert(ContaLuz contaLuz)
        {
            context.ContasLuz.Add(contaLuz);
            context.SaveChanges();
        }

        public void Update(ContaLuz contaLuz)
        {
            context.Entry(contaLuz).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.ContasLuz.Remove(Get(id));
            context.SaveChanges();
        }
    }
}
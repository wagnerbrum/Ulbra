using System.Collections.Generic;

namespace APITodo.Domain
{
    public class ToDo
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public List<Item> items { get; set; }
    }
}
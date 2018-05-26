using System.Collections.Generic;

namespace Modulo2.Models
{
    public enum Status
    {
        Ok,
        Error
    }

    public class Item
    {
        public string Name { get; set; }
        public Status Status { get; set; }

        public Item() { }
        public Item(string name, Status status)
        {
            this.Name = name;
            this.Status = status;
        }

        public static List<Item> GetItems()
        {
            return new List<Item>
            {
                new Item("Item 1", Status.Error),
                new Item("Item 2", Status.Ok),
                new Item("Item 3", Status.Ok),
                new Item("Item 4", Status.Error)
            };
        }
    }
}

using System.Collections.Generic;
using System;


namespace Bakery.Models
{
    public class Order
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }

        private static List<Order> _instances = new List<Order> { };

        public Order(string title, string description, int price, string date)
        {
            Id = _instances.Count;
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            _instances.Add(this);
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static Order Find(int id)
        {
            return _instances[id - 1];
        }
    }
}
using System.Collections.Generic;

namespace Bakery.Models
{
    public class OrderList
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public int Price { get; set; }
      public string Date { get; set; }
      private static List<OrderList> _instances = new List<OrderList> {};

    public OrderList (string title, string description, int price, string date)
    {
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

    public static List<OrderList> GetAll()
    {
      return _instances;
    }
    }

    }
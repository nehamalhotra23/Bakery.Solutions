using System.Collections.Generic;

namespace Bakery.Models
{
    public class VendorList
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<VendorList> instances = new List<VendorList> {};

    public VendorList (string name, string description)
    {
        Name = name;
        Description = description;
        instances.Add(this);
    }

     public static void ClearAll()
    {
      instances.Clear();
    }

    public static List<VendorList> GetAll()
    {
      return instances;
    }

    }
    // public class Order
    // {
    //     public string Title { get; set; }
    //     public string Description { get; set; }
    //     public int Price { get; set; }
    //     public string Date { get; set; }
    //     private static List<OrderList> _instances = new List<OrderList> {};

    // public Order (string title, string description, int price, string date)
    // {
    //     Title = title;
    //     Description = description;
    //     Price = price;
    //     Date = date;
    //     _instances.Add(this);
    // }

    //  public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    // public static List<OrderList> GetAll()
    // {
    //   return _instances;
    // }

    }




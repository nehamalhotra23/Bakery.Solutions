using System.Collections.Generic;

namespace Bakery.Models
{
    public class VendorList
    {
        private static List<VendorList> _instances = new List<VendorList> {};
        public string Name { get; set; }
        public string Description { get; set; }
        

    public VendorList (string name, string description)
    {
        Name = name;
        Description = description;
        _instances.Add(this);
       
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<VendorList> GetAll()
    {
      return _instances;
    }

    }

     public class Order
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public int Price { get; set; }
      public string Date { get; set; }
      private static List<Order> _instances = new List<Order> {};

    public Order (string title, string description, int price, string date)
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

    public static List<Order> GetAll()
    {
      return _instances;
    }
    }

    }

    







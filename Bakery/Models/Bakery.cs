using System.Collections.Generic;

namespace Bakery.Models
{
    public class VendorList
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        private static List<VendorList> _instances = new List<VendorList> {};
          

    public VendorList (string name, string description)
    {
        Name = name;
        Description = description;
        _instances.Add(this);
        Id = _instances.Count;
        
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<VendorList> GetAll()
    {
      return _instances;
    }
    public static VendorList Show(int search)
    {
      return _instances[search - 1];
    }

}

    public class Order
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public int Price { get; set; }
      public string Date { get; set; }
      public static List<Order> instances = new List<Order> {};

    public Order (string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      instances.Add(this);
    }
    public static void ClearAll()
    {
      instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return instances;
    }
  }
}

    







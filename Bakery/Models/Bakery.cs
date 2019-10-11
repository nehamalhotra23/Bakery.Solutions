using System.Collections.Generic;

namespace Bakery.Models
{
    public class VendorList
    {
        public string Name { get; set; }
        public string Description { get; set; }
    
        private static List<VendorList> _instances = new List<VendorList> {};

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

    

}





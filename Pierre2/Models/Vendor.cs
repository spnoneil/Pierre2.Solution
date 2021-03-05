using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; private set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

  }
}
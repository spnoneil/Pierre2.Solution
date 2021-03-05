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
      
    }

  }
}
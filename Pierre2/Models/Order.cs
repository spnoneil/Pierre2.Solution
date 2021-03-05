using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order 
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; private set; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string title, string desc, int price, string date)
    {
      OrderTitle = title;
      OrderDescription = desc;
      OrderPrice = price;
      OrderDate = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }


}
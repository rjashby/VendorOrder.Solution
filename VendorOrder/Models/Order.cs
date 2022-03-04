using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
 

    private static List<Order> _orders = new List<Order> {};
    public Order (string title)
    {
      Title = title;
      _orders.Add(this);
  
    }
    
    public Order (string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;

    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }
  }
}
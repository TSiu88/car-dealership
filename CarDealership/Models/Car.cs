using System;

namespace CarDealership.Models
{
  public class Item
  {
    public string Property { get; set; }
    public Item(string property)
    {
      Property = property;
    }
  }
}
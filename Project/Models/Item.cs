using System;

namespace ProjectName.Models
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
using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Description { get; set; }
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    private static List<Car> _instances = new List<Car> {};
    public Car(string description, string makeModel, int price, int miles)
    {
      Description = description;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
     }
    public bool WorthBuying(int maxPrice, int miles)
    {
      if((Price < maxPrice) && (Miles < miles)) {
        return true;
      } else {
        return false;
      }
    }
  }
}
using System;

namespace CarDealership.Models
{
  public class Car
  {
    public string Description { get; set; }
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public Car(string description, string makeModel, int price, int miles)
    {
      Description = description;
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }
  }
}
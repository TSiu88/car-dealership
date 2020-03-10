using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;
using System.Web;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/search")]
    public ActionResult Search()
    {
      return View();
    }

    [HttpGet("/add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/add")]
    public ActionResult Add(string description, string makeModel, int price, int miles)
    {
      Car newCar = new Car(description, makeModel, price, miles);
      return RedirectToAction("Index");
    }

    [HttpPost("/results")]
    public ActionResult Results(string maxPrice, string maxMiles)
    {
      List<Car> CarsMatchingSearch = new List<Car>(0);
      foreach (Car automobile in Car.GetAll())
      {
        if (automobile.WorthBuying(int.Parse(maxPrice), int.Parse(maxMiles)))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      return View(CarsMatchingSearch);
    }

  }
}
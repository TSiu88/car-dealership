using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult HomePage() {
      Item myItem = new Item("property");
      myItem.Property = "Lina";
      return View(myItem);
    }
  }
}
using Microsoft.AspNetCore.Mvc;
using Triangle.Models;
using System;

namespace Triangle.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View();
      }
      [Route("/triangle/result")]
      public ActionResult Result()
      {

      try {
        Measurements sides = new Measurements(Request.Form["side-one"],Request.Form["side-two"],Request.Form["side-three"]);
        sides.TriangleCalc();
        return View(sides);
      } catch (Exception) {
        return View(null);
      }
      }
    }
}

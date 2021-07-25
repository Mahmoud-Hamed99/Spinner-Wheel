using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spinner_Wheel_2.Controllers
{
    public class HomeController : Controller
    {
        List<string> giftsArray = new List<string>() { "a", "a", "a", "a", "a", "b", "b", "b" };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

//            int index = getRandomGift();
  //          ViewBag.RI = index;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public int getRandomGift()
        {
            Random random = new Random();

            return random.Next(0, giftsArray.Count - 1);
        }
    }
}
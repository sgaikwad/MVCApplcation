using MvcApplicationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var restaurant = RestaurantData.GetRestaurants();
            return View(restaurant);
        }

        public ActionResult About()
        {

            var aboutModel = new AboutModel();
            aboutModel.Name = "Sachin Dattatraya Gaikwad";
            aboutModel.Location = "Pune";

            var view = View(aboutModel);

            return view;

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search(string name)
        {

            return Content("Employee");
        }
    }
}

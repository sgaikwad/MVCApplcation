using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MvcApplicationDemo.Models;

namespace MvcApplicationDemo.Controllers
{
    public class ReviewsController : Controller
    {
        //
        // GET: /Reviews/

        public ActionResult Index()
        {
            var _reviews = ReviewsData._reviews;

            var model = from r in _reviews
                        orderby r.Rating descending
                        select r;

            return View(model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            var _reviews = ReviewsData._reviews;
            var review = _reviews.Find(x => x.Id == id);
            return View(review);
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(RestaurantReview model)
        {

            if (ModelState.IsValid)
            {
                var id = from r in ReviewsData._reviews
                         orderby r.Id descending
                         select r.Id;
                ReviewsData._reviews.Add(new RestaurantReview
                {
                    Id = id.First() + 1,
                    City = model.City,
                    Country = model.Country
                });
                return RedirectToAction("Index", new { id = id.First() + 1 });
            }
            return View(model);
        }

        //
        // GET: /Reviews/Edit/5

        public ActionResult Edit(int id)
        {
            var _reviews = ReviewsData._reviews;
            var model = _reviews.Single(r => r.Id == id);
            return View(model);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var _reviews = ReviewsData._reviews;
                var review = _reviews.Single(r => r.Id == id);

                if (TryUpdateModel(review))
                {
                    return RedirectToAction("Index");
                }
                return View(review);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




    }
}

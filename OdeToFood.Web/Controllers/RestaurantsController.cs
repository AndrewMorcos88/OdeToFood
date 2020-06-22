using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IResturantData db;

        public RestaurantsController(IResturantData db)
        {
            this.db = db;
        }

        // GET: Restaurants
        public ActionResult Index()
        {

            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Restaurant restaurant)
        {
        
            if (ModelState.IsValid)
            {
                db.Add(restaurant);

                return RedirectToAction("Details",new {id = restaurant.ID });

            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);

            if (model==null)
            {
                return View("NotFound");

            }

            return View(model);



        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Restaurant restaurant)
        {
            if (ModelState.IsValid )
            {
                db.Update(restaurant);
                return RedirectToAction("Details", new { id = restaurant.ID });
            }
            return View(restaurant);
        }
    }
}
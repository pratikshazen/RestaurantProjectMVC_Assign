using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantProjectMVC.Models;

namespace RestaurantProjectMVC.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            List<Restaurant> restaurant = new List<Restaurant>
            {
                new Restaurant(){Id=1, Name="ThePizzaPoint", Type =CuisineType.Italian},
                new Restaurant(){Id=2, Name="Burger King", Type =CuisineType.French},
                new Restaurant(){Id=3, Name="Cafe Dream", Type =CuisineType.Indian},
                new Restaurant(){Id=4, Name="Food Mania", Type =CuisineType.None}

            };
            return View(restaurant);


        }

        public ActionResult Image()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            List<Restaurant> restaurant = new List<Restaurant>
            {
                new Restaurant(){Id=1, Name="ThePizzaPoint", Type =CuisineType.Italian},
                new Restaurant(){Id=2, Name="Burger King", Type =CuisineType.French},
                new Restaurant(){Id=3, Name="Cafe Dream", Type =CuisineType.Indian},
                new Restaurant(){Id=4, Name="Food Mania", Type =CuisineType.None}

            };
            Restaurant reqdRestaurant = null;
            foreach (var item in restaurant)
            {
                if (item.Id == id)
                {
                    reqdRestaurant = item;
                }

            }
            ViewBag.ReqdRestaurant = reqdRestaurant;
            return View();

        }
    }
}
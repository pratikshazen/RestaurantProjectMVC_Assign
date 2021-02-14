using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantProjectMVC.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CuisineType Type { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplicationDemo.Models
{
    public class RestaurantData
    {

        public static List<Restaurant> GetRestaurants()
        {
            List<Restaurant> _restaurantModels = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Taj",
                    Address = "Gate way of india",
                    City = "Mumbai",
                    Country = "India"
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Hyyat",
                    Address = "Viman Nagar",
                    City = "Pune",
                    Country = "India"
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Invitation",
                    Address = "Viman Nagar",
                    City = "Pune",
                    Country = "India"
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "Kaveri",
                    Address = "Wagholi",
                    City = "Pune",
                    Country = "India"
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "Sayaji",
                    Address = "Wakad",
                    City = "Pune",
                    Country = "India"
                }
            };

            return _restaurantModels;
        }

    }
}
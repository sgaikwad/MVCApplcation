using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplicationDemo.Models
{
    public class ReviewsData
    {

        public static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview
            {
                Id = 1,
                City = "Pune",
                Country = "India",
                Name = "Hyatt",
                Rating = 5
            },
            new RestaurantReview
            {
                Id = 2,
                City = "Nasik",
                Country = "India",
                Name = "Raj",
                Rating = 4
            },
            new RestaurantReview
            {
                Id = 3,
                City = "Mumbai",
                Country = "India",
                Name = "Taj",
                Rating = 5
            }
        };
    }
}
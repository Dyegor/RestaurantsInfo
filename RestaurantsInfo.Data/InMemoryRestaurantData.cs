using RestaurantsInfo.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantsInfo.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> Restaurants;

        public InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pyrenees", Location = "St. Lukes", CuisineType = Restaurant.Cuisine.French }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in Restaurants
                   orderby r.Name
                   select r;
        }
    }
}

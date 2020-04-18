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
                new Restaurant { Id = 1, Name = "Pyrenees", Location = "St. Lukes", CuisineType = Restaurant.Cuisine.French },
                new Restaurant { Id = 2, Name = "Block  Cafe", Location = "Blockhouse Bay", CuisineType = Restaurant.Cuisine.None },
                new Restaurant { Id = 3, Name = "Goode Brothers", Location = "New Lynn", CuisineType = Restaurant.Cuisine.Italian }
            };
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name)
        {
            return from r in Restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}

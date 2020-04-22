using RestaurantsInfo.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantsInfo.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pyrenees", Location = "St. Lukes", CuisineType = Restaurant.Cuisine.French },
                new Restaurant { Id = 2, Name = "Block  Cafe", Location = "Blockhouse Bay", CuisineType = Restaurant.Cuisine.None },
                new Restaurant { Id = 3, Name = "Goode Brothers", Location = "New Lynn", CuisineType = Restaurant.Cuisine.Italian }
            };
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant Delete(int Id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == Id);
            if(restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.CuisineType = updatedRestaurant.CuisineType;
            }
            return restaurant;
        }
    }
}

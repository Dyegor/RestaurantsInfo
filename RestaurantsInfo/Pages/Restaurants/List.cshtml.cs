using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RestaurantsInfo.Core;
using RestaurantsInfo.Data;

namespace RestaurantsInfo.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public readonly IConfiguration config;
        public readonly IRestaurantData restaurantData;

        [BindProperty(SupportsGet = true)]
        public String SearchTerm { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet(string searchTerm)
        {
            Restaurants = restaurantData.GetRestaurantByName(SearchTerm);
        }
    }
}

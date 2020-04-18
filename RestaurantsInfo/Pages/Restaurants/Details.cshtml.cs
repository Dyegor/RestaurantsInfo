using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantsInfo.Core;
using RestaurantsInfo.Data;

namespace RestaurantsInfo.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        public Restaurant Restaurant { get; set; }

        public DetailsModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public void OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
        }
    }
}

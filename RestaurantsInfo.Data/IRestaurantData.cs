﻿using RestaurantsInfo.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantsInfo.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
        Restaurant GetById(int id);
        Restaurant update(Restaurant updatedRestaurant);
        int Commit();
    }
}

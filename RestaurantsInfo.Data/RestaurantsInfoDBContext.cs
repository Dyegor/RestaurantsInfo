using Microsoft.EntityFrameworkCore;
using RestaurantsInfo.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantsInfo.Data
{
    public class RestaurantsInfoDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public RestaurantsInfoDBContext(DbContextOptions<RestaurantsInfoDBContext> options) :base(options)
        {

        }
    }
}

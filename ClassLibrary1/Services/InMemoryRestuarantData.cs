using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestuarantData : IResturantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestuarantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {ID=1,Name="AndrewPizza",Cuisine=CuisineTybe.Egyption},
                new Restaurant {ID=2,Name="BavlyPizza",Cuisine=CuisineTybe.Indian},
                new Restaurant {ID=3,Name="Macdonalds",Cuisine=CuisineTybe.Egyption},
                new Restaurant {ID=1,Name="AndrewPizza",Cuisine=CuisineTybe.American}
            }; 

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=>r.Name);
        }
    }
}

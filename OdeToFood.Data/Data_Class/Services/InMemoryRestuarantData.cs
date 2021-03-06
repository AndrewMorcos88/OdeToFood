﻿using OdeToFood.Data.Models;
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
                new Restaurant {ID=4,Name="papa jones",Cuisine=CuisineTybe.American}
            }; 

        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.ID == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=>r.Name);
        }

       public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.ID = restaurants.Max(r => r.ID) + 1;

        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.ID);

            if (existing!=null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;

            }

        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }
    }
}

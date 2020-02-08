using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
  public interface IRestaurantData
  {
    IEnumerable<Restaurant> GetAll();

  }

  public class InMemeoryRestaurantData : IRestaurantData
  {
    List<Restaurant> restaurants;

    public InMemeoryRestaurantData()
    {
      restaurants = new List<Restaurant>()
      {
          new Restaurant { Id = 1, Name = "Jason's Pizza", Location = "Washington", Cuisine = CuisineType.Italian },
          new Restaurant { Id = 2, Name = "Cinnamon Club", Location = "London", Cuisine = CuisineType.Italian },
          new Restaurant { Id = 3, Name = "La Costa", Location = "California", Cuisine = CuisineType.Mexican },
          new Restaurant { Id = 4, Name = "Peanut Sauce", Location = "Missouri", Cuisine = CuisineType.Indian },
      };
    }

    public IEnumerable<Restaurant> GetAll()
    {
      return from r in restaurants
             orderby r.Name
             select r;
    }
  }
}

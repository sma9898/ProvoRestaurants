using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{

    //For storing list of user-submitted restaurants
    public static class Storage //Added "static" for ease of access
    {
        private static List<UserRestaurant> restaurants = new List<UserRestaurant>();

        public static IEnumerable<UserRestaurant> Restaurants => restaurants;

        public static void AddRestaurant(UserRestaurant restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}

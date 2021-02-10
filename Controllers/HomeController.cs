using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoRestaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    

        //Landing page displaying the top 5 restaurants
        [HttpGet] //[HttpGet("List")]
        public IActionResult Index()
        {
            //int[] nums = { 524, 693, 512 }; //Array of integers
            //return View("Index", nums); //Pass nums variable into Index page

            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                int? rank = r.RestaurantRank - 1 ?? 999;

                //If no favorite dish listed, default to "It's all tasty!"
                string favoriteDish = r.FavoriteDish ?? "It's all tasty!";

                //If no website listed, default to "Coming soon."
                string restaurantWebsite = r.RestaurantWebsite ?? "Coming soon.";

                //Add formatted information to the list
                restaurantList.Add($"#{r.RestaurantRank}: {r.RestaurantName} <br>Favorite Dish: {r.FavoriteDish} <br>Address: {r.RestaurantAddress} <br>Phone Number: {r.RestaurantPhone} <br>Website: {r.RestaurantWebsite}"); //One way to format output
                //restaurantList.Add(string.Format("#{0}: {1}", r.RestaurantRank, r.RestaurantName)); //Another way to format output
            }

            return View(restaurantList);
        }

        //View user input Submit page
        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        //Submitting user restaurant input
        [HttpPost]
        public IActionResult Submit(UserRestaurant response)
        {
            //Check validation
            if (ModelState.IsValid)
            {
                //Add to list of restaurant objects
                Storage.AddRestaurant(response);
                //Go to confirmation page
                return View("Confirmation");
            }
            else
            {
                //Don't leave the page if responses are invalid
                return View();
            }
        }

        //Display the user-submitted restaurants
        public IActionResult SubmissionsList()
        {
            //Return array of restaurants
            return View(Storage.Restaurants);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

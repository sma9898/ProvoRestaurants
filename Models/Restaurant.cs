using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{
    public class Restaurant
    {
        //Constructors
        public Restaurant(int rank)
        {
            RestaurantRank = rank; //Sets rank value, making it read only
        }

        //Properties
        //public string SubmitterName { get; set; } //Name of person who submitted restaurant information
        [Required]
        public int? RestaurantRank { get; } //Read only. Uses constructor to set rank value
        //public int? RestaurantRank { get; set; } = 999; //Rank number, defaults to 999
        [Required]
        public string RestaurantName { get; set; } //Name of restaurant
        public string FavoriteDish { get; set; } = "It's all tasty!"; //Favorite dish from restaurant
        [Required]
        public string RestaurantAddress { get; set; } = "Coming soon."; //Address of restaurant. Default is "Coming soon."
        
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression]
        public string RestaurantPhone { get; set; } //Phone number of restaurant
        public string RestaurantWebsite { get; set; } = "Coming soon."; //Link to website for restaurant


        //Methods
        public static Restaurant[] GetRestaurants() //Method to return array of restaurants
        {
            //Fill in data for my Top 5 restaurants
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Texas Roadhouse",
                FavoriteDish = "Fresh rolls",
                RestaurantAddress = "1265 S State St, Orem, UT",
                RestaurantPhone = "(801) 226-2742"
                //RestaurantWebsite = "https://www.texasroadhouse.com/locations/utah/orem"
            };
            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Tucanos",
                FavoriteDish = "Pão de queijo",
                RestaurantAddress = "545 E University Pkwy, Provo, UT",
                RestaurantPhone = "(801) 224-4774",
                RestaurantWebsite = "https://www.tucanos.com/location/orm"
            };
            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Pizza Pie Cafe",
                FavoriteDish = "Oreo pizza",
                RestaurantAddress = "2235 N University Pkwy, Provo, UT",
                RestaurantPhone = "(801) 373-5561",
                RestaurantWebsite = "https://pizzapiecafe.co/restaurant-locations/provo/"
            };
            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Subway",
                FavoriteDish = "Black forest ham on Italian herbs and cheese",
                RestaurantAddress = "1220 N 900 E Provo, UT",
                RestaurantPhone = "(801) 377-3739",
                RestaurantWebsite = "https://restaurants.subway.com/united-states/ut/provo/1220-n-900-e"
            };
            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Krispy Kreme",
                //FavoriteDish = "Doughnuts",
                RestaurantAddress = "417 W 1300 S Orem, UT",
                RestaurantPhone = "(801) 222-9995",
                RestaurantWebsite = "https://www.krispykreme.com/location/orem"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 }; //Return array of restaurants
        }

    }
}

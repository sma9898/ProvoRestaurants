using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{
    public class UserRestaurant
    {


        //Properties
        public string SubmitterName { get; set; } //Name of person who submitted restaurant information
        [Required]
        public string RestaurantName { get; set; } //Name of restaurant
        public string FavoriteDish { get; set; } //Favorite dish from restaurant

        //[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
        public string RestaurantPhone { get; set; } //Phone number of restaurant


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment7.Models
{
    //Data Annotations [Required] etc. https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-6
    public class Listing
    {
        public int ListingID { get; set; }

        [Required(ErrorMessage = "Please enter the listing name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a zip code")]
        public string ZipCode { get; set; }
    }
}

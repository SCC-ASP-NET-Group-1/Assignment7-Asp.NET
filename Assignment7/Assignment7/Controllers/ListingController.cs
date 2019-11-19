using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment7.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assignment7.Controllers
{
    public class ListingController : Controller
    {
        private IListingRepository repository;

        public ListingController(IListingRepository repo)
        {
            repository = repo;
        }

        //[Authorize]
        public IActionResult addListing()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUserListing(Listing listing)
        {
            if(ModelState.IsValid)
            {
                repository.Add(listing);
                return View("AllListings", repository.Listings);
            }
            else
            {
                return View("addListing");
            }


        }


        public ViewResult AllListings() => View(repository.Listings);

        public ViewResult ViewListing() => View(repository.Listings);
    }
}
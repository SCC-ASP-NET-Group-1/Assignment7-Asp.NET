using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment7.Models;
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

        public ViewResult AllListings() => View(repository.Listings);
    }
}
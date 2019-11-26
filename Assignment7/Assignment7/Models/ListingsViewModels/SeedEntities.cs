using Assignment7.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment7.Models
{
    public static class SeedEntities
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Listings.Any())
            {
                context.Listings.AddRange(
                    new Listing
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Price = 15.67m,
                        Username = "mikeyd2017",
                        ZipCode = "68505"
                    },
                    new Listing
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Price = 22.34m,
                        Username = "mikeyd2017",
                        ZipCode = "68505"
                    },
                    new Listing
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Price = 23.12m,
                        Username = "mikeyd2017",
                        ZipCode = "68505"
                    },
                    new Listing
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Price = 5.40m,
                        Username = "mikeyd2017",
                        ZipCode = "68505"
                    },
                    new Listing
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Price = 80000.43m,
                        Username = "mikeyd2017",
                        ZipCode = "68505"
                    },
                    new Listing
                    {
                        Name = "Thinking Cap",
                        Description = "A cap designed for thinking",
                        Price = 150.43m,
                        Username = "mikeyd2017",
                        ZipCode = "68505"
                    });
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment7.Data;

namespace Assignment7.Models
{
    public class EFListingRepository : IListingRepository
    {
        private ApplicationDbContext context;

        public EFListingRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Listing> Listings => context.Listings;
    }
}

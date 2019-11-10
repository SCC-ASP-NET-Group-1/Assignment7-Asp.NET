using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment7.Models
{
    public interface IListingRepository
    {
        IQueryable<Listing> Listings { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities.Core
{
    public class City : BaseEntity
    {
        public required string Name { get; set; }
        public int Population {  get; set; }
        public string? Description { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public ICollection<CityDestination>? Destinations { get; set; }
    }
}

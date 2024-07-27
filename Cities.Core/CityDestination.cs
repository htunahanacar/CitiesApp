﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities.Core
{
    public class CityDestination : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}

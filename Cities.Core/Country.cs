﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities.Core
{
    public class Country : BaseEntity
    {
        public required string Name { get; set; }
        public string? CountryCode { get; set; }
        public string? FlagUrl { get; set; }
        public string? Continent { get; set; }
    }
}

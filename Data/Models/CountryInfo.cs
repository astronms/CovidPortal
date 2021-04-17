using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidPortal.Data.Models
{
    public class CountryInfo
    {
        public int? Id { get; set; }
        public string Country { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
        public string Flag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidPortal.Data.Models
{
    public class AllCountryHistoricalModel
    {
        public Dictionary<string, long> cases { get; set; }
        public Dictionary<string, long> deaths { get; set; }
        public Dictionary<string, long> recovered { get; set; }
    }
}

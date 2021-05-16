using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidPortal.Data.Models
{
    public class AllCountriesModel
    {
        public long updated { get; set; }
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int recovered { get; set; }
        public int todayRecovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }
        public int casesPerOneMillion { get; set; }
        public float deathsPerOneMillion { get; set; }
        public long tests { get; set; }
        public float testsPerOneMillion { get; set; }
        public long population { get; set; }
        public int oneCasePerPeople { get; set; }
        public int oneDeathPerPeople { get; set; }
        public int oneTestPerPeople { get; set; }
        public float activePerOneMillion { get; set; }
        public float recoveredPerOneMillion { get; set; }
        public float criticalPerOneMillion { get; set; }
        public int affectedCountries { get; set; }

    }
}

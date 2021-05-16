using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidPortal.Data;
using CovidPortal.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidPortal.Pages
{
    public class TotalModel : PageModel
    {
        public Data.Models.AllCountriesModel AllCountriesModel { get; set; }
        public Data.Models.AllCountryHistoricalModel AllCountryHistoricalModel { get; set; }

        public void OnGet()
        {
            AllCountriesModel = LoadData().Result;
            AllCountryHistoricalModel = LodaHistoricalData().Result;
        }

        private async Task<Data.Models.AllCountriesModel> LoadData()
        {
            return await DataProcessor.LoadDataForAllCountries();
        }

        private async Task<Data.Models.AllCountryHistoricalModel> LodaHistoricalData()
        {
            return await DataProcessor.LoadHistoricalDataForAllCountry();
        }
}
}

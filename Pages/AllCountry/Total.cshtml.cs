using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidPortal.Pages.AllCountry
{
    public class TotalModel : PageModel
    {
        public Data.Models.AllCountriesModel AllCountriesModel { get; set; }
        public void OnGet()
        {
            AllCountriesModel = LoadData().Result;
        }

        private async Task<Data.Models.AllCountriesModel> LoadData()
        {
            return await DataProcessor.LoadDataForAllCountries();
        }
    }
}

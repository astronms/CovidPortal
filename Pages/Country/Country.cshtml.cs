using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidPortal.Pages.Country
{
    public class CountryModel : PageModel
    {
        public CountryModel()
        {
            Countries = CountriesData.CountriesDictionary;
        }
        public Data.Models.CountryModel CountryData { get; set; }
        public Dictionary<string,string> Countries { get; set; }
        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CountryData = LoadData("PL").Result;

            return Page();
        }


        private async Task<Data.Models.CountryModel> LoadData(string countryCode)
        {
            return await DataProcessor.LoadDataForCountry(countryCode);
        }
    }
}

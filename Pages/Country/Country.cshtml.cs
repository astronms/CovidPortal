using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidPortal.Pages
{
    public class CountryModel : PageModel
    {
        public Data.Models.CountryModel CountryData { get; set; }
        public Dictionary<string, string> Countries { get; set; }
        public string SelectedCountry { get; set; }
        public CountryModel()
        {
            Countries = CountriesData.CountriesDictionary;
        }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost(string selectedCountry)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SelectedCountry = selectedCountry;
            CountryData = LoadData(SelectedCountry).Result;

            return Page();
        }


        private async Task<Data.Models.CountryModel> LoadData(string countryCode)
        {
            return await DataProcessor.LoadDataForCountry(countryCode);
        }
    }
}

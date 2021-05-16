using System.Collections.Generic;
using System.Threading.Tasks;
using CovidPortal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CovidPortal.Pages.Compare
{
    public class CompareModel : PageModel
    {
        public CompareModel()
        {
            Countries = CountriesData.CountriesDictionary;
        }
        public List<Data.Models.CountryModel> CountriesResult { get; set; }
        public Data.Models.CountryModel FirstCountry { get; set; }
        public Data.Models.CountryModel SecoundCountry { get; set; }
        [BindProperty] public int NumberOfCountries { get; set; }

        [BindProperty] public List<string> SelectedCountry { get; set; }
        [BindProperty] public string SelectedFirstCountry { get; set; }
        [BindProperty] public string SelectedSecondCountry { get; set; }

        public Dictionary<string, string> Countries { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            if (SelectedFirstCountry != null)
            {
                FirstCountry = LoadData(SelectedFirstCountry).Result;
                SecoundCountry = LoadData(SelectedSecondCountry).Result;
            }


            return Page();
        }


        private async Task<Data.Models.CountryModel> LoadData(string countryCode)
        {
            return await DataProcessor.LoadDataForCountry(countryCode);
        }
    }
}
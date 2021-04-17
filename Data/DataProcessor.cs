using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CovidPortal.Data.Models;

namespace CovidPortal.Data
{
    public class DataProcessor
    {
        public static async Task<CountryModel> LoadDataForCountry(string countryCode)
        {
            ApiHelper.InitializeClient();
            var url = new Uri(ApiHelper.ApiClient.BaseAddress + "countries/" + countryCode);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CountryModel country = await response.Content.ReadAsAsync<CountryModel>();

                    return country;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<AllCountriesModel> LoadDataForAllCountries()
        {
            ApiHelper.InitializeClient();
            var url = new Uri(ApiHelper.ApiClient.BaseAddress + "all");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    AllCountriesModel allData = await response.Content.ReadAsAsync<AllCountriesModel>();

                    return allData;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

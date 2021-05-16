using System;
using System.Net.Http;
using System.Threading.Tasks;
using CovidPortal.Data.Models;
using Newtonsoft.Json;

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

                throw new Exception(response.ReasonPhrase);
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

                throw new Exception(response.ReasonPhrase);
            }
        }


        public static async Task<CountryHistoricalModel> LoadHistoricalDataForCountry(string country)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = "https://disease.sh/v3/covid-19/historical/" + country + "?lastdays=all";

                using (HttpResponseMessage response = await client.GetAsync(requestUri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        CountryHistoricalModel countryHistorical =
                            JsonConvert.DeserializeObject<CountryHistoricalModel>(jsonResponse);

                        return countryHistorical;
                    }

                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<AllCountryHistoricalModel> LoadHistoricalDataForAllCountry()
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = "https://disease.sh/v3/covid-19/historical/"+ "all?lastdays=all";

                using (HttpResponseMessage response = await client.GetAsync(requestUri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        AllCountryHistoricalModel allCountryHistorical =
                            JsonConvert.DeserializeObject<AllCountryHistoricalModel>(jsonResponse);

                        return allCountryHistorical;
                    }

                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
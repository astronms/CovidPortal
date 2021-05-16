using System.Collections.Generic;
using System.Threading.Tasks;
using CovidPortal.Data;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;

namespace CovidPortal.Pages
{
    public class CountryModel : PageModel
    {
        public CountryModel()
        {
            Countries = CountriesData.CountriesDictionary;
        }

        public Chart LineChart { get; set; }
        public Data.Models.CountryModel CountryData { get; set; }
        public Data.Models.CountryHistoricalModel CountryHistorical { get; set; }
        public Dictionary<string, string> Countries { get; set; }
        public string SelectedCountry { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string selectedCountry)
        {
            if (!ModelState.IsValid) return Page();

            SelectedCountry = selectedCountry;
            CountryData = LoadData(SelectedCountry).Result;
            CountryHistorical = LoadHistoricalData(SelectedCountry).Result;

            LineChart = GenerateLineChart();

            ViewData["LineChart"] = LineChart;


            return Page();
        }

        public Chart GenerateLineChart()
        {
            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Line;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();
            data.Labels = new List<string>() {"January", "February", "March", "April", "May", "June", "July"};

            LineDataset dataset = new LineDataset()
            {
                Label = "My First dataset",
                Data = new List<double?>() {65, 59, 80, 81, 56, 55, 40},
                Fill = "false",
                LineTension = 0.1,
                BackgroundColor = ChartColor.FromRgba(75, 192, 192, 0.4),
                BorderColor = ChartColor.FromRgba(75, 192, 192, 1),
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<ChartColor>() {ChartColor.FromRgba(75, 192, 192, 1)},
                PointBackgroundColor = new List<ChartColor>() {ChartColor.FromHexString("#fff")},
                PointBorderWidth = new List<int> {1},
                PointHoverRadius = new List<int> {5},
                PointHoverBackgroundColor = new List<ChartColor>() {ChartColor.FromRgba(75, 192, 192, 1)},
                PointHoverBorderColor = new List<ChartColor>() {ChartColor.FromRgba(220, 220, 220, 1)},
                PointHoverBorderWidth = new List<int> {2},
                PointRadius = new List<int> {1},
                PointHitRadius = new List<int> {10},
                SpanGaps = false
            };
            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            Options options = new Options()
            {
                Scales = new Scales()
            };

            Scales scales = new Scales()
            {
                YAxes = new List<Scale>()
                {
                    new CartesianScale()
                }
            };

            CartesianScale yAxes = new CartesianScale()
            {
                Ticks = new Tick()
            };

            Tick tick = new Tick()
            {
                Callback = "function(value, index, values) {return '$' + value;}"
            };

            yAxes.Ticks = tick;
            scales.YAxes = new List<Scale>() { yAxes };
            options.Scales = scales;
            chart.Options = options;

            chart.Data = data;

            return chart;
        }

        private async Task<Data.Models.CountryModel> LoadData(string countryCode)
        {
            return await DataProcessor.LoadDataForCountry(countryCode);
        }

        private async Task<Data.Models.CountryHistoricalModel> LoadHistoricalData(string countryCode)
        {
            return await DataProcessor.LoadHistoricalDataForCountry(countryCode);
        }

        public class ChartController : Controller
        {
            private readonly IConfiguration _config;

            public ChartController(IConfiguration config)
            {
                _config = config;
            }

        }
    }
}
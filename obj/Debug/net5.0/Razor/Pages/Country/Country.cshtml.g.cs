#pragma checksum "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d9aa7a24b5e2630cc8db82c1a64f72c662de5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CovidPortal.Pages.Country.Pages_Country_Country), @"mvc.1.0.razor-page", @"/Pages/Country/Country.cshtml")]
namespace CovidPortal.Pages.Country
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\github\moje\CovidPortal\Pages\_ViewImports.cshtml"
using CovidPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
using CovidPortal.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
using ChartJSCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{SelectedCountry?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d9aa7a24b5e2630cc8db82c1a64f72c662de5f", @"/Pages/Country/Country.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58454015fa2bb526e7920914b360971aa60329d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Country_Country : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleFormControlSelect1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
  
    Chart lineChart = (Chart)ViewData["LineChart"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\"></script>\r\n");
#nullable restore
#line 9 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
 if (Model.CountryHistorical != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Date', 'Cases', 'Recovered', 'Deaths'],

");
#nullable restore
#line 19 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                 for (int i = 0; i < Model.CountryHistorical.Timeline.cases.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Html.Raw("['" + Model.CountryHistorical.Timeline.cases.Select(k => k.Key).ElementAt(i) + "'," + Model.CountryHistorical.Timeline.cases.Select(k => k.Value).ElementAt(i) +
                              "," + Model.CountryHistorical.Timeline.recovered.Select(k => k.Value).ElementAt(i) + "," + Model.CountryHistorical.Timeline.deaths.Select(k => k.Value).ElementAt(i)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                     if (i != Model.CountryHistorical.Timeline.cases.Count)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                   Write(Html.Raw("],"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                                       
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                   Write(Html.Raw("]"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 33 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
       Write(Html.Raw("]);"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            var options = {
                title: 'Historical Data',
                curveType: 'function',
                legend: { position: 'bottom' },
                vAxis: {
                    viewWindow:
                    {
                        min: 0
                    }
                }
            };

            var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

            chart.draw(data, options);
        }
    </script>
");
#nullable restore
#line 52 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d9aa7a24b5e2630cc8db82c1a64f72c662de5f8533", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleFormControlSelect1\">Select country</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d9aa7a24b5e2630cc8db82c1a64f72c662de5f8908", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 57 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
             foreach (var value in Model.Countries.Values)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                 if (value == Model.SelectedCountry)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d9aa7a24b5e2630cc8db82c1a64f72c662de5f9675", async() => {
#nullable restore
#line 61 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                                Write(value);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 62 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d9aa7a24b5e2630cc8db82c1a64f72c662de5f11471", async() => {
#nullable restore
#line 65 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                       Write(value);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 66 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 56 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedCountry);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <small id=\"CountryCodeHelp\" class=\"form-text text-muted\">Select the name of country</small>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Show data</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
 if (Model.CountryData != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Data for ");
#nullable restore
#line 76 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
            Write(Model.CountryData.country);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <img");
            BeginWriteAttribute("src", " src=\"", 2828, "\"", 2869, 1);
#nullable restore
#line 76 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
WriteAttributeValue("", 2834, Model.CountryData.countryInfo.Flag, 2834, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""50"" style=""border:1px solid black""></h1>
    <table class=""table table-striped"">
        <tbody>
            <tr>
                <td>Country</td>
                <td>Population</td>
                <td>Cases</td>
                <td>Cases per on million</td>
                <td>Active cases</td>
                <td>Active cases per one million</td>
                <td>Critical cases</td>
                <td>Critical cases per one million</td>
                <td>Deaths</td>
                <td>Today deaths</td>
                <td>Deaths per one million</td>
                <td>Recovered</td>
                <td>Test</td>
                <td>Test per one million</td>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 96 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.population);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.cases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 99 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.casesPerOneMillion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 100 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 101 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.activePerOneMillion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 102 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.critical);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 103 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.criticalPerOneMillion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 104 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.deaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 105 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.todayDeaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 106 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.deathsPerOneMillion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 107 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.recovered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 108 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.tests);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 109 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
               Write(Model.CountryData.testsPerOneMillion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
        </tbody>
    </table>
    <br />
    <h2>Historical Data</h2>
    <table class=""table table-striped"">
        <tbody>
            <tr>
                <th>Date</th>
                <th>Cases</th>
                <th>Recovered</th>
                <th>Deaths</th>
            </tr>

");
#nullable restore
#line 124 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
             for (int i = 0; i < Model.CountryHistorical.Timeline.cases.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 128 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                   Write(Model.CountryHistorical.Timeline.cases.Select(k => k.Key).ElementAt(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 131 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                   Write(Model.CountryHistorical.Timeline.cases.Select(k => k.Value).ElementAt(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 134 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                   Write(Model.CountryHistorical.Timeline.recovered.Select(k => k.Value).ElementAt(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 137 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
                   Write(Model.CountryHistorical.Timeline.deaths.Select(k => k.Value).ElementAt(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 140 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n    <div class=\"w-100 p-3\" id=\"curve_chart\" style=\"width: 100%; height: 500px\"></div>\r\n");
            WriteLiteral("    <p>Updated: ");
#nullable restore
#line 147 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
           Write(Model.CountryData.updated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 148 "F:\github\moje\CovidPortal\Pages\Country\Country.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CovidPortal.Pages.CountryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CovidPortal.Pages.CountryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CovidPortal.Pages.CountryModel>)PageContext?.ViewData;
        public CovidPortal.Pages.CountryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62287a432c5fe8890fb727b41911bfb2d7e5763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trips_Index), @"mvc.1.0.view", @"/Views/Trips/Index.cshtml")]
namespace AspNetCore
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
#line 1 "D:\TripEventPlanner\TripEventPlanner\Views\_ViewImports.cshtml"
using TripEventPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TripEventPlanner\TripEventPlanner\Views\_ViewImports.cshtml"
using TripEventPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TripEventPlanner\TripEventPlanner\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c62287a432c5fe8890fb727b41911bfb2d7e5763", @"/Views/Trips/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2687c0fd8b98ba2c0cac935a2a2806a08bfa212", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Trips_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TripEventPlanner.Models.Trip>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "trips", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectedTrip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62287a432c5fe8890fb727b41911bfb2d7e57634693", async() => {
                WriteLiteral("Create Trip");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<section class=\"my-trip\">\r\n");
#nullable restore
#line 11 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"trip-location\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62287a432c5fe8890fb727b41911bfb2d7e57636168", async() => {
                WriteLiteral("\r\n\r\n                <section class=\"trip-location-imageUrl\">\r\n\r\n                    <figure>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 483, "\"", 541, 1);
#nullable restore
#line 19 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
WriteAttributeValue("", 489, Html.DisplayFor(modelItem => item.Country.ImageUrl), 489, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\"");
                BeginWriteAttribute("class", " class=\"", 563, "\"", 571, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <figcaption>");
#nullable restore
#line 20 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</figcaption>\r\n                    </figure>\r\n                    <p> ");
#nullable restore
#line 22 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 22 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </section>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-countryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                         WriteLiteral(item.CountryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["countryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-countryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["countryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n");
#nullable restore
#line 26 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<section>\r\n    <h3>My Activities</h3>\r\n    <p>\r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62287a432c5fe8890fb727b41911bfb2d7e576310526", async() => {
                WriteLiteral("Add Activity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n</section>\r\n");
#nullable restore
#line 34 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
     foreach (var location in item.Country.Locations)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
         foreach (var locationItem in location.Activities)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section class=\"trip-activities\">\r\n                <section class=\"trip-activity-imageUrl\">\r\n                    <figure>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1367, "\"", 1425, 1);
#nullable restore
#line 44 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
WriteAttributeValue("", 1373, Html.DisplayFor(modelItem => locationItem.ImageUrl), 1373, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1426, "\"", 1450, 1);
#nullable restore
#line 44 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
WriteAttributeValue("", 1432, locationItem.Name, 1432, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"trip-image\" />\r\n                    </figure>\r\n                </section>\r\n                <section class=\"trip-activity-info\">\r\n                    <span class=\"info-span\"><strong> Country: </strong>");
#nullable restore
#line 48 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                  Write(item.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Activitytype: </strong>");
#nullable restore
#line 49 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => locationItem.ActivityType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Activity Name: </strong>");
#nullable restore
#line 50 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                        Write(locationItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Description: </strong>");
#nullable restore
#line 51 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                      Write(locationItem.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Adress: </strong>");
#nullable restore
#line 52 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                 Write(locationItem.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Price: </strong>");
#nullable restore
#line 53 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                Write(locationItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"info-span\"><strong> Date: </strong>");
#nullable restore
#line 54 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                               Write(locationItem.StartDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 54 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
                                                                                                    Write(locationItem.EndDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </section>\r\n            </section>\r\n");
#nullable restore
#line 57 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\TripEventPlanner\TripEventPlanner\Views\Trips\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TripEventPlanner.Models.Trip>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

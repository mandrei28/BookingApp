#pragma checksum "E:\SiteWAD\BookingApp\Views\Home\RestaurantReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "620eb7b1bcc92613e33aacdd20e86e2d067df70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RestaurantReservation), @"mvc.1.0.view", @"/Views/Home/RestaurantReservation.cshtml")]
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
#line 1 "E:\SiteWAD\BookingApp\Views\_ViewImports.cshtml"
using BookingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SiteWAD\BookingApp\Views\_ViewImports.cshtml"
using BookingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620eb7b1bcc92613e33aacdd20e86e2d067df70d", @"/Views/Home/RestaurantReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dde4c95dde9f526c68e731729958bef7e6435ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RestaurantReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\SiteWAD\BookingApp\Views\Home\RestaurantReservation.cshtml"
  
    ViewData["Title"] = "RestaurantReservation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Restaurant Name</h1>\r\n    <input id=\"datepicker\" width=\"276\" />\r\n    <script>\r\n        $(\'#datepicker\').datepicker({\r\n            uiLibrary: \'bootstrap4\'\r\n        });\r\n    </script>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
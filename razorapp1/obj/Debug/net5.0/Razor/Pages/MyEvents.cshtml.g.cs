#pragma checksum "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1d7a11f62818c3bad05206b446ee1f2cf5d778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(razorapp1.Pages.Pages_MyEvents), @"mvc.1.0.razor-page", @"/Pages/MyEvents.cshtml")]
namespace razorapp1.Pages
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
#line 1 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\_ViewImports.cshtml"
using razorapp1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1d7a11f62818c3bad05206b446ee1f2cf5d778", @"/Pages/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8eab6d5f0dd7395676a47b4f592518a97cea5b7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyEvents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
  
    ViewData["Title"] = "MyEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyEvents</h1>\r\n\r\n<table class=\"table\">\r\n  \r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
         foreach (var item in Model.Event)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\cbchr\source\repos\razorapp1\razorapp1\Pages\MyEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<razorapp1.Pages.MyEventsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<razorapp1.Pages.MyEventsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<razorapp1.Pages.MyEventsModel>)PageContext?.ViewData;
        public razorapp1.Pages.MyEventsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

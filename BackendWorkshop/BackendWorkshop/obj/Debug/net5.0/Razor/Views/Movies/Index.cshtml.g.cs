#pragma checksum "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f782ea63def76a9fd88a8acd2937ab178f634ff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/_ViewImports.cshtml"
using BackendWorkshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/_ViewImports.cshtml"
using BackendWorkshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f782ea63def76a9fd88a8acd2937ab178f634ff5", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a28c54a5287e0b739f309ceab2c495b5c24a3c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BackendWorkshop.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Movies</h2>\n");
            WriteLiteral("<p>\n");
            WriteLiteral("    ");
#nullable restore
#line 10 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
Write(Html.ActionLink("Create New", "Create","Movies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<p>\n");
#nullable restore
#line 13 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
     using (Html.BeginForm("Index", "Movies", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n            Genre: ");
#nullable restore
#line 16 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
              Write(Html.DropDownList("MovieGenre", "All"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            Title: ");
#nullable restore
#line 17 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
              Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <input type=\"submit\" value=\"Filter\"/>\n        </p>\n");
#nullable restore
#line 20 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<table class=\"table\">\n    <thead>\n    <tr>\n        <th>\n            ");
#nullable restore
#line 26 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 29 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 32 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 35 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 38 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n\n        <th></th>\n    </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 46 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
     if (Model != null)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 52 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 61 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 64 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1727, "\"", 1755, 2);
            WriteAttributeValue("", 1734, "/Movies/Edit/", 1734, 13, true);
#nullable restore
#line 67 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
WriteAttributeValue("", 1747, item.ID, 1747, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1790, "\"", 1821, 2);
            WriteAttributeValue("", 1797, "/Movies/Details/", 1797, 16, true);
#nullable restore
#line 68 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
WriteAttributeValue("", 1813, item.ID, 1813, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1859, "\"", 1889, 2);
            WriteAttributeValue("", 1866, "/Movies/Delete/", 1866, 15, true);
#nullable restore
#line 69 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
WriteAttributeValue("", 1881, item.ID, 1881, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n                </td>\n            </tr>\n");
#nullable restore
#line 72 "/Users/xing.chen/Desktop/BackendWorkshop_MVC/BackendWorkshop/BackendWorkshop/Views/Movies/Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n");
            WriteLiteral("\n");
            WriteLiteral("\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BackendWorkshop.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18af600388d550015dc1abb4da35132679e1bf66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Task2), @"mvc.1.0.view", @"/Views/Rookies/Task2.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\_ViewImports.cshtml"
using Core_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\_ViewImports.cshtml"
using Core_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18af600388d550015dc1abb4da35132679e1bf66", @"/Views/Rookies/Task2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0eaa5661b89f8a8235807a0c02538c44125481", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Task2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
  
    ViewData["Title"] = "Assignment-2";
    //Layout = "~/Core MVC/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <center>\r\n        <h3>The oldest member</h3>\r\n        <br/>\r\n");
#nullable restore
#line 11 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
         foreach (var item in Model.Take(1))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n\r\n                ");
#nullable restore
#line 15 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 17 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 19 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
            Write((bool)item.Gender ? "Male" : "Female");

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n              \r\n                ");
#nullable restore
#line 21 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 23 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 25 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 27 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 29 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
            Write((bool)item.Gender ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </center>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
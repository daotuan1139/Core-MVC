#pragma checksum "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc1367dc8bda386203924b2defa6477b8ab7a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Task3), @"mvc.1.0.view", @"/Views/Rookies/Task3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc1367dc8bda386203924b2defa6477b8ab7a1b", @"/Views/Rookies/Task3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0eaa5661b89f8a8235807a0c02538c44125481", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Task3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task3.cshtml"
  
    ViewData["Title"] = "Assignment-3";
    //Layout = "~/Core MVC/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <center>\r\n        <h3>List contains Full Name only</h3>\r\n        <br/>\r\n");
#nullable restore
#line 11 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task3.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n\r\n                ");
#nullable restore
#line 15 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task3.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 17 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task3.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task3.cshtml"
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

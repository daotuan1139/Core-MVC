#pragma checksum "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6402c9ebe4e7168c5f3f11a95de79b01656bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Task4_1), @"mvc.1.0.view", @"/Views/Rookies/Task4_1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6402c9ebe4e7168c5f3f11a95de79b01656bb5", @"/Views/Rookies/Task4_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0eaa5661b89f8a8235807a0c02538c44125481", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Task4_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
  
    ViewData["Title"] = "Assignment-4";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <center>\r\n        <h3>List years 2000</h3>\r\n        <br/>\r\n        <div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
             using (Html.BeginForm("Task4", "Rookies", FormMethod.Get))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <button class=""btn btn-primary"" type=""submit"" value=""1"" name=""smallTask""> Year equal 2000 </button>
                <button class=""btn btn-primary"" type=""submit"" value=""2"" name=""smallTask""> Year less 2000 </button>
                <button class=""btn btn-primary"" type=""submit"" value=""3"" name=""smallTask""> Year higher 2000 </button>
");
#nullable restore
#line 19 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <br /> <br />\r\n\r\n");
#nullable restore
#line 25 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n\r\n                ");
#nullable restore
#line 30 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 32 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 34 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
            Write((bool)item.Gender ? "Male" : "Female");

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n\r\n                ");
#nullable restore
#line 36 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 38 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 40 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 42 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n\r\n                ");
#nullable restore
#line 44 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
            Write((bool)item.Gender ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\admin\Desktop\NashTech\Core MVC\Views\Rookies\Task4_1.cshtml"
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

#pragma checksum "D:\its012\its012\its012\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54fb61ef5a5204bf67820bdb4e070981d0fd26f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\its012\its012\its012\Views\_ViewImports.cshtml"
using its012;

#line default
#line hidden
#line 2 "D:\its012\its012\its012\Views\_ViewImports.cshtml"
using its012.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54fb61ef5a5204bf67820bdb4e070981d0fd26f6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842ecc5c92e737abc9eda80a734144420e376a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\its012\its012\its012\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\its012\its012\its012\Views\Home\Index.cshtml"
 if (ViewData["ShowAlert"] != null && (bool)ViewData["ShowAlert"] == true)
{

#line default
#line hidden
            BeginContext(126, 69, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ขอขอบคุณ ");
            EndContext();
            BeginContext(197, 16, false);
#line 8 "D:\its012\its012\its012\Views\Home\Index.cshtml"
             Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(214, 25, true);
            WriteLiteral(" ทางเราจะติดต่อกลับไปที่ ");
            EndContext();
            BeginContext(241, 17, false);
#line 8 "D:\its012\its012\its012\Views\Home\Index.cshtml"
                                                         Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(259, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(283, 21, true);
            WriteLiteral("\r\n        ขอบคุณครับ ");
            EndContext();
            BeginContext(305, 21, false);
#line 11 "D:\its012\its012\its012\Views\Home\Index.cshtml"
              Write(ViewData["ShowAlert"]);

#line default
#line hidden
            EndContext();
            BeginContext(326, 7, true);
            WriteLiteral(";\r\n    ");
            EndContext();
            BeginContext(340, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(348, 40, true);
            WriteLiteral("ข้อความนี้เป็นข้อความใน HTML ไม่ใช่ C#\r\n");
            EndContext();
#line 14 "D:\its012\its012\its012\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(391, 193, true);
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            EndContext();
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

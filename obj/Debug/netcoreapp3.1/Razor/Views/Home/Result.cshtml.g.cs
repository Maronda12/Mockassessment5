#pragma checksum "C:\Users\maron\source\repos\Assessment5a\Assessment5a\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c09f417fa0a3256383a9ed1ce85d38562e9587b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\maron\source\repos\Assessment5a\Assessment5a\Views\_ViewImports.cshtml"
using Assessment5a;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maron\source\repos\Assessment5a\Assessment5a\Views\_ViewImports.cshtml"
using Assessment5a.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09f417fa0a3256383a9ed1ce85d38562e9587b8", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da9dbc8cb16282f0ecfebc35a1338fc8e77bbd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\maron\source\repos\Assessment5a\Assessment5a\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p> ");
#nullable restore
#line 5 "C:\Users\maron\source\repos\Assessment5a\Assessment5a\Views\Home\Result.cshtml"
Write(ViewBag.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p> ");
#nullable restore
#line 6 "C:\Users\maron\source\repos\Assessment5a\Assessment5a\Views\Home\Result.cshtml"
Write(ViewBag.Operation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>");
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

#pragma checksum "D:\Tuwaiq\UnitTest\projects\mvc-unit-test\Project01_ASP.NET_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "771ec4931668b1fed457b9936ddf27c1941109a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Tuwaiq\UnitTest\projects\mvc-unit-test\Project01_ASP.NET_MVC\Views\_ViewImports.cshtml"
using Project01_ASP.NET_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tuwaiq\UnitTest\projects\mvc-unit-test\Project01_ASP.NET_MVC\Views\_ViewImports.cshtml"
using Project01_ASP.NET_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771ec4931668b1fed457b9936ddf27c1941109a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a562ef60ea4f8851e3395d8edff6930b4909edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tuwaiq\UnitTest\projects\mvc-unit-test\Project01_ASP.NET_MVC\Views\Home\Index.cshtml"
  
    Layout = "_myLayout";
    var quotes = (List<Quotes>)ViewData["quotes"];
    var rnd = new Random();
    int num = rnd.Next(0, quotes.Count - 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<h1 class=""display-4"">Welcome to the Bookstore!</h1>

<p class=""lead"">
    Relax. Read. Enjoy.
</p>

<a class=""btn btn-info"" href=""/books"" role=""button"">See all books <i class=""fas fa-chevron-right pl-2""></i> </a>



<hr />

<figure class=""text-center"">
    <blockquote class=""blockquote"">
        <p>");
#nullable restore
#line 23 "D:\Tuwaiq\UnitTest\projects\mvc-unit-test\Project01_ASP.NET_MVC\Views\Home\Index.cshtml"
      Write(quotes[num].text);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n    </blockquote>\r\n    <figcaption class=\"blockquote-footer\">\r\n        ");
#nullable restore
#line 26 "D:\Tuwaiq\UnitTest\projects\mvc-unit-test\Project01_ASP.NET_MVC\Views\Home\Index.cshtml"
   Write(quotes[num].author);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n    </figcaption>\r\n</figure>");
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

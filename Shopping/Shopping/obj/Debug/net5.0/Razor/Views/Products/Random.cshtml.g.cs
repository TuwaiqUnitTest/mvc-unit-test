#pragma checksum "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7149e0c633bf45a647658d90e54c0e0d40eaf969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Random), @"mvc.1.0.view", @"/Views/Products/Random.cshtml")]
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
#line 1 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7149e0c633bf45a647658d90e54c0e0d40eaf969", @"/Views/Products/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml"
  
    ProductModel product = (ProductModel)ViewData["foundProduct"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>The random product</h2>\r\n\r\n<br />\r\n\r\n<h2> ");
#nullable restore
#line 10 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml"
Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 10 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml"
             Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 10 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml"
                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 178, "\"", 198, 1);
#nullable restore
#line 11 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml"
WriteAttributeValue("", 184, product.Image, 184, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 199, "\"", 219, 1);
#nullable restore
#line 11 "C:\Users\Ammar\source\repos\Shopping\Shopping\Views\Products\Random.cshtml"
WriteAttributeValue("", 205, product.Image, 205, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
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

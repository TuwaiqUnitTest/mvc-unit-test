#pragma checksum "C:\Users\Ranee\Desktop\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e45ca0a1cdadf74fdcb2d943b14ecb0d35d90def"
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
#line 1 "C:\Users\Ranee\Desktop\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\_ViewImports.cshtml"
using Event_Hall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ranee\Desktop\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\_ViewImports.cshtml"
using Event_Hall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45ca0a1cdadf74fdcb2d943b14ecb0d35d90def", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80448bf0756b0925148de66fbf4e64ee25a36193", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ranee\Desktop\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45ca0a1cdadf74fdcb2d943b14ecb0d35d90def3339", async() => {
                WriteLiteral(@"
    <style media=""all"">
        body, html {
            height: 100%
        }

        .bgimg {
            /* Background image */
            background-image: url('v');
            /* Full-screen *https://www.designbolts.com/wp-content/uploads/2012/11/Pinstriped-Suit-diagonal-Seamless-photoshop-Pattern.jpg
            height: 100%;
            /* Center the background image */
            background-position: center;
            /* Scale and zoom in the image */
            background-size: cover;
            /* Add position: relative to enable absolutely positioned elements inside the image (place text) */
            position: relative;
            /* Add a white text color to all elements inside the .bgimg container */
            color: white;
            /* Add a font */
            font-family: ""Courier New"", Courier, monospace;
            /* Set the font-size to 25 pixels */
            font-size: 25px;
        }

        /* Position text in the top-left corner */
      ");
                WriteLiteral(@"  .topleft {
            position: absolute;
            top: 0;
            left: 16px;
        }

        /* Position text in the bottom-left corner */
        .bottomleft {
            position: absolute;
            bottom: 0;
            left: 16px;
        }

        /* Position text in the middle */
        .middle {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            text-align: center;
        }

        /* Style the <hr> element */
        hr {
            margin: auto;
            width: 40%;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""bgimg"">
    <div class=""topleft"">
        <p>Logo</p>
    </div>
    <div class=""middle"">
        <h1>Welcome</h1>
        <hr>
        <p>Events Hall Management System</p>
    </div>
    <div class=""bottomleft"">
        <p>Some text</p>
    </div>
</div>
");
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

#pragma checksum "C:\Users\super\source\repos\spletnaSPIV\spletnaSPIV\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "079d5d7dbb4869bbe32a9bf01666b1d7439a4f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
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
#line 1 "C:\Users\super\source\repos\spletnaSPIV\spletnaSPIV\Views\_ViewImports.cshtml"
using spletnaSPIV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\super\source\repos\spletnaSPIV\spletnaSPIV\Views\_ViewImports.cshtml"
using spletnaSPIV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079d5d7dbb4869bbe32a9bf01666b1d7439a4f63", @"/Views/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b7a9e7f93f4ccb28a401b26ff5074a72b85a2e", @"/Views/_ViewImports.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\super\source\repos\spletnaSPIV\spletnaSPIV\Views\_Layout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6  offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">

                        <a class=""nav-link"" href=""/Identity/Account/Login"">Log In</a>
                    </li>
                    <li class=""nav-item"">

                        <a class=""nav-link"" href=""/Identity/Account/Register"">Sign Up </a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">

                <div class=""row"">
                    <div class=""col-md-12 "">
                        ");
#nullable restore
#line 24 "C:\Users\super\source\repos\spletnaSPIV\spletnaSPIV\Views\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 34 "C:\Users\super\source\repos\spletnaSPIV\spletnaSPIV\Views\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>

            $(function () {

                var current = location.pathname;
                $('.nav-tabs li a').each(function () {
                    var $this = $(this);
                    if (current.indexOf($this.attr('href')) !== -1) {
                        $this.addClass('active');
                    }
                })
            })
    </script>
");
            }
            );
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

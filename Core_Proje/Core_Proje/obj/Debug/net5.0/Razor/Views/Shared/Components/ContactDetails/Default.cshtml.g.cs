#pragma checksum "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c4bf556c648c03b61a3df882cb4b798ee5a396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
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
#line 1 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c4bf556c648c03b61a3df882cb4b798ee5a396", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContactDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-6\" data-aos=\"fade-left\" data-aos-delay=\"300\">\r\n");
#nullable restore
#line 4 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mt-3 px-1\">\r\n            <div class=\"h5\">");
#nullable restore
#line 7 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <p>");
#nullable restore
#line 8 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <p>Aşağıdaki adresler üzerinden bana mail gönderebilir veya sorularınızı iletebilirsiniz.</p>
            <p>Görüşmek üzere!</p>
        </div>
        <div class=""mt-53 px-1"">
            <div class=""row"">
                <div class=""col-sm-2"">
                    <div class=""pb-1"">Email:</div>
                </div>
                <div class=""col-sm-10"">
                    <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 18 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                                           Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""pb-1"">Youtube:</div>
                </div>
                <div class=""col-sm-10"">
                    <div class=""pb-1 fw-bolder"">Mustafa Ataş</div>
                </div>
                <div class=""col-sm-2"">
                    <div class=""pb-1"">Telefon:</div>
                </div>
                <div class=""col-sm-10"">
                    <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 30 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
                                           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\ContactDetails\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591

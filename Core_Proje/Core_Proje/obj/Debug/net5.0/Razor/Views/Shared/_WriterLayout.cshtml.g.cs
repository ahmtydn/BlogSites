#pragma checksum "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672c8fafabeb86fbc790dce376b09f21c1183838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WriterLayout), @"mvc.1.0.view", @"/Views/Shared/_WriterLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672c8fafabeb86fbc790dce376b09f21c1183838", @"/Views/Shared/_WriterLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__WriterLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "672c8fafabeb86fbc790dce376b09f21c11838383701", async() => {
                WriteLiteral("\r\n    <div class=\"container-scroller\">\r\n        <!-- partial:../../partials/_navbar.html -->\r\n        ");
#nullable restore
#line 14 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
   Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_NavbarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- partial -->\r\n        <div class=\"container-fluid page-body-wrapper\">\r\n\r\n            <!-- partial:../../partials/_sidebar.html -->\r\n            ");
#nullable restore
#line 19 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
       Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_SidebarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- partial -->\r\n            <div class=\"main-panel\">\r\n                <div class=\"content-wrapper\">\r\n\r\n                        ");
#nullable restore
#line 24 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n                ");
#nullable restore
#line 27 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
           Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <!-- main-panel ends -->\r\n        </div>\r\n        <!-- page-body-wrapper ends -->\r\n    </div>\r\n    ");
#nullable restore
#line 33 "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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

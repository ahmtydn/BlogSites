#pragma checksum "C:\Users\mustafa\Desktop\Core_Proje\Core_Proje\Core_Proje\Views\Admin\NewSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be9e6e00c927d210f43e8dbf88678ef918fbd0c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NewSidebar), @"mvc.1.0.view", @"/Views/Admin/NewSidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9e6e00c927d210f43e8dbf88678ef918fbd0c5", @"/Views/Admin/NewSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NewSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-xs rounded-circle "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/corona-free-dark-bootstrap-admin-template-1.0.0/template/assets/images/faces/face15.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"nav\">\r\n    <li class=\"nav-item profile\">\r\n        <div class=\"profile-desc\">\r\n            <div class=\"profile-pic\">\r\n                <div class=\"count-indicator\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be9e6e00c927d210f43e8dbf88678ef918fbd0c54467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""count bg-success""></span>
                </div>
                <div class=""profile-name"">
                    <h5 class=""mb-0 font-weight-normal"">Mustafa Ataş</h5>
                    <span>Admin</span>
                </div>
            </div>
            <a href=""#"" id=""profile-dropdown"" data-toggle=""dropdown""><i class=""mdi mdi-dots-vertical""></i></a>
            <div class=""dropdown-menu dropdown-menu-right sidebar-dropdown preview-list"" aria-labelledby=""profile-dropdown"">
                <a href=""/Writer/Profile/Index/"" class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-settings text-primary""></i>
                        </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject ellipsis mb-1 text-small"">Hesap Ayarları</");
            WriteLiteral(@"p>
                    </div>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""/Writer/Profile/Index/"" class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-onepassword  text-info""></i>
                        </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject ellipsis mb-1 text-small"">Şifre Değiştir</p>
                    </div>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""/AdminMessage/ReceiverMessageList/"" class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                        <div class=""preview-icon bg-dark rounded-circle"">
                            <i class=""mdi mdi-calendar-today text-success""></i>
   ");
            WriteLiteral(@"                     </div>
                    </div>
                    <div class=""preview-item-content"">
                        <p class=""preview-subject ellipsis mb-1 text-small"">Gelen Mesajlar</p>
                    </div>
                </a>
            </div>
        </div>
    </li>
    <li class=""nav-item nav-category"">
        <span class=""nav-link"">Navigation</span>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Dashboard/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-speedometer""></i>
            </span>
            <span class=""menu-title"">Dashboard</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-comment-account-outline""></i>
            </span>
            <span class=""menu-title"">Yazar Paneli</span>
        </a>
    </li>
    <li class=""nav-item m");
            WriteLiteral(@"enu-items"">
        <a class=""nav-link"" href=""/Skill/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-laptop""></i>
            </span>
            <span class=""menu-title"">Yetenekler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Experience/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-playlist-play""></i>
            </span>
            <span class=""menu-title"">Deneyimler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Default/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-table-large""></i>
            </span>
            <span class=""menu-title"">Siteye Git</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""../../pages/charts/chartjs.html"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-chart-bar""></i>
   ");
            WriteLiteral(@"         </span>
            <span class=""menu-title"">Grafikler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Service/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Hizmetler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Portfolio/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-github-circle""></i>
            </span>
            <span class=""menu-title"">Projeler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/AdminMessage/ReceiverMessageList/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Gelen Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""n");
            WriteLiteral(@"av-link"" href=""/AdminMessage/SenderMessageList/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-message""></i>
            </span>
            <span class=""menu-title"">Giden Mesajlar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Contact/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-phone""></i>
            </span>
            <span class=""menu-title"">İletişim</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/About/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-account""></i>
            </span>
            <span class=""menu-title"">Hakkımda</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/ContactSubplace/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-calendar""></i>
            </span>
            <span cl");
            WriteLiteral(@"ass=""menu-title"">Alt İletişim</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Testimonial/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Yazılar</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Feature/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
            </span>
            <span class=""menu-title"">Öne Çıkan Gönderiler</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/SocialMedia/Index/"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-youtube""></i>
            </span>
            <span class=""menu-title"">Sosyal Medya</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""/Experience2/Index/"">
       ");
            WriteLiteral(@"     <span class=""menu-icon"">
                <i class=""mdi mdi-car""></i>
            </span>
            <span class=""menu-title"">Deneyim Ajax</span>
        </a>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" data-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-security""></i>
            </span>
            <span class=""menu-title"">Şifre ve Güvenlik</span>
            <i class=""menu-arrow""></i>
        </a>
        <div class=""collapse"" id=""auth"">
            <ul class=""nav flex-column sub-menu"">
                <li class=""nav-item""> <a class=""nav-link"" href=""/ErrorPage/Error404/""> 404 </a></li>
                <li class=""nav-item""> <a class=""nav-link"" href=""/ErrorPage/Index/""> 403 </a></li>
                <li class=""nav-item""> <a class=""nav-link"" href=""/Writer/Login/Index/""> Login </a></li>
                <li class=""nav-item""> <a class=""nav-link"" href=""/Writer/R");
            WriteLiteral(@"egister/Index/""> Register </a></li>
            </ul>
        </div>
    </li>
    <li class=""nav-item menu-items"">
        <a class=""nav-link"" href=""http://www.bootstrapdash.com/demo/corona-free/jquery/documentation/documentation.html"">
            <span class=""menu-icon"">
                <i class=""mdi mdi-file-document-box""></i>
            </span>
            <span class=""menu-title"">Dokümanlar</span>
        </a>
    </li>
</ul>");
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

#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Account\UpdatePasswordFail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd59f3c47e0bb839ca072b6a27c5f2020f7013c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UpdatePasswordFail), @"mvc.1.0.view", @"/Views/Account/UpdatePasswordFail.cshtml")]
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
#line 1 "D:\Development\DailyTuntun\DailyTuntun\Views\_ViewImports.cshtml"
using DailyTuntun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\DailyTuntun\DailyTuntun\Views\_ViewImports.cshtml"
using DailyTuntun.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd59f3c47e0bb839ca072b6a27c5f2020f7013c5", @"/Views/Account/UpdatePasswordFail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UpdatePasswordFail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\UpdatePasswordFail.cshtml"
  
    ViewData["Title"] = "UpdatePasswordFail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header page-header-xs"" style=""background-image: url('/assets/img/sub/bg_sub.png'); "">
    <div class=""filter""></div>
    <div class=""content-center"">
        <div class=""container"">
            <div class=""motto"">
                <h3 class=""title"">암호 변경 오류</h3>
            </div>
        </div>
    </div>
</div>

<div class=""wrapper"">
    <div class=""main"">
        <!-- section -->
        <div class=""section"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-10 col-md-10 col-sm-10 col-12 mr-auto"">
                        <div class=""info info-horizontal"">
                            <div class=""description"">
                                <h3> 로그인 하기 </h3>
                                <p>이미 인증이 완료되었을 수도 있습니다. <a");
            BeginWriteAttribute("href", " href=\"", 880, "\"", 918, 1);
#nullable restore
#line 26 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\UpdatePasswordFail.cshtml"
WriteAttributeValue("", 887, Url.Action("LogIn", "Account"), 887, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">로그인</a>이 되는지 확인해봅니다.</p>
                            </div>
                        </div>
                        <div class=""info info-horizontal"">
                            <div class=""description"">
                                <h3> 암호 변경하기 </h3>
                                <p>암호 변경을 다시 해보세요. 암호 변경을 위한 <a");
            BeginWriteAttribute("href", " href=\"", 1244, "\"", 1289, 1);
#nullable restore
#line 32 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\UpdatePasswordFail.cshtml"
WriteAttributeValue("", 1251, Url.Action("LostPassword", "Account"), 1251, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">메일을 재발송</a>받아봅니다.</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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

#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00bfc2fb4f9f7e7160f9e9bf313c97f509b32728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterAuthFail), @"mvc.1.0.view", @"/Views/Account/RegisterAuthFail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bfc2fb4f9f7e7160f9e9bf313c97f509b32728", @"/Views/Account/RegisterAuthFail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterAuthFail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
  
    ViewData["Title"] = "RegisterAuthFail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header page-header-xs\" style=\"background-image: url(\'/assets/img/sub/bg_sub.png\');\">\r\n");
            WriteLiteral(@"    <div class=""content-center"">
        <div class=""container"">
            <div class=""motto"">
                <h3 class=""title text-dark""><b>이메일 인증 오류</b></h3>
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
                            <h3 class=""card-title""><b>원용</b></h3>
                            <div class=""description"">
                                <h4> 로그인 하기 </h4>
                                <p>이미 인증이 완료되었을 수도 있습니다. <a");
            BeginWriteAttribute("href", " href=\"", 966, "\"", 1004, 1);
#nullable restore
#line 27 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
WriteAttributeValue("", 973, Url.Action("LogIn", "Account"), 973, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">로그인</a>이 되는지 확인해봅니다.</p>\r\n                            </div>\r\n                            <div class=\"description\">\r\n                                <h4> 인증 이메일 재발송하기 </h4>\r\n                                <p>인증 신청을 다시 해보세요. 인증을 위한 <a");
            BeginWriteAttribute("href", " href=\"", 1240, "\"", 1287, 1);
#nullable restore
#line 31 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
WriteAttributeValue("", 1247, Url.Action("RegisterReAuth", "Account"), 1247, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">메일을 재발송</a>받아봅니다.</p>\r\n                            </div>\r\n                            <div class=\"description\">\r\n                                <h4> 이메일 변경하기 </h4>\r\n                                <p>등록한 이메일을 <a");
            BeginWriteAttribute("href", " href=\"", 1502, "\"", 1546, 1);
#nullable restore
#line 35 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
WriteAttributeValue("", 1509, Url.Action("UpdateEmail", "Account"), 1509, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">다른 이메일 주소로 변경</a>해봅니다.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-10 col-md-10 col-sm-10 col-12 mr-auto"">
                        <div class=""info info-horizontal"">
                            <h3 class=""card-title""><b>파견 교사용</b></h3>
                            <div class=""description"">
                                <h4> 로그인 하기 </h4>
                                <p>이미 인증이 완료되었을 수도 있습니다. <a");
            BeginWriteAttribute("href", " href=\"", 2048, "\"", 2112, 1);
#nullable restore
#line 44 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
WriteAttributeValue("", 2055, Url.Action("LogIn", "Account", new { managerYn = true }), 2055, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">로그인</a>이 되는지 확인해봅니다.</p>\r\n                            </div>\r\n                            <div class=\"description\">\r\n                                <h4> 인증 이메일 재발송하기 </h4>\r\n                                <p>인증 신청을 다시 해보세요. 인증을 위한 <a");
            BeginWriteAttribute("href", " href=\"", 2348, "\"", 2421, 1);
#nullable restore
#line 48 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
WriteAttributeValue("", 2355, Url.Action("RegisterReAuth", "Account", new { managerYn = true }), 2355, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">메일을 재발송</a>받아봅니다.</p>\r\n                            </div>\r\n                            <div class=\"description\">\r\n                                <h4> 이메일 변경하기 </h4>\r\n                                <p>등록한 이메일을 <a");
            BeginWriteAttribute("href", " href=\"", 2636, "\"", 2706, 1);
#nullable restore
#line 52 "D:\Development\DailyTuntun\DailyTuntun\Views\Account\RegisterAuthFail.cshtml"
WriteAttributeValue("", 2643, Url.Action("UpdateEmail", "Account", new { managerYn = true }), 2643, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">다른 이메일 주소로 변경</a>해봅니다.</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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

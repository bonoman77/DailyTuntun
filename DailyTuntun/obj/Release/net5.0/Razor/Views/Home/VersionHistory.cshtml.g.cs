#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Home\VersionHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "642f32a9782ae154929f70a082a30cc42f3eb997"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VersionHistory), @"mvc.1.0.view", @"/Views/Home/VersionHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"642f32a9782ae154929f70a082a30cc42f3eb997", @"/Views/Home/VersionHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VersionHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Development\DailyTuntun\DailyTuntun\Views\Home\VersionHistory.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "버젼관리";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card card-timeline card-plain\">\r\n                <div class=\"card-body\">\r\n                    <ul class=\"timeline\">\r\n\r\n");
            WriteLiteral(@"              


                        <li>
                            <div class=""timeline-badge info"">
                                <i class=""nc-icon nc-world-2""></i>
                            </div>
                            <div class=""timeline-panel"">
                                <div class=""timeline-heading"">
                                    <span class=""badge badge-pill badge-info"">ver 1.2 (2021-02-10)</span>
                                </div>
                                <div class=""timeline-body"">
                                    <p>데일리튼튼 관리자 상담기능 오픈</p>
                                </div>
                            </div>
                        </li>

                        <li class=""timeline-inverted"">
                            <div class=""timeline-badge danger"">
                                <i class=""nc-icon nc-lock-circle-open""></i>
                            </div>
                            <div class=""timeline-panel"">
              ");
            WriteLiteral(@"                  <div class=""timeline-heading"">
                                    <span class=""badge badge-pill badge-danger"">ver 1.1 (2021-02-04)</span>
                                </div>
                                <div class=""timeline-body"">
                                    <p>데일리튼튼 관리자사이트 오픈</p>
                                </div>
                            </div>
                        </li>

                        <li>
                            <div class=""timeline-badge warning"">
                                <i class=""nc-icon nc-istanbul""></i>
                            </div>
                            <div class=""timeline-panel"">
                                <div class=""timeline-heading"">
                                    <span class=""badge badge-pill badge-warning"">ver 1.0 (2021-02-01)</span>
                                </div>
                                <div class=""timeline-body"">
                                    <p>데일리튼튼 오픈</p>
        ");
            WriteLiteral("                        </div>\r\n                            </div> \r\n                        </li>\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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

#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d838861865ff8b38f2eb2304990a7791eb7c40c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DownloadList), @"mvc.1.0.view", @"/Views/Product/DownloadList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d838861865ff8b38f2eb2304990a7791eb7c40c1", @"/Views/Product/DownloadList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DownloadList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DailyTuntun.Models.ProductDownloadModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
  
    ViewData["Title"] = "DownloadList";

    int downloadKindId = (int)ViewData["DownloadKindID"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header page-header-xs\" style=\"background-image: url(\'/assets/img/bg_default3.png\');\">\r\n");
            WriteLiteral("    <div class=\"content-center\">\r\n        <div class=\"container\">\r\n            <div class=\"motto\">\r\n                <h3 class=\"title text-dark\"><b>필요한 컨텐츠를 다운로드 하세요.</b></h3>\r\n");
#nullable restore
#line 15 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                 if (downloadKindId == 22)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-pinterest\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 640, "\"", 741, 3);
            WriteAttributeValue("", 650, "window.location.href=\'", 650, 22, true);
#nullable restore
#line 17 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 672, Url.Action("DownloadList", "Product", new { downloadKindId = 22 }), 672, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 739, "\';", 739, 2, true);
            EndWriteAttribute();
            WriteLiteral(">New TLD</button>\r\n");
#nullable restore
#line 18 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-default\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 906, "\"", 1007, 3);
            WriteAttributeValue("", 916, "window.location.href=\'", 916, 22, true);
#nullable restore
#line 21 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 938, Url.Action("DownloadList", "Product", new { downloadKindId = 22 }), 938, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1005, "\';", 1005, 2, true);
            EndWriteAttribute();
            WriteLiteral(">New TLD</button>\r\n");
#nullable restore
#line 22 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                 if (downloadKindId == 24)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-pinterest\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1196, "\"", 1297, 3);
            WriteAttributeValue("", 1206, "window.location.href=\'", 1206, 22, true);
#nullable restore
#line 25 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 1228, Url.Action("DownloadList", "Product", new { downloadKindId = 24 }), 1228, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1295, "\';", 1295, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Magic Box</button>\r\n");
#nullable restore
#line 26 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-default\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1464, "\"", 1565, 3);
            WriteAttributeValue("", 1474, "window.location.href=\'", 1474, 22, true);
#nullable restore
#line 29 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 1496, Url.Action("DownloadList", "Product", new { downloadKindId = 24 }), 1496, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1563, "\';", 1563, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Magic Box</button>\r\n");
#nullable restore
#line 30 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                 if (downloadKindId == 21)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-pinterest\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1756, "\"", 1857, 3);
            WriteAttributeValue("", 1766, "window.location.href=\'", 1766, 22, true);
#nullable restore
#line 33 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 1788, Url.Action("DownloadList", "Product", new { downloadKindId = 21 }), 1788, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1855, "\';", 1855, 2, true);
            EndWriteAttribute();
            WriteLiteral(">TLD</button>\r\n");
#nullable restore
#line 34 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-default\" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2018, "\"", 2119, 3);
            WriteAttributeValue("", 2028, "window.location.href=\'", 2028, 22, true);
#nullable restore
#line 37 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 2050, Url.Action("DownloadList", "Product", new { downloadKindId = 21 }), 2050, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2117, "\';", 2117, 2, true);
            EndWriteAttribute();
            WriteLiteral(">TLD</button>\r\n");
#nullable restore
#line 38 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<div class=""main"">
    <div class=""section"">
        <div class=""container"">
            <div class=""motto"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        <div class=""text-center"">
                                            ");
#nullable restore
#line 55 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                       Write(Html.DisplayNameFor(model => model.FileKind));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 59 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        <div class=\"text-center\">\r\n                                            ");
#nullable restore
#line 63 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                       Write(Html.DisplayNameFor(model => model.FilePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </th>\r\n                                    <th>\r\n                                        <div class=\"text-center\">\r\n                                            ");
#nullable restore
#line 68 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </th>\r\n                                    <th>\r\n                                        <div class=\"text-center\">\r\n                                            ");
#nullable restore
#line 73 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 79 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <div class=\"text-center\">\r\n                                                ");
#nullable restore
#line 84 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FileKind));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 88 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <div class=\"text-center\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4771, "\"", 4822, 1);
#nullable restore
#line 92 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
WriteAttributeValue("", 4778, Html.DisplayFor(modelItem => item.FilePath), 4778, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    다운로드
                                                </a>
                                            </div>
                                        </td>
                                        <td>
                                            <div class=""text-center"">
                                                ");
#nullable restore
#line 99 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Version));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </td>
                                        <td>
                                            <div class=""text-center"">
                                                ");
#nullable restore
#line 104 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 108 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\DownloadList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DailyTuntun.Models.ProductDownloadModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

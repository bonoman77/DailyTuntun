#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d1608bf509bfb535fa3ba05c679f4038b11f140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_StreamTitleList), @"mvc.1.0.view", @"/Views/Admin/StreamTitleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d1608bf509bfb535fa3ba05c679f4038b11f140", @"/Views/Admin/StreamTitleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_StreamTitleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DailyTuntun.Models.AdminStreamTitleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "컨텐츠목록";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 12 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div class=""card-body"">
                    <div class=""toolbar"">
                        <!--        Here you can write extra buttons/actions for the toolbar              -->
                    </div>
                    <table id=""datatable"" class=""table table-striped table-bordered table-hover"" cellspacing=""0"" width=""100%"">
                        <thead class=""text-primary"">
                            <tr>
                                <th class=""text-center"" width=""10%"">");
#nullable restore
#line 21 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                                               Write(Html.DisplayNameFor(model => model.ContentTitleID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th class=\"text-center\" width=\"10%\">");
#nullable restore
#line 22 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                                               Write(Html.DisplayNameFor(model => model.ContentGroupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th class=\"text-center\" width=\"10%\">");
#nullable restore
#line 23 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                                               Write(Html.DisplayNameFor(model => model.TitleNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th class=\"text-center\" width=\"40%\">");
#nullable restore
#line 24 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                                               Write(Html.DisplayNameFor(model => model.ContentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th class=\"text-center\" width=\"10%\">");
#nullable restore
#line 25 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                                               Write(Html.DisplayNameFor(model => model.TotalContentCnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th class=\"text-center\" width=\"10%\">");
#nullable restore
#line 26 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                                               Write(Html.DisplayNameFor(model => model.DisplayYn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 30 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\" width=\"10%\">\r\n                                        ");
#nullable restore
#line 34 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ContentTitleID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\" width=\"10%\">\r\n                                        ");
#nullable restore
#line 37 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ContentGroupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\" width=\"10%\">\r\n                                        ");
#nullable restore
#line 40 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TitleNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-left\" width=\"40%\">\r\n                                        &nbsp;&nbsp;&nbsp;\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2592, "\"", 2686, 1);
#nullable restore
#line 44 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 2599, Url.Action("StreamContentList", "Admin", new { contentTitleId = item.ContentTitleID }), 2599, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 45 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ContentTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </td>\r\n                                    <td class=\"text-center\" width=\"10%\">\r\n                                        ");
#nullable restore
#line 49 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TotalContentCnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\" width=\"10%\">\r\n");
#nullable restore
#line 52 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                         if (item.DisplayYn == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 3335, "\"", 3364, 2);
            WriteAttributeValue("", 3340, "btn_", 3340, 4, true);
#nullable restore
#line 54 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 3344, item.ContentTitleID, 3344, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3365, "\"", 3412, 4);
            WriteAttributeValue("", 3375, "itemDisplay(", 3375, 12, true);
#nullable restore
#line 54 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 3387, item.ContentTitleID, 3387, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3407, ",", 3407, 1, true);
            WriteAttributeValue(" ", 3408, "0);", 3409, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-icon btn-sm\">\r\n                                                <i");
            BeginWriteAttribute("id", " id=\"", 3503, "\"", 3533, 2);
            WriteAttributeValue("", 3508, "icon_", 3508, 5, true);
#nullable restore
#line 55 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 3513, item.ContentTitleID, 3513, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-play\"></i>\r\n                                            </button>\r\n");
#nullable restore
#line 57 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 3812, "\"", 3841, 2);
            WriteAttributeValue("", 3817, "btn_", 3817, 4, true);
#nullable restore
#line 60 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 3821, item.ContentTitleID, 3821, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3842, "\"", 3889, 4);
            WriteAttributeValue("", 3852, "itemDisplay(", 3852, 12, true);
#nullable restore
#line 60 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 3864, item.ContentTitleID, 3864, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3884, ",", 3884, 1, true);
            WriteAttributeValue(" ", 3885, "1);", 3886, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-icon btn-sm\">\r\n                                                <i");
            BeginWriteAttribute("id", " id=\"", 3983, "\"", 4013, 2);
            WriteAttributeValue("", 3988, "icon_", 3988, 5, true);
#nullable restore
#line 61 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
WriteAttributeValue("", 3993, item.ContentTitleID, 3993, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-stop\"></i>\r\n                                            </button>\r\n");
#nullable restore
#line 63 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 66 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\StreamTitleList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- end content-->
            </div>
            <!--  end card  -->
        </div>
        <!-- end col-md-12 -->
    </div>
    <!-- end row -->
</div>

<script type=""text/javascript"">

    var itemDisplay = function (ContentTitleID, DisplayYn) {
        $.ajax({
            type: ""POST"",
            url: ""/Admin/StreamTitleDisplayUpdate"",
            data: { contentTitleId: ContentTitleID, displayYn: DisplayYn },
            success: function (result) {
                //location.reload();

                if (result.disYn === 1) {
                    document.getElementById(""btn_"" + ContentTitleID).className = 'btn btn-info btn-icon btn-sm';
                    document.getElementById(""btn_"" + ContentTitleID).setAttribute('onclick', 'itemDisplay(' + ContentTitleID + ', 0)')
                    document.getElementById(""icon_"" + ContentTitleID).className = 'fa fa-play';
          ");
            WriteLiteral(@"      } else {
                    document.getElementById(""btn_"" + ContentTitleID).className = 'btn btn-default btn-icon btn-sm';
                    document.getElementById(""btn_"" + ContentTitleID).setAttribute('onclick', 'itemDisplay(' + ContentTitleID + ', 1)')
                    document.getElementById(""icon_"" + ContentTitleID).className = 'fa fa-stop';
                }
            }
        });
    }

</script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DailyTuntun.Models.AdminStreamTitleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e67e2a3cac7c65b641208101be1cc1c8e7c0de6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MemberList), @"mvc.1.0.view", @"/Views/Admin/MemberList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e67e2a3cac7c65b641208101be1cc1c8e7c0de6", @"/Views/Admin/MemberList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MemberList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DailyTuntun.Models.AdminMemberModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consultForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MemberList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "회원관리";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e67e2a3cac7c65b641208101be1cc1c8e7c0de64940", async() => {
                WriteLiteral("\r\n                        <input name=\"pNum\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 449, "\"", 474, 1);
#nullable restore
#line 15 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 457, ViewData["Page"], 457, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"input-group no-border \">\r\n                                    <input type=\"text\" name=\"searchText\"");
                BeginWriteAttribute("value", " value=\"", 717, "\"", 748, 1);
#nullable restore
#line 19 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 725, ViewData["SearchText"], 725, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""이름/이메일 검색..."" autofocus>
                                </div>
                            </div>
                            <div class=""col-md-1"">
                                <div class=""input-group no-border "">
                                    <button class=""btn btn-success"" type=""submit"" style=""margin-top: 0px;""><i class=""fa fa-search""></i></button>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 36 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive-sm"">
                        <table class=""table table-hover"">
                            <thead class=""text-primary"">
                                <tr>
                                    <th class=""text-center"" width=""8%"">회원ID</th>
                                    <th class=""text-center"" width=""10%"">");
#nullable restore
#line 44 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                   Write(Html.DisplayNameFor(model => model.MemberCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-center\" width=\"15%\">");
#nullable restore
#line 45 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                   Write(Html.DisplayNameFor(model => model.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-center\" width=\"30%\">");
#nullable restore
#line 46 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                   Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th class=\"text-center\" width=\"7%\">");
#nullable restore
#line 47 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                  Write(Html.DisplayNameFor(model => model.MemberType));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    <th class=""text-center"" width=""10%"">상담이력</th>
                                    <th class=""text-center"" width=""8%"">상담등록</th>
                                    <th class=""text-center"" width=""5%"">로그인</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 54 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                 if (Model.Count() == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td class=""text-center"" colspan=""8"">
                                            자료가 없습니다.
                                        </td>
                                    </tr>
");
#nullable restore
#line 61 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" width=\"8%\">\r\n                                                ");
#nullable restore
#line 68 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.MemberID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"text-center\" width=\"10%\">\r\n                                                ");
#nullable restore
#line 71 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.MemberCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"text-center\" width=\"15%\">\r\n");
#nullable restore
#line 74 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                 if (item.AuthYn == true)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.MemberName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                                                  
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"text-warning\">\r\n                                                        ");
#nullable restore
#line 81 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n");
#nullable restore
#line 83 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td class=\"text-center\" width=\"30%\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4762, "\"", 4821, 2);
            WriteAttributeValue("", 4769, "mailto:", 4769, 7, true);
#nullable restore
#line 86 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 4776, Html.DisplayFor(modelItem => item.UserEmail), 4776, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 87 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.UserEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </td>\r\n                                            <td class=\"text-center\" width=\"7%\">\r\n                                                ");
#nullable restore
#line 91 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.MemberType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"text-center\" width=\"10%\">\r\n");
#nullable restore
#line 94 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                 if (item.CounselCnt > 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5519, "\"", 5601, 1);
#nullable restore
#line 96 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 5526, Url.Action("MemberCounselList", "Admin", new { memberId = item.MemberID }), 5526, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 97 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CompleteCnt));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /\r\n                                                        ");
#nullable restore
#line 98 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CounselCnt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n");
#nullable restore
#line 100 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CounselCnt));

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                                                  
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td class=\"text-center\" width=\"8%\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6363, "\"", 6443, 1);
#nullable restore
#line 107 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 6370, Url.Action("CounselRegister", "Admin", new { memberId = item.MemberID }), 6370, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success btn-link btn-icon edit"">
                                                    <i class=""fa fa-edit""></i>
                                                </a>
                                            </td>
                                            <td class=""text-center"" width=""8%"">
                                                <button type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 6829, "\"", 6926, 3);
            WriteAttributeValue("", 6839, "location.href=\'", 6839, 15, true);
#nullable restore
#line 112 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 6854, Url.Action("MemberUpdate", "Admin", new { memberId = item.MemberID }), 6854, 70, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6924, "\';", 6924, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-icon btn-sm"">
                                                    <i class=""nc-icon nc-settings-gear-65""></i>
                                                </button>
                                                <button type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 7192, "\"", 7288, 3);
            WriteAttributeValue("", 7202, "location.href=\'", 7202, 15, true);
#nullable restore
#line 115 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 7217, Url.Action("MemberLogIn", "Admin", new { memberId = item.MemberID }), 7217, 69, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7286, "\';", 7286, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger btn-icon btn-sm"">
                                                    <i class=""nc-icon nc-button-play""></i>
                                                </button>
                                            </td>
                                        </tr>
");
#nullable restore
#line 120 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <!-- end content-->
                </div>
                <!--  end card  -->
            </div>

            <!-- PAGE NAVIGATION START -->
");
#nullable restore
#line 131 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
              
                string controllerName = ViewContext.RouteData.Values["Controller"].ToString();
                string actionName = ViewContext.RouteData.Values["Action"].ToString();

                var maxPage = (int)ViewData["NowPageStartNum"] + (int)ViewData["PageListSize"];
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 138 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
             if ((int)ViewData["NowPageStartNum"] + (int)ViewData["PageListSize"] >= (int)ViewData["EndPageNum"])
            {
                maxPage = (int)ViewData["EndPageNum"] + 1;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <nav aria-label=\"Page navigation\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <ul class=\"pagination\">\r\n");
#nullable restore
#line 147 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                             if ((bool)ViewData["PrePageYn"] == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 8836, "\"", 9010, 1);
#nullable restore
#line 150 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 8843, Url.Action(actionName, controllerName,  new {page=ViewData["PrePageButtonNum"], sDate=ViewData["StartDate"], eDate=ViewData["EndDate"], sText=ViewData["SearchText"]}), 8843, 167, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span aria-hidden=\"true\"><i class=\"fa fa-angle-double-left\" aria-hidden=\"true\"></i></span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 154 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                             for (int i = (int)ViewData["NowPageStartNum"]; i < @maxPage; i++)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                 if ((int)ViewData["Page"] == i)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9571, "\"", 9718, 1);
#nullable restore
#line 159 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 9578, Url.Action(actionName, controllerName, new {page=@i, sDate=ViewData["StartDate"], eDate=ViewData["EndDate"], sText=ViewData["SearchText"]}), 9578, 140, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 159 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                                                                                                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 160 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9919, "\"", 10066, 1);
#nullable restore
#line 163 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 9926, Url.Action(actionName, controllerName, new {page=@i, sDate=ViewData["StartDate"], eDate=ViewData["EndDate"], sText=ViewData["SearchText"]}), 9926, 140, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 163 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                                                                                                                                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 164 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                             if ((bool)ViewData["NextPageYn"] == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 10362, "\"", 10536, 1);
#nullable restore
#line 169 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
WriteAttributeValue("", 10369, Url.Action(actionName, controllerName, new {page=ViewData["nextPageButtonNum"], sDate=ViewData["StartDate"], eDate=ViewData["EndDate"], sText=ViewData["SearchText"]}), 10369, 167, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <span aria-hidden=\"true\"><i class=\"fa fa-angle-double-right\" aria-hidden=\"true\"></i></span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 173 "D:\Development\DailyTuntun\DailyTuntun\Views\Admin\MemberList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </nav>\r\n            <!-- PAGE NAVIGATION END -->\r\n            <!-- end col-md-12 -->\r\n        </div>\r\n        <!-- end row -->\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DailyTuntun.Models.AdminMemberModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

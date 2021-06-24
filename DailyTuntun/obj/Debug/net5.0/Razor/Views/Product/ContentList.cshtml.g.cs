#pragma checksum "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4be812002c923bab946db209b2c32c0f97c9254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ContentList), @"mvc.1.0.view", @"/Views/Product/ContentList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4be812002c923bab946db209b2c32c0f97c9254", @"/Views/Product/ContentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0040501acec14a2f264eb5de0f3b9783d3289dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ContentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DailyTuntun.Models.ProductContentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
  
    ViewData["Title"] = "ContentList";

    int contentTitleId = (int)ViewData["ContentTitleID"];
    string contentTitle = (string)ViewData["ContentTitle"];
    string contentImageURL = (string)ViewData["ContentImageURL"];
    string contentGroupImageURL = (string)ViewData["ContentGroupImageURL"];

    int productKindId = (int)ViewData["ProductKindID"];

    string bgPath = "/assets/img/sub/bg_gray.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--<div class=\"page-header page-header-small\" style=\"background-image: url(\'");
#nullable restore
#line 15 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                                                                        Write(bgPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\">-->\r\n");
            WriteLiteral("    <!--<div class=\"content-center\">\r\n        <div class=\"container\">\r\n            <div class=\"motto\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <img src=\"");
#nullable restore
#line 22 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                             Write(contentImageURL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""Rounded Image"" class=""img-rounded img-tweet-link img-responsive"" style=""max-width:150px"">
                    </div>
                    <div class=""col-md-6"">
                        <div class=""description"">
                            <img src=""");
#nullable restore
#line 26 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                                 Write(contentGroupImageURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" width=\"100\" />\r\n                        </div>\r\n                        <br />\r\n                        <h5 class=\"description text-dark-berry\">");
#nullable restore
#line 29 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                                                           Write(contentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <br />\r\n                        <button type=\"button\" class=\"btn btn-reddit\" onclick=\"resetPlay(");
#nullable restore
#line 31 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                                                                                   Write(contentTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\">시청 초기화</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>-->\r\n\r\n\r\n\r\n<div class=\"page-header page-header-small\"");
            BeginWriteAttribute("style", " style=\"", 1612, "\"", 1653, 4);
            WriteAttributeValue("", 1620, "background-image:", 1620, 17, true);
            WriteAttributeValue(" ", 1637, "url(\'", 1638, 6, true);
#nullable restore
#line 41 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 1643, bgPath, 1643, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1650, "\');", 1650, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("    <div class=\"content-center sub-center block-header\">\r\n        <div class=\"container\">\r\n            <div class=\"motto\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-6\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1921, "\"", 1943, 1);
#nullable restore
#line 48 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 1927, contentImageURL, 1927, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-tweet-link img-responsive\" style=\"max-height:200px\">\r\n                    </div>\r\n                    <div class=\"col-6 contentlist\">\r\n                        <div class=\"description\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2174, "\"", 2201, 1);
#nullable restore
#line 52 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 2180, contentGroupImageURL, 2180, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"70\" />\r\n                        </div>\r\n                        <br />\r\n                        <h5 class=\"description\">");
#nullable restore
#line 55 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                                           Write(contentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <button type=\"button\" class=\"btn btn-youtube\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2420, "\"", 2457, 3);
            WriteAttributeValue("", 2430, "resetPlay(", 2430, 10, true);
#nullable restore
#line 56 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 2440, contentTitleId, 2440, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2455, ");", 2455, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">시청 초기화</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>






<div class=""main"">
    <div class=""wrapper"">
        <!-- section -->
        <div class=""section section-blog"">
            <div class=""container"">
                <div class=""row"">

");
#nullable restore
#line 76 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                     if (Model.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <br /><br />
                        <div class=""row"">
                            <div class=""col-md-12 col-sm-12"">
                                <h3>자료가 없습니다.</h3>
                            </div>
                        </div>
                        <br /><br />
");
#nullable restore
#line 85 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"

                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-2 col-md-3 col-sm-6\">\r\n                                <div class=\"card card-product card-plain text-center\">\r\n                                    <div class=\"card-image\"");
            BeginWriteAttribute("id", " id=\"", 3530, "\"", 3556, 2);
            WriteAttributeValue("", 3535, "image_", 3535, 6, true);
#nullable restore
#line 93 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 3541, item.ContentID, 3541, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: block;\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3626, "\"", 3701, 3);
            WriteAttributeValue("", 3633, "javascript:playModal(", 3633, 21, true);
#nullable restore
#line 94 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 3654, Html.DisplayFor(modelItem => item.ContentID), 3654, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3699, ");", 3699, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3753, "\"", 3803, 1);
#nullable restore
#line 95 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 3759, Html.DisplayFor(modelItem => item.ImageURL), 3759, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Rounded Image\" class=\"img-thumbnail img-no-padding img-responsive\">\r\n                                        </a>\r\n                                    </div>\r\n                                    <div class=\"card-image\"");
            BeginWriteAttribute("id", " id=\"", 4028, "\"", 4057, 2);
            WriteAttributeValue("", 4033, "imageCom_", 4033, 9, true);
#nullable restore
#line 98 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 4042, item.ContentID, 4042, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4126, "\"", 4201, 3);
            WriteAttributeValue("", 4133, "javascript:playModal(", 4133, 21, true);
#nullable restore
#line 99 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 4154, Html.DisplayFor(modelItem => item.ContentID), 4154, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4199, ");", 4199, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 4253, "\"", 4311, 1);
#nullable restore
#line 100 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 4259, Html.DisplayFor(modelItem => item.CompleteImageURL), 4259, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Rounded Image\" class=\"img-thumbnail img-no-padding img-responsive\">\r\n                                        </a>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
            WriteLiteral("                            <!-- play modal -->\r\n                            <div class=\"modal\"");
            BeginWriteAttribute("id", " id=\"", 4652, "\"", 4677, 2);
            WriteAttributeValue("", 4657, "play_", 4657, 5, true);
#nullable restore
#line 108 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 4662, item.ContentID, 4662, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"" data-backdrop=""false"">
                                <div class=""modal-dialog modal-notice"">
                                    <div class=""modal-content"">
                                        <div class=""modal-body"" style=""padding-left: 10px; padding-right: 10px;"">
                                            <div class=""instruction"">
                                                <div class=""row"">
                                                    <div class=""col-md-12"">
                                                        <div class=""card card-body card-plain"">
                                                            <iframe");
            BeginWriteAttribute("src", " src=\"", 5413, "\"", 5464, 1);
#nullable restore
#line 116 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 5419, Html.DisplayFor(modelItem => item.StreamURL), 5419, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5465, "\"", 5493, 2);
            WriteAttributeValue("", 5470, "content_", 5470, 8, true);
#nullable restore
#line 116 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
WriteAttributeValue("", 5478, item.ContentID, 5478, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0"" playsinline=""false"" allow=""autoplay; fullscreen"" webkitallowfullscreen mozallowfullscreen allowfullscreen style=""max-width: none !important""></iframe>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-primary btn-link"" data-dismiss=""modal"">닫기</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 141 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                                       
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "D:\Development\DailyTuntun\DailyTuntun\Views\Product\ContentList.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>


<script src=""https://player.vimeo.com/api/player.js""></script>
<script type=""text/javascript"">


    function playModal(ContentID) {

        var cId = ContentID;

        $.ajax({
            type: ""POST"",
            url: ""/Product/ContentViewCheck"",
            data: { contentId: cId },
            success: function (result) {
                document.getElementById(""image_"" + cId).style.display = ""none"";
                document.getElementById(""imageCom_"" + cId).style.display = ""block"";
            }
        });

        $(""#play_"" + cId).modal(""show"");
    }

    function resetPlay(ContentTitleID) {

        $.ajax({
            type: ""POST"",
            url: ""/Product/ContentViewCheckReset"",
            data: { contentTitleId: ContentTitleID },
            success: function (result) {
                window.location.reload();
            }
        });

        $(""#play_"" + cId).modal(""show");
            WriteLiteral(@""");
    }

    $(function () {
        $('.modal, .close').click(function () {
            $(""iframe"").each(function () {
                var src = $(this).attr('src');
                $(this).attr('src', src);
            });
        });
    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DailyTuntun.Models.ProductContentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

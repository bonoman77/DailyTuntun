using System;
using System.Security.Claims;
using DailyTuntun.DbConns;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DailyTuntun.Models;

namespace DailyTuntun.Controllers
{
    public class ProductController : Controller
    {
        public enum ProductKindId
        {
            Preshool = 3,
        }
        public enum ProductKindSubId
        {
            Age4 = 6,
            Age5 = 7,
            Age6 = 8,
            Age7 = 9,
            Special = 10
        }

        public enum DownloadKindId
        {
            Guide = 21,
        }

        [HttpGet]
        public IActionResult MainList(int productKindId)
        {
            ViewData["ProductKindID"] = productKindId;

            if (Enum.IsDefined(typeof(ProductKindId), productKindId))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ProductKindID", productKindId);
                return View(DapperORM.ReturnList<ProductGroupModel>("uspGetDailyContentGroupList", param));
            }
            else
            {
                return RedirectToAction("ContentAuthError", "Product");
            }
        }

        [HttpGet]
        public IActionResult TitleList(int productKindId, int contentGroupId)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            string proc;
            string procList;

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var managerYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberManagerYn", paramManager);

            if (Enum.IsDefined(typeof(ProductKindId), productKindId))
            {
                if (managerYn == true)
                {
                    proc = "uspGetDailyContentGroupDetailManager";
                    procList = "uspGetDailyContentTitleListManager";
                }
                else
                {
                    proc = "uspGetDailyContentGroupDetail";
                    procList = "uspGetDailyContentTitleList";
                }
            }
            else
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            DynamicParameters paramGroup = new DynamicParameters();
            paramGroup.Add("@MemberID", memberId);
            paramGroup.Add("@ContentGroupID", contentGroupId);





            ProductGroupModel model = DapperORM.ExecuteReturn<ProductGroupModel>(proc, paramGroup);

            if (model == null)
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            ViewData["ProductKindID"] = productKindId;
            ViewData["ProductKindName"] = model.ProductKindName;
            ViewData["ProductKindSubName"] = model.ProductKindSubName;
            ViewData["ContentGroupID"] = model.ContentGroupID;
            ViewData["ContentGroupName"] = model.ContentGroupName;

            ViewData["ContentGroupImageURL"] = model.ContentGroupImageURL;
            ViewData["Comment"] = model.Comment;
            ViewData["AuthYn"] = model.AuthYn;

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            param.Add("@ContentGroupID", contentGroupId);
            return View(DapperORM.ReturnList<ProductTitleModel>(procList, param));
        }

        [HttpGet]
        public IActionResult ContentList(int productKindId, int contentTitleId)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account");
            }

            string proc;
            string procList;

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var managerYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberManagerYn", paramManager);

            if (Enum.IsDefined(typeof(ProductKindId), productKindId))
            {

                if (managerYn == true)
                {
                    proc = "uspGetDailyContentTitleDetailManager";
                    procList = "uspGetDailyContentListManager";
                }
                else
                {
                    proc = "uspGetDailyContentTitleDetail";
                    procList = "uspGetDailyContentList";
                }
            }
            else
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            DynamicParameters paramTitle = new DynamicParameters();
            paramTitle.Add("@MemberID", memberId);
            paramTitle.Add("@ContentTitleID", contentTitleId);
            ProductTitleModel model = DapperORM.ExecuteReturn<ProductTitleModel>(proc, paramTitle);

            if (model == null || model.AuthYn == false)
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            ViewData["ProductKindID"] = productKindId;
            ViewData["ContentTitleID"] = contentTitleId;
            ViewData["ContentTitle"] = model.ContentTitle;
            ViewData["ContentImageURL"] = model.ContentImageURL;
            ViewData["ContentGroupImageURL"] = model.ContentGroupImageURL;

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            param.Add("@ContentTitleID", contentTitleId);
            return View(DapperORM.ReturnList<ProductContentModel>(procList, param));
        }


        [HttpGet]
        public IActionResult ContentMapList(int productKindId, int contentTitleId)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account");
            }

            DynamicParameters paramOption = new DynamicParameters();
            paramOption.Add("@MemberID", memberId);
            bool responsiveYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberResponsiveYn", paramOption);

            if (responsiveYn == true)
            {
                return RedirectToAction("ContentList", "Product", new { productKindId = productKindId, contentTitleId = contentTitleId });
            }

            string proc;
            string procList;

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var managerYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberManagerYn", paramManager);

            if (Enum.IsDefined(typeof(ProductKindId), productKindId))
            {

                if (managerYn == true)
                {
                    proc = "uspGetDailyContentTitleDetailManager";
                    procList = "uspGetDailyContentListManager";
                }
                else
                {
                    proc = "uspGetDailyContentTitleDetail";
                    procList = "uspGetDailyContentList";
                }
            }
            else
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            DynamicParameters paramTitle = new DynamicParameters();
            paramTitle.Add("@MemberID", memberId);
            paramTitle.Add("@ContentTitleID", contentTitleId);
            ProductTitleModel model = DapperORM.ExecuteReturn<ProductTitleModel>(proc, paramTitle);

            if (model == null || model.AuthYn == false)
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            ViewData["ProductKindID"] = productKindId;
            ViewData["ContentTitleID"] = contentTitleId;
            ViewData["ContentTitle"] = model.ContentTitle;
            ViewData["ContentImageURL"] = model.ContentImageURL;
            ViewData["ContentGroupID"] = model.ContentGroupID;
            ViewData["ContentGroupImageURL"] = model.ContentGroupImageURL;

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            param.Add("@ContentTitleID", contentTitleId);
            return View(DapperORM.ReturnList<ProductContentModel>(procList, param));
        }


        [HttpPost]
        public JsonResult ContentViewCheck(int contentId)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (ModelState.IsValid)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                param.Add("@ContentID", contentId);
                DapperORM.ExecuteWithoutReturn("uspSetDailyContentViewCheck", param);
            }
            return Json(contentId);
        }

        [HttpPost]
        public JsonResult ContentViewCheckReset(int contentTitleId)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (ModelState.IsValid)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                param.Add("@ContentTitleID", contentTitleId);
                DapperORM.ExecuteWithoutReturn("uspSetDailyContentViewCheckReset", param);
            }
            return Json(contentTitleId);
        }


        [HttpGet]
        public IActionResult DownloadList(int downloadKindId = 21)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account");
            }

            string procList;

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var managerYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberManagerYn", paramManager);

            if (Enum.IsDefined(typeof(DownloadKindId), downloadKindId))
            {

                if (managerYn == true)
                {
                    procList = "uspGetDailyDownloadListManager";
                }
                else
                {
                    procList = "uspGetDailyDownloadList";
                }
            }
            else
            {
                return RedirectToAction("ContentAuthError", "Product");
            }

            ViewData["DownloadKindID"] = downloadKindId;

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            param.Add("@DownloadKindID", downloadKindId);
            return View(DapperORM.ReturnList<ProductDownloadModel>(procList, param));
        }

        [HttpGet]
        public IActionResult ContentAuthError()
        {
            return View();
        }
    }
}
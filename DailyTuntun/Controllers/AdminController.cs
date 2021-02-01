using Dapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DailyTuntun.DbConns;
using DailyTuntun.Models;



namespace DailyTuntun.Controllers
{
    public class AdminController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account", new { managerYn = true });
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetStreamMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            return RedirectToAction("MemberList", "Admin");
        }

        [HttpGet]
        public IActionResult MemberList(int page = 1, string searchText = null)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account", new { managerYn = true });
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetStreamMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            ViewData["SearchText"] = searchText;


            DynamicParameters paramCnt = new DynamicParameters();
            paramCnt.Add("@SearchText", searchText);
            var listCnt = DapperORM.ExecuteReturn<AdminMemberCntModel>("uspGetStreamAdminMemberCnt", paramCnt);

            var pageSize = 30;

            CommonController Common = new CommonController();
            Common.PagedList(page, listCnt.TotalCnt, pageSize);

            ViewData["Page"] = page;
            ViewData["EndPageNum"] = Common.EndPageNum;
            ViewData["NowPageStartNum"] = Common.NowPageStartNum;
            ViewData["PageListSize"] = Common.PageListSize;

            ViewData["PrePageYn"] = Common.PrePageYn;
            ViewData["PrePageButtonNum"] = Common.PrePageButtonNum;
            ViewData["NextPageYn"] = Common.NextPageYn;
            ViewData["NextPageButtonNum"] = Common.NextPageButtonNum;

            DynamicParameters param = new DynamicParameters();
            param.Add("@PageSize", Common.PageSize);
            param.Add("@pageNumber", page);
            param.Add("@SearchText", searchText);
            return View(DapperORM.ReturnList<AdminMemberModel>("uspGetStreamAdminMemberList", param));
        }

        [HttpGet]
        public IActionResult MemberCounselList()
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account", new { managerYn = true });
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetStreamMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            return View(DapperORM.ReturnList<AdminMemberCounselModel>("uspGetStreamAdminMemberCounselOneList", param));
        }


        [HttpGet]
        public IActionResult MemberUpdate(int memberId)
        {
            //ViewData["Page"] = page;
            //ViewData["SearchText"] = searchText;

            DynamicParameters paramMember = new DynamicParameters();
            paramMember.Add("@MemberID", memberId);
            ViewBag.MemberList = DapperORM.ReturnList<AdminMemberDetailModel>("uspGetStreamMemberCodeList", paramMember);

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            return View(DapperORM.ExecuteReturn<AdminMemberDetailModel>("uspGetStreamMemberDetail", param));
        }

        [HttpPost]
        public IActionResult MemberUpdate(AdminMemberDetailModel model)
        {
            DynamicParameters paramMember = new DynamicParameters();
            paramMember.Add("@MemberID", model.MemberID);
            ViewBag.MemberList = DapperORM.ReturnList<AdminMemberDetailModel>("uspGetStreamMemberCodeList", paramMember);

            if (ModelState.IsValid)
            {
                try
                {
                    CommonController Common = new CommonController();
                    string authCode = Common.GenerateRandomPassword();

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@MemberID", model.MemberID);
                    param.Add("@UserEmail", model.UserEmail);
                    param.Add("@UserNewEmail", model.UserNewEmail);
                    param.Add("@AuthCode", authCode);
                    var returnVal = DapperORM.ExecuteReturn<int>("uspSetStreamAdminMemberEmailUpdate", param);

                    if (returnVal == 1)
                    {
                        Common.SendMail(model.UserNewEmail, model.MemberName, authCode, AuthTypeId.UpdateEmail, model.ManagerYn);
                        return RedirectToAction("MemberList", "Admin");
                    }
                    if (returnVal == 2)
                    {
                        ModelState.AddModelError("", "이미 사용중인 이메일입니다.");
                        return View(model);
                    }
                    else
                    {
                        ModelState.AddModelError("", "이메일 변경에 실패하였습니다. 개발사에 문의하세요.");
                        return View(model);
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "이메일 변경에 실패하였습니다. 개발사에 문의하세요.");
                    return View(model);
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult CounselList(int page = 1, string searchText = null)
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account", new { managerYn = true });
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetStreamMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            ViewData["SearchText"] = searchText;


            DynamicParameters paramCnt = new DynamicParameters();
            paramCnt.Add("@SearchText", searchText);
            var listCnt = DapperORM.ExecuteReturn<AdminMemberCntModel>("uspGetStreamAdminMemberCounselCnt", paramCnt);

            var pageSize = 30;

            CommonController Common = new CommonController();
            Common.PagedList(page, listCnt.TotalCnt, pageSize);

            ViewData["Page"] = page;
            ViewData["EndPageNum"] = Common.EndPageNum;
            ViewData["NowPageStartNum"] = Common.NowPageStartNum;
            ViewData["PageListSize"] = Common.PageListSize;

            ViewData["PrePageYn"] = Common.PrePageYn;
            ViewData["PrePageButtonNum"] = Common.PrePageButtonNum;
            ViewData["NextPageYn"] = Common.NextPageYn;
            ViewData["NextPageButtonNum"] = Common.NextPageButtonNum;

            DynamicParameters param = new DynamicParameters();
            param.Add("@PageSize", Common.PageSize);
            param.Add("@pageNumber", page);
            param.Add("@SearchText", searchText);
            return View(DapperORM.ReturnList<AdminMemberModel>("uspGetStreamAdminMemberCounselList", param));
        }

        [HttpGet]
        public IActionResult CounselRegist()
        {
            //uspSetStreamAdminMemberCounselInsert
            return View();
        }

        [HttpGet]
        public IActionResult CounselUpdate()
        {
            //uspSetStreamAdminMemberCounselUpdate
            return View();
        }

        [HttpGet]
        public IActionResult CounselDelete()
        {
            //uspSetStreamAdminMemberCounselDelete
            return View();
        }

        [HttpGet]
        public IActionResult CounselComplete()
        {
            //uspSetStreamAdminMemberCounselComplete            
            return View();
        }

        [HttpGet]
        public IActionResult AdminAuthError()
        {
            return View();
        }


        [HttpPost]
        public JsonResult ReAuthEmail(int memberId)
        {
            var isValid = true;

            try
            {
                CommonController Common = new CommonController();
                string authCode = Common.GenerateRandomPassword();

                DynamicParameters paramInfo = new DynamicParameters();
                paramInfo.Add("@MemberID", memberId);
                var joinInfo = DapperORM.ReturnList<AdminMemberBasicModel>("uspGetStreamAdminMemberBasicInfo", paramInfo).FirstOrDefault<AdminMemberBasicModel>();

                if (joinInfo == null)
                    isValid = false;

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                param.Add("@AuthCode", authCode);
                var join = DapperORM.ExecuteReturn<int>("uspSetStreamAdminMemberEmailReAuthRequest", param);

                if (join == 0)
                {
                    isValid = false;
                }
                else
                {
                    Common.SendMail(joinInfo.UserEmail, joinInfo.MemberName, authCode, AuthTypeId.ReAuth, joinInfo.ManagerYn);
                }

                return Json(new { success = isValid });
            }
            catch
            {
                return Json(new { success = false });
            }
        }


        [HttpPost]
        public JsonResult ResetPassword(int memberId)
        {
            var isValid = true;

            try
            {
                CommonController Common = new CommonController();
                string authCode = Common.GenerateRandomPassword();

                DynamicParameters paramInfo = new DynamicParameters();
                paramInfo.Add("@MemberID", memberId);
                var joinInfo = DapperORM.ReturnList<AdminMemberBasicModel>("uspGetStreamAdminMemberBasicInfo", paramInfo).FirstOrDefault<AdminMemberBasicModel>();

                if (joinInfo == null)
                    isValid = false;

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                param.Add("@AuthCode", authCode);
                var join = DapperORM.ExecuteReturn<int>("uspSetStreamAdmimMemberPassReset", param);

                if (join == 0)
                {
                    isValid = false;
                }
                else
                {
                    Common.SendMail(joinInfo.UserEmail, joinInfo.MemberName, authCode, AuthTypeId.LostPass, joinInfo.ManagerYn);
                }

                return Json(new { success = isValid });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public JsonResult DeleteMember(int memberId)
        {
            int deleteMemberId = 0;

            if (User.Identity.IsAuthenticated)
                deleteMemberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            if (memberId > 0)
            {
                param.Add("@DeleteMemberID", deleteMemberId);
            }
            DapperORM.ExecuteWithoutReturn("uspSetStreamMemberOut", param);

            var result = true;
            return Json(result);
        }



        [HttpGet]
        public IActionResult ContentList()
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memberId == 0)
            {
                return RedirectToAction("LogIn", "Account", new { managerYn = true });
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetStreamMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            return View(DapperORM.ReturnList<AdminContentModel>("uspGetStreamAdminContentList"));
        }



    }
}

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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberAdminYn", paramManager);

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
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            ViewData["SearchText"] = searchText;


            DynamicParameters paramCnt = new DynamicParameters();
            paramCnt.Add("@SearchText", searchText);
            var listCnt = DapperORM.ExecuteReturn<int>("uspGetDailyAdminMemberCnt", paramCnt);

            var pageSize = 30;

            CommonController Common = new CommonController();
            Common.PagedList(page, listCnt, pageSize);

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
            return View(DapperORM.ReturnList<AdminMemberModel>("uspGetDailyAdminMemberList", param));
        }

        [HttpGet]
        public IActionResult MemberUpdate(int memberId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            return View(DapperORM.ExecuteReturn<AdminMemberDetailModel>("uspGetDailyMemberDetail", param));
        }

        [HttpPost]
        public IActionResult MemberUpdate(AdminMemberDetailModel model)
        {
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
                    var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyAdminMemberEmailUpdate", param);

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
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            ViewData["SearchText"] = searchText;


            DynamicParameters paramCnt = new DynamicParameters();
            paramCnt.Add("@SearchText", searchText);
            var listCnt = DapperORM.ExecuteReturn<int>("uspGetDailyAdminConsultCnt", paramCnt);

            var pageSize = 30;

            CommonController Common = new CommonController();
            Common.PagedList(page, listCnt, pageSize);

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
            return View(DapperORM.ReturnList<AdminMemberModel>("uspGetDailyAdminConsultList", param));
        }


        [HttpGet]
        public IActionResult MemberCounselList(int memberId)
        {
            int memId = 0;

            if (User.Identity.IsAuthenticated)
                memId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (memId == 0)
            {
                return RedirectToAction("LogIn", "Account", new { managerYn = true });
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memId);
            var adminYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberAdminYn", paramManager);

            if (adminYn != true)
            {
                return RedirectToAction("AdminAuthError", "Admin");
            }

            ViewData["MemberID"] = memberId;

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            return View(DapperORM.ReturnList<AdminCounselModel>("uspGetDailyAdminMemberConsultList", param));
        }


        [HttpGet]
        public IActionResult CounselRegister(int memberId)
        {
            CommonController Common = new CommonController();

            List<CommonCateModel> counselKindList = Common.CommonList("CounselKindID");
            ViewBag.counselKindList = new SelectList(counselKindList, "CommonCateID", "CommonCateName");

            ViewData["memberId"] = memberId;

            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                return View(DapperORM.ExecuteReturn<AdminCounselDetailModel>("uspGetDailyMemberDetail", param));
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home", new { exception = ex });
            }
        }

        [HttpPost]
        public IActionResult CounselRegister(AdminCounselDetailModel model)
        {
            DynamicParameters param = new DynamicParameters();

            if (ModelState.IsValid)
            {
                param.Add("@MemberID", model.MemberID);
                param.Add("@Title", model.Title);
                param.Add("@Contents", model.Contents);
                param.Add("@Mobile", model.Mobile);
                param.Add("@CounselKindID", model.CounselKindID);
                param.Add("@ContactDate", model.ContactDate);
                param.Add("@CompleteDate", model.CompleteDate);
                
                DapperORM.ExecuteWithoutReturn("uspSetDailyAdminConsultInsert", param);

                return RedirectToAction("MemberList", "Admin");
            }

            CommonController Common = new CommonController();

            List<CommonCateModel> counselKindList = Common.CommonList("CounselKindID");
            ViewBag.counselKindList = new SelectList(counselKindList, "CommonCateID", "CommonCateName");

            return View(model);
        }

        [HttpGet]
        public IActionResult CounselUpdate(int counselId)
        {
            CommonController Common = new CommonController();

            List<CommonCateModel> counselKindList = Common.CommonList("CounselKindID");
            ViewBag.counselKindList = new SelectList(counselKindList, "CommonCateID", "CommonCateName");

            ViewData["counselId"] = counselId;

            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CounselID", counselId);
                return View(DapperORM.ExecuteReturn<AdminCounselDetailModel>("uspGetDailyAdminConsultDetail", param));
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home", new { exception = ex });
            }
        }

        [HttpPost]
        public IActionResult CounselUpdate(AdminCounselDetailModel model)
        {
            DynamicParameters param = new DynamicParameters();

            if (ModelState.IsValid)
            {
                param.Add("@CounselID", model.CounselID);
                param.Add("@Title", model.Title);
                param.Add("@Contents", model.Contents);
                param.Add("@Mobile", model.Mobile);
                param.Add("@CounselKindID", model.CounselKindID);
                param.Add("@ContactDate", model.ContactDate);
                param.Add("@CompleteDate", model.CompleteDate);

                DapperORM.ExecuteWithoutReturn("uspSetDailyAdminConsultUpdate", param);

                return RedirectToAction("MemberList", "Admin");
            }

            CommonController Common = new CommonController();

            List<CommonCateModel> counselKindList = Common.CommonList("CounselKindID");
            ViewBag.counselKindList = new SelectList(counselKindList, "CommonCateID", "CommonCateName");

            return View(model);
        }

        [HttpPost]
        public JsonResult CounselDelete(int counselId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CounselID", counselId);
            DapperORM.ExecuteWithoutReturn("uspSetDailyAdminConsultDelete", param);

            return Json(new { success = true });
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
                var joinInfo = DapperORM.ReturnList<AdminMemberBasicModel>("uspGetDailyAdminMemberBasicInfo", paramInfo).FirstOrDefault<AdminMemberBasicModel>();

                if (joinInfo == null)
                    isValid = false;

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                param.Add("@AuthCode", authCode);
                var join = DapperORM.ExecuteReturn<int>("uspSetDailyAdminMemberEmailReAuthRequest", param);

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
                var joinInfo = DapperORM.ReturnList<AdminMemberBasicModel>("uspGetDailyAdminMemberBasicInfo", paramInfo).FirstOrDefault<AdminMemberBasicModel>();

                if (joinInfo == null)
                    isValid = false;

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                param.Add("@AuthCode", authCode);
                var join = DapperORM.ExecuteReturn<int>("uspSetDailyAdminMemberPassReset", param);

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
            DapperORM.ExecuteWithoutReturn("uspSetDailyMemberOut", param);

            var result = true;
            return Json(result);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> MemberLogIn(int memberId)
        {
            if (ModelState.IsValid)
            {

                var isValid = true;

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", memberId);
                var join = DapperORM.ReturnList<MemberLogInModel>("uspGetDailyAdminMemberLogIn", param).FirstOrDefault<MemberLogInModel>();

                if (join == null)
                    isValid = false;

                if (!isValid)
                {
                    ModelState.AddModelError("", "계정을 다시 확인해주세요.");
                    return View();
                }

                if (join.AuthYn == false)
                {
                    ModelState.AddModelError("", string.Format("앞서 등록하신 {0} 을 확인하고 먼저 인증을 해주세요.", join.UserEmail));
                    return View();
                }

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, join.MemberID.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Name, join.MemberName));
                identity.AddClaim(new Claim("MemberID", join.MemberID.ToString()));
                identity.AddClaim(new Claim("ManagerYn", join.ManagerYn.ToString()));

                // Authenticate using the identity
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme
                    , principal
                    , new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddDays(3),
                    });

                return RedirectToAction("Index", "Home");
            }

            return View();
        }




    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Security.Claims;
using DailyTuntun.DbConns;
using DailyTuntun.Models;


namespace DailyTuntun.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult LogIn(string msgCode = null, string returnUrl = null, bool managerYn = false)
        {
            ViewData["msgCode"] = msgCode;
            ViewData["ReturnUrl"] = returnUrl;
            ViewData["ManagerYn"] = managerYn;

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home", new { msgCode = ViewData["msgCode"] });
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn(MemberLogInModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            ViewData["ManagerYn"] = model.ManagerYn;

            if (ModelState.IsValid)
            {

                var isValid = true;

                DynamicParameters param = new DynamicParameters();
                param.Add("@UserEmail", model.UserEmail);
                param.Add("@UserPassword", model.UserPassword);
                param.Add("@ManagerYn", model.ManagerYn);
                var join = DapperORM.ReturnList<MemberLogInModel>("uspGetDailyMemberLogIn", param).FirstOrDefault<MemberLogInModel>();

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
                identity.AddClaim(new Claim("ResponsiveYn", join.ResponsiveYn.ToString()));

                // Authenticate using the identity
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme
                    , principal
                    , new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddDays(3),
                        IsPersistent = model.RememberMe
                    });

                if (returnUrl != null)
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LogOut(bool mngYn = false, string messageCode = null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("LogIn", "Account", new { managerYn = mngYn, msgCode = messageCode });
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(MemberRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    CommonController Common = new CommonController();
                    string authCode = Common.GenerateRandomPassword();

                    DynamicParameters param = new DynamicParameters();

                    param.Add("@UserEmail", model.UserEmail);
                    param.Add("@UserPassword", model.UserPassword);
                    param.Add("@MemberCode", model.MemberCode);
                    param.Add("@MemberName", model.MemberName);
                    param.Add("@CorpName", model.CorpName);
                    param.Add("@AuthCode", authCode);
                    param.Add("@ManagerYn", 0);
                    var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberInsert", param);

                    if (returnVal == 1)
                    {
                        Common.SendMail(model.UserEmail, model.MemberName, authCode, AuthTypeId.Registor, false);
                        return RedirectToAction("Welcome", "Account", new { email = model.UserEmail });
                    }
                    else
                    {
                        if (returnVal == 0)
                            ModelState.AddModelError("", "유치원코드가 정확하지 않습니다.");
                        else if (returnVal == 2)
                            ModelState.AddModelError("", "이미 사용중인 이메일입니다.");
                        else if (returnVal == 3)
                            ModelState.AddModelError("", "이미 사용중인 유치원코드입니다.");
                        else if (returnVal == 4)
                            ModelState.AddModelError("", "유치원코드 혹은 유치원명이 잘못되었습니다.");

                        return View(model);
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "회원 가입에 실패하였습니다. 고객센터에 문의하세요.");
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Welcome(string email, string returnUrl = null)
        {
            ViewData["email"] = email;
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterAuth(string email, string authCode, bool managerYn = false)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@UserEmail", email);
            param.Add("@AuthCode", authCode);
            param.Add("@ManagerYn", managerYn);
            var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberEmailAuth", param);

            if (returnVal != 1)
            {
                return RedirectToAction("RegisterAuthFail", "Account");
            }

            if (managerYn == false)
            {
                return RedirectToAction("LogIn", "Account", new { msgCode = 2001 });
            }
            else
            {
                return RedirectToAction("LogIn", "Account", new { msgCode = 2001, managerYn = true });
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterAuthFail()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterReAuth(string returnUrl = null, bool managerYn = false)
        {
            ViewData["ReturnUrl"] = returnUrl;
            ViewData["ManagerYn"] = managerYn;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult RegisterReAuth(MemberReAuthModel model)
        {
            ViewData["ManagerYn"] = model.ManagerYn;

            if (ModelState.IsValid)
            {
                var isValid = true; /*TODO Validate the username and the password with your own logic*/

                try
                {

                    CommonController Common = new CommonController();
                    string authCode = Common.GenerateRandomPassword();

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@UserEmail", model.UserEmail);
                    param.Add("@UserPassword", model.UserPassword);
                    param.Add("@AuthCode", authCode);
                    param.Add("@ManagerYn", model.ManagerYn);
                    var join = DapperORM.ExecuteReturn<int>("uspSetDailyMemberEmailReAuthRequest", param);

                    if (join == 0)
                        isValid = false;

                    if (!isValid)
                    {
                        ModelState.AddModelError("", "계정이 잘못되었습니다. 다시 확인해주세요.");
                        return View(model);
                    }

                    DynamicParameters paramName = new DynamicParameters();
                    paramName.Add("@UserEmail", model.UserEmail);
                    string memberName = DapperORM.ExecuteReturn<string>("uspGetDailyMemberName", paramName);

                    Common.SendMail(model.UserEmail, memberName, authCode, AuthTypeId.ReAuth, model.ManagerYn);
                    return RedirectToAction("LogIn", "Account", new { msgCode = 3002, managerYn = model.ManagerYn });
                }
                catch
                {
                    ModelState.AddModelError("", "이메일 재인증 요청에 실패하였습니다. 고객센터에 문의하세요.");
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UserUpdate()
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            DynamicParameters paramMember = new DynamicParameters();
            paramMember.Add("@MemberID", memberId);
            ViewBag.MemberList = DapperORM.ReturnList<MemberDetailModel>("uspGetDailyMemberCodeList", paramMember);

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            return View(DapperORM.ExecuteReturn<MemberDetailModel>("uspGetDailyMemberDetail", param));
        }

        [HttpPost]
        public IActionResult UserUpdate(MemberDetailModel model)
        {
            DynamicParameters paramMember = new DynamicParameters();
            paramMember.Add("@MemberID", model.MemberID);
            ViewBag.MemberList = DapperORM.ReturnList<MemberDetailModel>("uspGetDailyMemberCodeList", paramMember);

            if (ModelState.IsValid)
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", model.MemberID);
                param.Add("@UserPassword", model.UserPassword);
                param.Add("@NewPassword", model.NewPassword);
                param.Add("@ManagerYn", 0);
                var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberUpdate", param);

                if (returnVal != 1)
                {
                    if (returnVal == 2)
                    {
                        ModelState.AddModelError("", "기존 암호가 올바르지 않습니다. 다시 확인해주세요.");
                    }
                    else
                    {
                        ModelState.AddModelError("", "정보변경실패 (관리자에게 문의하세요)");
                    }

                    return View();
                }
                return RedirectToAction("LogIn", "Account", new { msgCode = 1002 });
            }
            return View();
        }

        [HttpGet]
        public IActionResult UserOptionUpdate()
        {
            int memberId = 0;
            bool responsiveYn = false; 

            if (User.Identity.IsAuthenticated)
            {
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            }

            DynamicParameters paramManager = new DynamicParameters();
            paramManager.Add("@MemberID", memberId);
            responsiveYn = DapperORM.ExecuteReturn<bool>("uspGetDailyMemberResponsiveYn", paramManager);

            ViewData["MemberID"] = memberId;
            ViewData["ResponsiveYn"] = responsiveYn;

            return View();
        }

        [HttpPost]
        public IActionResult UserOptionUpdate(MemberOptionModel model)
        {
            if (ModelState.IsValid)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", model.MemberID);
                param.Add("@ResponsiveYn", model.ResponsiveYn);
                DapperORM.ExecuteWithoutReturn("uspSetDailyMemberOptionUpdate", param);
            }

            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult LostEmail(string returnUrl = null, bool managerYn = false)
        {
            ViewData["ReturnUrl"] = returnUrl;
            ViewData["ManagerYn"] = managerYn;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult LostEmail(MemberLostEmailModel model)
        {
            ViewData["ManagerYn"] = model.ManagerYn;

            if (ModelState.IsValid)
            {
                var isValid = true; /*TODO Validate the username and the password with your own logic*/

                DynamicParameters param = new DynamicParameters();

                param.Add("@MemberCode", model.MemberCode);
                param.Add("@MemberName", model.MemberName);
                param.Add("@ManagerYn", model.ManagerYn);
                var email = DapperORM.ExecuteReturn<string>("uspGetDailyMemberEmail", param);

                if (email == null)
                    isValid = false;

                if (!isValid)
                {
                    ModelState.AddModelError("", "계정이 잘못되었습니다. 다시 확인해주세요.");
                    return View();
                }

                return RedirectToAction("LostEmailResult", "Account", new { userEmail = email });
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult LostEmailResult(string userEmail)
        {
            ViewData["UserEmail"] = userEmail;
            return View();
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult UpdateEmail(string returnUrl = null, bool managerYn = false)
        {
            ViewData["ReturnUrl"] = returnUrl;
            ViewData["ManagerYn"] = managerYn;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult UpdateEmail(MemberEmailModel model)
        {
            ViewData["ManagerYn"] = model.ManagerYn;

            if (ModelState.IsValid)
            {
                try
                {
                    CommonController Common = new CommonController();
                    string authCode = Common.GenerateRandomPassword();

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@MemberName", model.MemberName);
                    param.Add("@UserPassword", model.UserPassword);
                    param.Add("@UserEmail", model.UserEmail);
                    param.Add("@UserNewEmail", model.UserNewEmail);
                    param.Add("@AuthCode", authCode);
                    param.Add("@ManagerYn", model.ManagerYn);
                    var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberEmailUpdate", param);

                    if (returnVal == 1)
                    {
                        Common.SendMail(model.UserNewEmail, model.MemberName, authCode, AuthTypeId.UpdateEmail, model.ManagerYn);
                        return RedirectToAction("LogIn", "Account", new { msgCode = 3001, managerYn = model.ManagerYn });
                    }
                    if (returnVal == 2)
                    {
                        ModelState.AddModelError("", "이미 사용중인 이메일입니다.");
                        return View(model);
                    }
                    else
                    {
                        ModelState.AddModelError("", "기존에 등록한 가입정보와 서로 다릅니다. 다시 확인해주세요.");
                        return View(model);
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "이메일 변경 요청에 실패하였습니다. 고객센터에 문의하세요.");
                    return View(model);
                }
            }
            return View(model);
        }




        [HttpGet]
        [AllowAnonymous]
        public IActionResult LostPassword(string returnUrl = null, bool managerYn = false)
        {
            ViewData["ReturnUrl"] = returnUrl;
            ViewData["ManagerYn"] = managerYn;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult LostPassword(MemberLostPassModel model)
        {
            ViewData["ManagerYn"] = model.ManagerYn;

            if (ModelState.IsValid)
            {
                try
                {
                    CommonController Common = new CommonController();
                    string authCode = Common.GenerateRandomPassword();

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@MemberName", model.MemberName);
                    param.Add("@UserEmail", model.UserEmail);
                    param.Add("@AuthCode", authCode);
                    param.Add("@ManagerYn", model.ManagerYn);
                    var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberPassReset", param);

                    if (returnVal == 1)
                    {
                        Common.SendMail(model.UserEmail, model.MemberName, authCode, AuthTypeId.LostPass, model.ManagerYn);
                        return RedirectToAction("LogIn", "Account", new { msgCode = 4002, managerYn = model.ManagerYn });
                    }
                    else
                    {
                        ModelState.AddModelError("", "기존에 등록한 가입정보와 서로 다릅니다.");
                        return View(model);
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "비밀번호 변경 요청에 실패하였습니다. 고객센터에 문의하세요.");
                    return View(model);
                }
            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult UpdatePassword(string email, string authCode, bool managerYn = false)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@UserEmail", email);
            param.Add("@AuthCode", authCode);
            param.Add("@ManagerYn", managerYn);
            var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberPassAuth", param);

            if (returnVal != 1)
            {
                return RedirectToAction("UpdatePasswordFail", "Account");
            }

            ViewData["Email"] = email;
            ViewData["ManagerYn"] = managerYn;

            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult UpdatePassword(MemberUpdatePassModel model)
        {
            ViewData["ManagerYn"] = model.ManagerYn;

            if (ModelState.IsValid)
            {
                var isValid = true;

                DynamicParameters param = new DynamicParameters();

                param.Add("@UserEmail", model.UserEmail);
                param.Add("@UserPassword", model.NewPassword);
                param.Add("@ManagerYn", model.ManagerYn);
                var join = DapperORM.ExecuteReturn<int>("uspSetDailyMemberPassUpdate", param);

                if (join == 0)
                    isValid = false;

                if (!isValid)
                {
                    ModelState.AddModelError("", "이메일 계정이 올바르지 않습니다. 다시 확인해주세요.");
                    return View();
                }

                return RedirectToAction("LogIn", "Account", new { msgCode = 3003, model.ManagerYn });
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult UpdatePasswordFail()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult SearchMemberPartial()
        {
            return PartialView();
        }

        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult SearchTeacherPartial()
        {
            return PartialView();
        }


        [HttpPost]
        [AllowAnonymous]
        public JsonResult SearchMemberCheck(MemberSearchCodeModel model)
        {
            if (ModelState.IsValid)
            {
                var isValid = true;

                DynamicParameters param = new DynamicParameters();
                param.Add("@Account", model.Account);
                param.Add("@Password", model.Password);
                param.Add("@ManagerYn", 0);
                var join = DapperORM.ReturnList<MemberSearchCodeModel>("uspGetDailyMemberSearchMemberCode", param).FirstOrDefault<MemberSearchCodeModel>();

                if (join == null)
                    isValid = false;

                if (!isValid)
                {
                    return Json(new { success = false, errorNum = 9 });
                }

                if (join.ErrorNum > 0)
                {
                    return Json(new { success = false, errorNum = join.ErrorNum });
                }

                ViewData["MemberCode"] = join.MemberCode;
                ViewData["CorpName"] = join.MemberName;

                return Json(new { success = true, memberCode = join.MemberCode, corpName = join.MemberName });
            }
            return Json(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public JsonResult SearchTeacherCheck(MemberSearchCodeModel model)
        {
            if (ModelState.IsValid)
            {
                var isValid = true;

                DynamicParameters param = new DynamicParameters();
                param.Add("@Account", model.Account);
                param.Add("@Password", model.Password);
                param.Add("@ManagerYn", 1);
                var join = DapperORM.ReturnList<MemberSearchCodeModel>("uspGetDailyMemberSearchMemberCode", param).FirstOrDefault<MemberSearchCodeModel>();

                if (join == null)
                    isValid = false;

                if (!isValid)
                {
                    return Json(new { success = false, errorNum = 9 });
                }

                if (join.ErrorNum > 0)
                {
                    return Json(new { success = false, errorNum = join.ErrorNum });
                }

                ViewData["MemberCode"] = join.MemberCode;
                ViewData["MemberName"] = join.MemberName;

                return Json(new { success = true, memberCode = join.MemberCode, memberName = join.MemberName });
            }
            return Json(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult OutMemberPartial()
        {
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult OutMemberCheck()
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var isValid = true;

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberOut", param);

            if (returnVal == 0)
                isValid = false;

            if (!isValid)
            {
                return Json(new { success = false, errorNum = 9 });
            }

            return Json(new { success = true });
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult TeacherRegister(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult TeacherRegister(MemberRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CommonController Common = new CommonController();
                    string authCode = Common.GenerateRandomPassword();

                    DynamicParameters param = new DynamicParameters();
                    param.Add("@UserEmail", model.UserEmail);
                    param.Add("@UserPassword", model.UserPassword);
                    param.Add("@MemberCode", model.MemberCode);
                    param.Add("@MemberName", model.MemberName);
                    param.Add("@AuthCode", authCode);
                    param.Add("@ManagerYn", 1);
                    var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberInsert", param);

                    if (returnVal == 1)
                    {
                        Common.SendMail(model.UserEmail, model.MemberName, authCode, AuthTypeId.Registor, true);
                        return RedirectToAction("Welcome", "Account", new { email = model.UserEmail });
                    }
                    else
                    {
                        if (returnVal == 0 || returnVal == 4)
                            ModelState.AddModelError("", "교사코드 혹은 교사이름이 정확하지 않습니다.");
                        else if (returnVal == 2)
                            ModelState.AddModelError("", "이미 사용중인 이메일입니다.");
                        else if (returnVal == 3)
                            ModelState.AddModelError("", "이미 사용중인 교사코드입니다.");

                        return View(model);
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "교사 등록에 실패하였습니다. 고객센터에 문의하세요.");
                    return View(model);
                }


            }
            return View(model);
        }

        [HttpGet]
        public IActionResult TeacherUpdate()
        {
            int memberId = 0;

            if (User.Identity.IsAuthenticated)
                memberId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            DynamicParameters param = new DynamicParameters();
            param.Add("@MemberID", memberId);
            return View(DapperORM.ExecuteReturn<MemberDetailModel>("uspGetDailyMemberDetail", param));
        }


        [HttpPost]
        public IActionResult TeacherUpdate(MemberDetailModel model)
        {
            if (ModelState.IsValid)
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@MemberID", model.MemberID);
                param.Add("@UserPassword", model.UserPassword);
                param.Add("@NewPassword", model.NewPassword);
                param.Add("@ManagerYn", 1);
                var returnVal = DapperORM.ExecuteReturn<int>("uspSetDailyMemberUpdate", param);

                if (returnVal != 1)
                {
                    if (returnVal == 2)
                    {
                        ModelState.AddModelError("", "기존 암호가 올바르지 않습니다. 다시 확인해주세요.");
                    }
                    else
                    {
                        ModelState.AddModelError("", "정보변경실패 (관리자에게 문의하세요)");
                    }

                    return View();
                }
                return RedirectToAction("LogIn", "Account", new { msgCode = 1002, managerYn = true });
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AdminLogIn(string msgCode = null, string returnUrl = null)
        {
            ViewData["msgCode"] = msgCode;
            ViewData["ReturnUrl"] = returnUrl;

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home", new { msgCode = ViewData["msgCode"] });
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AdminLogIn(MemberLogInModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {

                var isValid = true;

                DynamicParameters param = new DynamicParameters();
                param.Add("@UserEmail", model.UserEmail);
                param.Add("@UserPassword", model.UserPassword);
                var join = DapperORM.ReturnList<MemberLogInModel>("uspGetDailyMemberAdminLogIn", param).FirstOrDefault<MemberLogInModel>();

                if (join == null)
                    isValid = false;

                if (!isValid)
                {
                    ModelState.AddModelError("", "계정을 다시 확인해주세요.");
                    return View();
                }

                // Create the identity from the user info
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, join.MemberID.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Name, join.MemberName));
                identity.AddClaim(new Claim("MemberID", join.MemberID.ToString()));

                // Authenticate using the identity
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = model.RememberMe });

                if (returnUrl != null)
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("MemberList", "Admin");
            }


            return View();
        }



    }
}

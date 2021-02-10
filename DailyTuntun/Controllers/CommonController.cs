using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Identity;
using DailyTuntun.DbConns;
using Dapper;
using DailyTuntun.Models;

namespace DailyTuntun.Controllers
{
    public enum AuthTypeId
    {
        Registor
        , ReAuth
        , UpdateEmail
        , LostPass
    }

    [Authorize]
    public class CommonController : Controller
    {
        public int PageSize;
        public int NowPageNum;
        public int NowPageStartNum;
        public int EndPageNum;

        public bool PrePageYn;
        public bool NextPageYn;
        public int PrePageButtonNum;
        public int NextPageButtonNum;
        public int PageListSize;

        public void PagedList(int page, int total, int pageSize)
        {


            this.PageSize = pageSize;
            this.PageListSize = 5;
            this.NowPageStartNum = 1;

            if (total % this.PageSize == 0)
                this.EndPageNum = total / this.PageSize;
            else
                this.EndPageNum = (total / this.PageSize) + 1;

            int nowPageStartNum = (PageListSize * ((page - 1) / PageListSize)) + 1;
            int prePageButtonNum = PageListSize * (((page - 1) / PageListSize) - 1) + 1;
            int nextPageButtonNum = (PageListSize * ((page - 1) / PageListSize)) + PageListSize + 1;

            if (prePageButtonNum < 0)
                this.PrePageYn = false;
            else
                this.PrePageYn = true;

            this.PrePageButtonNum = prePageButtonNum;
            this.NowPageStartNum = nowPageStartNum;

            if (nextPageButtonNum >= this.EndPageNum)
            {
                this.NextPageButtonNum = this.EndPageNum;
                this.NextPageYn = false;
            }
            else
            {
                this.NextPageButtonNum = nextPageButtonNum;
                this.NextPageYn = true;
            }
        }

        public static bool IsInternetExplorer(string userAgent)
        {
            if (userAgent.Contains("MSIE") || userAgent.Contains("Trident"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CommonCateModel> CommonList(string separate)
        {
                
            DynamicParameters paramCate = new DynamicParameters();
            paramCate.Add("@CateSeparate", separate);
            List<CommonCateModel> commonList = DapperORM.ReturnList<CommonCateModel>("uspGetDailyCommonCateList", paramCate).ToList();

            return commonList;
        }

        [HttpPost]
        public void SendMail(string userEmail, string userName, string authCode, AuthTypeId AuthType, bool managerYn)
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("DAILY 튼튼", "noreply@tuntun.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(userName, userEmail);
            message.To.Add(to);

            string subject = "";
            string htmlBody = "";

            if (AuthType == AuthTypeId.Registor)
            {
                string authURL = "https://daily.tuntun.com/Account/RegisterAuth?email=" + userEmail + "&authCode=" + authCode + "&managerYn=" + managerYn;

                subject = "DAILY 튼튼 가입을 환영합니다.";

                htmlBody = string.Format(@"<p>안녕하세요. {0}님,<br>
                <p>DAILY 튼튼에 가입해주셔서 감사합니다. <br />
                이메일 인증을 위해, 아래의 링크를 한 번만 클릭해주세요.<p>
                <a href=""{1}"">이메일 인증하기</a>", userName, authURL);
            }
            else if (AuthType == AuthTypeId.ReAuth || AuthType == AuthTypeId.UpdateEmail)
            {
                string authURL = "https://daily.tuntun.com/Account/RegisterAuth?email=" + userEmail + "&authCode=" + authCode + "&managerYn=" + managerYn;

                subject = "DAILY 튼튼 재인증 메일입니다.";

                htmlBody = string.Format(@"<p>안녕하세요. {0}님,<br>
                <p>DAILY 튼튼에 오신 것을 환영합니다.<p>
                <p>이메일 인증을 위해, 아래의 링크를 한 번만 클릭해주세요.<p>
                <a href=""{1}"">이메일 인증하기</a>", userName, authURL);

            }
            else if (AuthType == AuthTypeId.LostPass)
            {
                string authURL = "https://daily.tuntun.com/Account/UpdatePassword?email=" + userEmail + "&authCode=" + authCode + "&managerYn=" + managerYn;

                subject = "DAILY 튼튼 비밀번호를 변경해주세요.";

                htmlBody = string.Format(@"<p>안녕하세요. {0}님,<br>
                <p>비밀번호 변경을 위한 메일입니다. <br />
                비밀번호 변경을 아래의 링크에서 진행해주시기 바랍니다.<p>
                <a href=""{1}"">비밀번호 변경하기</a>", userName, authURL);
            }

            message.Subject = subject;
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = htmlBody;

            message.Body = bodyBuilder.ToMessageBody();

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com", 465, true);
            client.Authenticate("tuntunenglish.it@gmail.com", "#xmsxmsduddj##3");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }

        public string GenerateRandomPassword(PasswordOptions opts = null)
        {
            if (opts == null) opts = new PasswordOptions()
            {
                RequiredLength = 8,
                RequiredUniqueChars = 4,
                RequireDigit = true,
                RequireLowercase = true,
                RequireNonAlphanumeric = true,
                RequireUppercase = true
            };

            string[] randomChars = new[] {
                "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
                "abcdefghijkmnopqrstuvwxyz",    // lowercase
                "0123456789",                   // digits
                "!@$?_-"                        // non-alphanumeric
            };

            Random rand = new Random(Environment.TickCount);
            List<char> chars = new List<char>();

            if (opts.RequireUppercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[0][rand.Next(0, randomChars[0].Length)]);

            if (opts.RequireLowercase)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[1][rand.Next(0, randomChars[1].Length)]);

            if (opts.RequireDigit)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[2][rand.Next(0, randomChars[2].Length)]);

            if (opts.RequireNonAlphanumeric)
                chars.Insert(rand.Next(0, chars.Count),
                    randomChars[3][rand.Next(0, randomChars[3].Length)]);

            for (int i = chars.Count; i < opts.RequiredLength
                || chars.Distinct().Count() < opts.RequiredUniqueChars; i++)
            {
                string rcs = randomChars[rand.Next(0, randomChars.Length)];
                chars.Insert(rand.Next(0, chars.Count),
                    rcs[rand.Next(0, rcs.Length)]);
            }

            return new string(chars.ToArray());
        }
    }
}
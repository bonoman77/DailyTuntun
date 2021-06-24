using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyTuntun.Models
{
    public class MemberLogInModel
    {
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [Display(Name = "이메일 아이디")]
        [StringLength(200, ErrorMessage = "이메일은 100자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        [Display(Name = "비밀번호")]
        [StringLength(100, ErrorMessage = "암호는 100자를 넘을 수 없습니다.")]
        public string UserPassword { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public bool ManagerYn { get; set; }
        public bool AuthYn { get; set; }
    }

    public class MemberRegisterModel
    {
        [Required(ErrorMessage = "등록된 코드를 검색하세요.")]
        [Display(Name = "원 코드")]
        public string MemberCode { get; set; }

        [Display(Name = "이메일 아이디")]
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "이메일은 200자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }

        [Display(Name = "비밀번호")]
        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상 {1}자 이하이어야 합니다.", MinimumLength = 8)]
        public string UserPassword { get; set; }

        [Display(Name = "비밀번호 확인")]
        [Required(ErrorMessage = "비밀번호를 재입력하세요.")]
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "두 개의 비밀번호가 일치해야 합니다.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "회원 이름")]
        [Required(ErrorMessage = "회원이름을 입력하세요.")]
        public string MemberName { get; set; }

        [Display(Name = "원 이름")]
        public string CorpName { get; set; }

        public bool AuthYn { get; set; }
    }

    public class MemberDetailModel
    {
        public string MemberID { get; set; }

        [Required(ErrorMessage = "등록된 코드를 검색하세요.")]
        [Display(Name = "원 코드")]
        public string MemberCode { get; set; }

        [Required(ErrorMessage = "회원 이름을 입력하세요.")]
        [Display(Name = "회원 이름")]
        public string MemberName { get; set; }

        [Display(Name = "원 이름")]
        public string CorpName { get; set; }

        [Display(Name = "이메일 아이디")]
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "이메일은 100자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }

        [Display(Name = "비밀번호")]
        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상 {1}자 이하이어야 합니다.", MinimumLength = 8)]
        public string UserPassword { get; set; }

        [Display(Name = "비밀번호 변경")]
        [Required(ErrorMessage = "새로 사용할 암호를 입력하세요.")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상 {1}자 이하이어야 합니다.", MinimumLength = 8)]
        public string NewPassword { get; set; }

        [Display(Name = "비밀번호 변경 확인")]
        [Required(ErrorMessage = "새로 사용할 암호를 재입력하세요.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "두 개의 암호 입력이 일치해야 합니다.")]
        public string ConfirmPassword { get; set; }
        public bool ManagerYn { get; set; }
    }



    public class MemberOptionModel
    {
        public string MemberID { get; set; }

        public bool ResponsiveYn { get; set; }
    }

    public class MemberEmailModel
    {
        [Required(ErrorMessage = "회원 이름을 입력하세요.")]
        [Display(Name = "회원 이름")]
        public string MemberName { get; set; }

        [Display(Name = "이메일 아이디")]
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "이메일은 200자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }

        [Display(Name = "새로운 이메일 아이디")]
        [Required(ErrorMessage = "새로 사용할 이메일을 입력하세요.")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "이메일은 200자를 넘을 수 없습니다.")]
        public string UserNewEmail { get; set; }


        [Display(Name = "비밀번호")]
        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상 {1}자 이하이어야 합니다.", MinimumLength = 8)]
        public string UserPassword { get; set; }
        public bool ManagerYn { get; set; }
    }

    public class MemberUpdatePassModel
    {
        [Display(Name = "이메일 아이디")]
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "이메일은 200자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }

        [Display(Name = "비밀번호 변경")]
        [Required(ErrorMessage = "새로 사용할 암호를 입력하세요.")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상 {1}자 이하이어야 합니다.", MinimumLength = 8)]
        public string NewPassword { get; set; }

        [Display(Name = "비밀번호 변경 확인")]
        [Required(ErrorMessage = "새로 사용할 암호를 재입력하세요.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "두 개의 암호 입력이 일치해야 합니다.")]
        public string ConfirmPassword { get; set; }
        public bool ManagerYn { get; set; }
    }

    public class MemberReAuthModel
    {
        [Display(Name = "이메일 아이디")]
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "이메일은 200자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }
        [Display(Name = "비밀번호")]
        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "{0}은(는) {2}자 이상 {1}자 이하이어야 합니다.", MinimumLength = 8)]
        public string UserPassword { get; set; }
        public string MemberName { get; set; }
        public bool ManagerYn { get; set; }
    }

    public class MemberLostEmailModel
    {
        [Display(Name = "회원 이름")]
        [Required(ErrorMessage = "등록된 회원 이름을 입력하세요.")]
        public string MemberName { get; set; }

        [Display(Name = "원 코드")]
        [Required(ErrorMessage = "등록된 원 코드를 입력하세요.")]
        public string MemberCode { get; set; }
        public bool ManagerYn { get; set; }
    }

    public class MemberLostPassModel
    {
        [Display(Name = "이메일 아이디")]
        [Required(ErrorMessage = "이메일 아이디를 입력하세요.")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "이메일은 200자를 넘을 수 없습니다.")]
        public string UserEmail { get; set; }

        [Display(Name = "회원 이름")]
        [Required(ErrorMessage = "등록된 회원 이름을 입력하세요.")]
        public string MemberName { get; set; }
        public bool ManagerYn { get; set; }
    }

    public class MemberSearchAccountModel
    {
        [Display(Name = "아이디")]
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        public string Account { get; set; }

        [Display(Name = "비밀번호")]
        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        public string Password { get; set; }
        public string MemberCode { get; set; }
        public string MemberName { get; set; }
        public int ErrorNum { get; set; }
    }

    public class MemberSearchCodeModel
    {
        [Display(Name = "원코드")]
        [Required(ErrorMessage = "원코드를 입력하세요.")]
        public string SearchCode { get; set; }
        public string MemberCode { get; set; }
        public string MemberName { get; set; }
        public int ErrorNum { get; set; }
    }
}

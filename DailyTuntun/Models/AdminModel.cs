using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyTuntun.Models
{
    public class AdminMemberModel
    {
        [Display(Name = "회원ID")]
        public int MemberID { get; set; }

        [Display(Name = "회원코드")]
        public string MemberCode { get; set; }

        [Display(Name = "회원명")]
        public string MemberName { get; set; }

        [Display(Name = "이메일계정")]
        public string UserEmail { get; set; }

        [Display(Name = "회원구분")]
        public string MemberType { get; set; }

        [Display(Name = "인증여부")]
        public string AuthYn { get; set; }

        [Display(Name = "활동여부")]
        public string UseYn { get; set; }

        [Display(Name = "등록일")]
        public string CreateDate { get; set; }
    }


    public class AdminMemberCntModel
    {
        public int TotalCnt { get; set; }
    }


    public class AdminMemberDetailModel
    {
        [Display(Name = "회원ID")]
        public string MemberID { get; set; }

        [Display(Name = "회원코드")]
        public string MemberCode { get; set; }

        [Display(Name = "원이름")]
        public string CorpName { get; set; }

        [Display(Name = "회원이름")]
        public string MemberName { get; set; }

        [Display(Name = "회원타입")]
        public string MemberType { get; set; }

        [Display(Name = "이메일계정")]
        public string UserEmail { get; set; }

        [Display(Name = "새로운 이메일계정")]
        [Required(ErrorMessage = "새로운 이메일계정을 입력하세요.")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "이메일은 100자를 넘을 수 없습니다.")]
        public string UserNewEmail { get; set; }
        public bool ManagerYn { get; set; }
    }

    public class AdminMemberCounselModel
    {
        [Display(Name = "상담ID")]
        public string CounselID { get; set; }

        [Display(Name = "회원ID")]
        public string MemberID { get; set; }

        [Display(Name = "이메일계정")]
        public string UserEmail { get; set; }

        [Display(Name = "회원명")]
        public string MemberName { get; set; }

        [Display(Name = "불평수준")]
        public string ComplainLevel { get; set; }

        [Display(Name = "불평종류")]
        public string ComplainKind { get; set; }

        [Display(Name = "연락처")]
        public string Mobile { get; set; }

        [Display(Name = "처리여부")]
        public string CompleteYn { get; set; }

        [Display(Name = "등록일")]
        public string CreateDate { get; set; }
    }

    public class AdminMemberCounselDetailModel
    {
        [Display(Name = "상담ID")]
        public string CounselID { get; set; }

        [Display(Name = "회원ID")]
        public string MemberID { get; set; }

        [Display(Name = "이메일계정")]
        public string UserEmail { get; set; }

        [Display(Name = "회원명")]
        public string MemberName { get; set; }

        [Display(Name = "상담내용")]
        public string Contents { get; set; }

        [Display(Name = "불평수준")]
        public string ComplainLevel { get; set; }

        [Display(Name = "불평종류")]
        public string ComplainKind { get; set; }

        [Display(Name = "연락처")]
        public string Mobile { get; set; }

        [Display(Name = "처리여부")]
        public string CompleteYn { get; set; }

        [Display(Name = "등록일")]
        public string CreateDate { get; set; }
    }


    public class AdminMemberBasicModel
    {
        public string UserEmail { get; set; }
        public string MemberName { get; set; }
        public bool ManagerYn { get; set; }
        public int ErrorNum { get; set; }
    }


    public class AdminContentModel
    {
        [Display(Name = "컨텐츠그룹ID")]
        public string ContentGroupID { get; set; }

        [Display(Name = "컨텐츠그룹명")]
        public string ContentGroupName { get; set; }

        [Display(Name = "컨텐츠종류")]
        public string ProductKindName { get; set; }

        [Display(Name = "컨텐츠종류세부")]
        public string ProductKindSubName { get; set; }

        [Display(Name = "연결교재코드")]
        public string ProductCode { get; set; }

        [Display(Name = "연결교재명")]
        public string ProductName { get; set; }

        [Display(Name = "출판일")]
        public string PublishDate { get; set; }
    }



}

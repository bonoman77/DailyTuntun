using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyTuntun.Models
{
    public class ProductGroupModel
    {
        public int ProductKindID { get; set; }
        public string ProductKindName { get; set; }
        public int ProductKindSubID { get; set; }
        public string ProductKindSubName { get; set; }
        public int ContentGroupID { get; set; }
        public string ContentGroupName { get; set; }
        public string ContentGroupImageURL { get; set; }
        public string Comment { get; set; }
        public bool AuthYn { get; set; }
    }

    public class ProductTitleModel
    {
        public int ProductKindID { get; set; }
        public int ContentTitleID { get; set; }
        public string ContentTitle { get; set; }
        public string ContentImageURL { get; set; }
        public int ContentGroupID { get; set; }
        public string ContentGroupImageURL { get; set; }
        public bool AuthYn { get; set; }
        public bool DisplayYn { get; set; }
    }

    public class ProductContentModel
    {
        public int ContentID { get; set; }
        public int StreamKindID { get; set; }
        public string StreamName { get; set; }
        public string StreamURL { get; set; }
        public string ImageURL { get; set; }
        public string CompleteImageURL { get; set; }
        public string Coords { get; set; }
        public bool AuthYn { get; set; }
        public int ViewCnt { get; set; }
        public int OrderNum { get; set; }
    }

    public class ProductDownloadModel
    {
        public int ContentFileID { get; set; }

        [Display(Name = "파일정보")]
        public string Title { get; set; }

        [Display(Name = "링크")]
        public string FilePath { get; set; }

        public int DownloadKindID { get; set; }

        [Display(Name = "종류")]
        public string FileKind { get; set; }

        [Display(Name = "버젼")]
        public string Version { get; set; }

        [Display(Name = "등록일")]
        public string CreateDate { get; set; }
    }

}



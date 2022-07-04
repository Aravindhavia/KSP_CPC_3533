using KSPRecruitment.Models.Common;
using KSPRecruitment.Models.Enums;

namespace KSPRecruitment.Models
{
    public class ApplicantDownloadModel : BaseAuditableEntity
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public DownloadFileTypes FileType { get; set; }
        public string FilePath { get; set; }

        public ApplicantModel Applicant { get; set; }
    }
}

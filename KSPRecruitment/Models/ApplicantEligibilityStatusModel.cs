using KSPRecruitment.Models.Common;

namespace KSPRecruitment.Models
{
    public class ApplicantEligibilityStatusModel : BaseAuditableEntity
    {
        public int ApplicantId { get; set; }
        public string ActivityCode { get; set; }
        public bool IsEligible { get; set; }
        public string StatusRemarks { get; set; }

        public ApplicantModel Applicant { get; set; }
        public RecruitmentActivityModel Activity { get; set; }
    }
}

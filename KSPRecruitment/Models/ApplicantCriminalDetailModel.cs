using KSPRecruitment.Models.Common;

namespace KSPRecruitment.Models
{
    public class ApplicantCriminalDetailModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public bool IsInvolvedInCriminalActivity { get; set; }
        public string CaseDetails { get; set; }
        public bool IsConvictedInCriminalCase { get; set; }
        public string ConvictionDetails { get; set; }
        public bool HasDepartmentEnquiry { get; set; }
        public string DepartmentEnquiryDetails { get; set; }

        public ApplicantModel Applicant { get; set; }
    }
}

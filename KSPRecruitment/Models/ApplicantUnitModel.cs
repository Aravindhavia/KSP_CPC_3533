using KSPRecruitment.Models.Common;

namespace KSPRecruitment.Models
{
    public class ApplicantUnitModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public int PriorityIndex { get; set; }
        public string UnitCode { get; set; }

        public ApplicantModel Applicant { get; set; }
        public PostUnitModel Unit { get; set; }
    }
}

using KSPRecruitment.Models.Common;
using KSPRecruitment.Models.Enums;

namespace KSPRecruitment.Models
{
    public class ApplicantETPSTScheduleModel : BaseAuditableEntity
    {
        public string ApplicantId { get; set; }
        public int SlNo { get; set; }
        public string ScheduledDate { get; set; }
        public string ETPSTGroundCode { get; set; }
        public string ExamTime { get; set; }
        public string ReportingTime { get; set; }
        public ApplicantETPSTStatuses Status { get; set; }

        //public Applicant Applicant { get; set; }
        //public ETPSTGround Ground { get; set; }
    }
}

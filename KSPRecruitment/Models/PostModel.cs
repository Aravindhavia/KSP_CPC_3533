using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class PostModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string NotificationNo { get; set; }
        public int TotalNoOfVacancies { get; set; }
        public string ApplicationNoCode { get; set; }

        public ICollection<ApplicantModel> Applicants { get; set; }
        public ICollection<RecruitmentActivityModel> Activities { get; set; }
        public ICollection<PostUnitModel> Units { get; set; }
    }
}

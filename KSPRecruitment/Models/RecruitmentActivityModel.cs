using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class RecruitmentActivityModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int OrderIndex { get; set; }
        public string PostCode { get; set; }

        public PostModel Post { get; set; }

        public ICollection<ApplicantEligibilityStatusModel> ApplicantEligibilityDetails { get; set; }
    }
}

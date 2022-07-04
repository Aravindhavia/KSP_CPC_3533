using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class DistrictModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int OrderIndex { get; set; }

        public ICollection<ApplicantContactModel> Applicants { get; set; }
    }
}

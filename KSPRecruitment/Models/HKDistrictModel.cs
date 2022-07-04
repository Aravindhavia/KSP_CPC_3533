using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class HKDistrictModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }

        public ICollection<ApplicantHKDetailModel> Applicants { get; set; }
    }
}

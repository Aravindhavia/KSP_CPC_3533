using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class ApplyingTypeModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }

        public ICollection<ApplicantModel> Applicants { get; set; }
    }
}

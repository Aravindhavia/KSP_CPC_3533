using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class PostUnitModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string PostCode { get; set; }

        public PostModel Post { get; set; }

        public ICollection<ApplicantUnitModel> Applicants { get; set; }
    }
}

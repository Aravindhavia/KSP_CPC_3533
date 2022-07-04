using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class ETPSTDistrictModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }

        public ICollection<ETPSTGroundModel> Grounds { get; set; }
    }
}

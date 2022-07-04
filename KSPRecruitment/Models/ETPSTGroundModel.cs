using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class ETPSTGroundModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string ETPSTDistrictCode { get; set; }

        public ETPSTDistrictModel District { get; set; }

        public ICollection<ApplicantETPSTScheduleModel> ApplicantsSchedule { get; set; }
    }
}

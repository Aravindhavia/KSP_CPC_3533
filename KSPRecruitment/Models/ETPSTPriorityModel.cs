using KSPRecruitment.Models.Common;
using KSPRecruitment.Models.Enums;

namespace KSPRecruitment.Models
{
    public class ETPSTPriorityModel : BaseRemarksEntity
    {
        public Genders Gender { get; set; }
        public string ApplyingTypeCode { get; set; }

        public ApplyingTypeModel ApplyingType { get; set; }
    }
}

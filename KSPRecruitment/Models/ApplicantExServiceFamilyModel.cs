using KSPRecruitment.Models.Common;
using KSPRecruitment.Models.Enums;

namespace KSPRecruitment.Models
{
    public class ApplicantExServiceFamilyModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public bool IsDiedInService { get; set; }
        public bool IsDisabledInService { get; set; }
        public bool IsExServicemenRelation { get; set; }
        public ExServicemenRelations Relation { get; set; }

        public ApplicantReservationModel Reservation { get; set; }
    }
}

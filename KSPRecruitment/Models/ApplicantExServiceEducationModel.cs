using KSPRecruitment.Models.Common;

namespace KSPRecruitment.Models
{
    public class ApplicantExServiceEducationModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public bool IsPUCCompleted { get; set; }
        public bool IsDegreeHolder { get; set; }
        public bool IsArmyGraduate { get; set; }

        public ApplicantExServiceModel ApplicantExService { get; set; }
    }
}

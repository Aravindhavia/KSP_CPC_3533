using KSPRecruitment.Models.Common;
using System;

namespace KSPRecruitment.Models
{
    public class ApplicantHKDetailModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public string HKDistrictCode { get; set; }
        public DateTime CertificateDate { get; set; }
        public bool IsClaimingLocalPost { get; set; }
        public int LocalCadrePostPriority { get; set; }
        public bool IsClaimingNonLocalPost { get; set; }
        public int LocalCadre92PercentPriority { get; set; }
        public bool IsClaimingResidual { get; set; }
        public int LocalCadre8PercentPriority { get; set; }

        public ApplicantReservationModel Reservation { get; set; }
        public HKDistrictModel District { get; set; }
    }
}

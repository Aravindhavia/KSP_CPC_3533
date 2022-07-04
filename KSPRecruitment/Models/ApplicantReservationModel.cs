using KSPRecruitment.Models.Common;
using System;

namespace KSPRecruitment.Models
{
    public class ApplicantReservationModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public string CategoryCode { get; set; }
        public DateTime? CategoryCertificateIssuedDate { get; set; }
        public string SubCaste { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public bool IsClaimingExServicemen { get; set; }
        public bool IsExServicemenFamilyMember { get; set; }
        public bool IsClaimingPDP { get; set; }
        public DateTime? PDPCertificateIssuedDate { get; set; }
        public bool IsClaimingKannadaMedium { get; set; }
        public DateTime? KannadaMediumCertificateIssuedDate { get; set; }
        public bool IsClaimingRural { get; set; }
        public DateTime? RuralCertificateIssuedDate { get; set; }
        public bool IsClaimingHK { get; set; }
        public bool IsGovtEmployee { get; set; }

        public ApplicantModel Applicant { get; set; }
        public CategoryModel Category { get; set; }

        public ApplicantExServiceModel ExService { get; set; }
        public ApplicantExServiceFamilyModel ExServiceRelationship { get; set; }
        public ApplicantHKDetailModel HKDetail { get; set; }
        public ApplicantGovernmentServiceModel GovernmentService { get; set; }
    }
}

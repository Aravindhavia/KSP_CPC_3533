using KSPRecruitment.Models.Common;

namespace KSPRecruitment.Models
{
    public class ApplicantUploadModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public string PhotoPath { get; set; }
        public string SignaturePath { get; set; }
        public string IdentityCardPath { get; set; }
        public string ThumbImagePath { get; set; }
        public string DependentCertificatePath { get; set; }
        public string CategoryCertificatePath { get; set; }
        public string QualificationCertificatePath { get; set; }

        public ApplicantModel Applicant { get; set; }
    }
}

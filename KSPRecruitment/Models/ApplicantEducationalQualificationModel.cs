using KSPRecruitment.Models.Common;
using System;

namespace KSPRecruitment.Models
{
    public class ApplicantEducationalQualificationModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public bool IsDegreeHolder { get; set; }
        public bool IsPUCHolder { get; set; }
        public string EducationQualificationCode { get; set; }
        public string EducationQualificationName_Others { get; set; }
        public int PassYear { get; set; }
        public double MaximumMarks { get; set; }
        public double ObtainedMarks { get; set; }
        public double MarksPercentage { get; set; }
        public DateTime ResultAnnouncedOn { get; set; }
        public string RegistrationNo { get; set; }
        public string QualificationStreamCode { get; set; }
        public bool IsPassedInLanguageExam { get; set; }
        public bool IsPassedInSubjectExam { get; set; }
        public bool IsStudiedKannadaLanguage { get; set; }
        public string MonthAndYearOfPass { get; set; }
        public DateTime ResultDate { get; set; }

        public ApplicantModel Applicant { get; set; }
        public EducationalQualificationModel EducationQualification { get; set; }
        public EducationalQualificationStreamModel QualificationStream { get; set; }
    }
}

using KSPRecruitment.Models.Common;
using KSPRecruitment.Models.Enums;
using System;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class ApplicantModel : BaseAuditableEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ApplyingTypeCode { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Genders Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IdCardTypes IdentityCard { get; set; }  
        public string IdentityCardNo { get; set; }
        public string AadharNo { get; set; }
        public string IdentificationMark_01 { get; set; }
        public string IdentificationMark_02 { get; set; }
        public string PostCode { get; set; }
        public ApplicationStatuses StatusCode { get; set; }
        public int VisitorId { get; set; }

        public ApplyingTypeModel ApplyingType { get; set; }
        public PostModel Post { get; set; }
        public VisitorModel Visitor { get; set; }

        public ApplicantCriminalDetailModel CriminalRecord { get; set; }
        public ApplicantContactModel Contact { get; set; }
        public ApplicantReservationModel Reservation { get; set; }
        public ApplicantEducationalQualificationModel EducationalQualification { get; set; }
        public ApplicantUploadModel Upload { get; set; }

        //public ApplicantETPSTSchedule ETPSTSchedule { get; set; }

        public ICollection<ApplicantEligibilityStatusModel> EligibilityDetails { get; set; }
        public ICollection<ApplicantDownloadModel> Downloads { get; set; }
        public ICollection<ApplicantUnitModel> UnitPriorities { get; set; }
    }
}

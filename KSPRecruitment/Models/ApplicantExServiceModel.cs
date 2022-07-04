using KSPRecruitment.Models.Common;
using System;

namespace KSPRecruitment.Models
{
    public class ApplicantExServiceModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public bool IsCurrentlyWorking { get; set; }
        public DateTime DateOfIssueNOC { get; set; }
        public DateTime DateOfDischarge { get; set; }
        public string ServiceRendered { get; set; }
        public int YearsInService { get; set; }
        public int MonthsInService { get; set; }
        public int DaysInService { get; set; }
        public bool IsAvailedExServicemenBenefit { get; set; }

        public ApplicantReservationModel Reservation { get; set; }

        public ApplicantExServiceEducationModel ExServiceEducationDetail { get; set; }
    }
}

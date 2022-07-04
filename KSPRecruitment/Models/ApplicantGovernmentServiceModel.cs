using KSPRecruitment.Models.Common;
using System;

namespace KSPRecruitment.Models
{
    public class ApplicantGovernmentServiceModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public int YearsInService { get; set; }
        public int MonthsInService { get; set; }
        public int DaysInService { get; set; }
        public DateTime NOCIssuedDate { get; set; }
        public DateTime DateOfJoining { get; set; }

        public ApplicantReservationModel Reservation { get; set; }
    }
}

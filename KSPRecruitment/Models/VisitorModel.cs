using System;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class VisitorModel 
    {
        public int Id { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
        public DateTime VisitedOn { get; set; }

        public ICollection<ApplicantModel> Applicants { get; set; }
    }
}

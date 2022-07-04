using KSPRecruitment.Models.Common;
using System.Collections.Generic;

namespace KSPRecruitment.Models
{
    public class CategoryModel : BaseAuditableEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public double FeeAmount { get; set; }

        public ICollection<ApplicantReservationModel> Applicants { get; set; }
    }
}

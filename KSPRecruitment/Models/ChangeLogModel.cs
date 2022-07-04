using KSPRecruitment.Models.Common;
using System;

namespace KSPRecruitment.Models
{
    public class ChangeLogModel : BaseRemarksEntity
    {
        public int Id { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ApplicantId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string UserName { get; set; }
        public bool IsInternal { get; set; }

        public ApplicantModel Applicant { get; set; }
    }
}

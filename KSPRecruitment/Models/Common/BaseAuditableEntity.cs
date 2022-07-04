using System;

namespace KSPRecruitment.Models.Common
{
    public abstract class BaseAuditableEntity : BaseRemarksEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}

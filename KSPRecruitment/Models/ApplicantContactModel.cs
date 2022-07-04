using KSPRecruitment.Models.Common;

namespace KSPRecruitment.Models
{
    public class ApplicantContactModel : BaseRemarksEntity
    {
        public int ApplicantId { get; set; }
        public string DoorNo { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Location { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName_Others { get; set; }
        public string UnionStateCode { get; set; }
        public string Pincode { get; set; }
        public string NativeDistrictCode { get; set; }
        public string NativeDistrictName_Others { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }

        public ApplicantModel Applicant { get; set; }
        public DistrictModel District { get; set; }
        public UnionStateTerritoryModel UnionState { get; set; }
        public NativeDistrictModel NativeDistrict { get; set; }
    }
}

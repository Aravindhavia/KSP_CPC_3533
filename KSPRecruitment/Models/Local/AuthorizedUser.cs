namespace KSPRecruitment.Models
{
    public class AuthorizedUser : User
    {
        public bool IsVerified { get; set; }
        public string JWToken { get; set; }
    }
}

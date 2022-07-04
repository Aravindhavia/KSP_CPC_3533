namespace KSPRecruitment.Models
{
    public abstract class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserCode { get; set; }
        public string[] Roles { get; set; }
    }
}

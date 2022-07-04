using KSPRecruitment.Models;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public interface IAuthService
    {
        Task<AuthorizedUser> AuthenticateAsync(string userName, string password);
    }
}

using KSPRecruitment.Models;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public interface IPostService
    {
        Task<PostModel> GetPostAsync();
    }
}

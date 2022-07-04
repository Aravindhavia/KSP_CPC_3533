using KSPRecruitment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public interface IRecruitmentActivityService
    {
        Task<IEnumerable<RecruitmentActivityModel>> GetRecruitmentActivitiesAsync();
    }
}

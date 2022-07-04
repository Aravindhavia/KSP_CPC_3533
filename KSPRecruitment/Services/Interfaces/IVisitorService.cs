using KSPRecruitment.Models;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public interface IVisitorService
    {
        Task<int> CreateVisitorAsync(VisitorModel visitor);
        Task<VisitorModel> GetVisitorAsync(int visitorId);
    }
}

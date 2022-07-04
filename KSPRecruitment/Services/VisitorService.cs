using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public class VisitorService : BaseService, IVisitorService
    {
        #region " constructor "

        public VisitorService(IHttpContextAccessor session, IConfiguration configuration) : base(session, configuration)
        { }

        #endregion

        #region " properties "

        private string URLPath
        {
            get => $"{base.BaseURL}/{base.BaseVersion}/Visitor";
        }

        #endregion

        #region " commands "

        public async Task<int> CreateVisitorAsync(VisitorModel visitor)
        {
            string jsonData = JsonConvert.SerializeObject(visitor);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage message = await httpClient.PostAsync(URLPath, content);

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception(base.GetErrorMessage(response));

            if (response.Data == null) return -1;
            return System.Convert.ToInt32(response.Data);
        }

        #endregion

        #region " queries "

        public async Task<VisitorModel> GetVisitorAsync(int visitorId)
        {
            HttpResponseMessage message = await httpClient.GetAsync($"{URLPath}/{visitorId}");

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception(base.GetErrorMessage(response));

            if (response.Data == null) return null;
            VisitorModel visitor = JsonConvert.DeserializeObject<VisitorModel>(response.Data.ToString());
            return visitor;
        }

        #endregion
    }
}

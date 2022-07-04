using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public class DistrictService : BaseService, IDistrictService
    {
        #region " constructor "

        public DistrictService(IHttpContextAccessor session, IConfiguration configuration) : base(session, configuration)
        { }

        #endregion

        #region " properties "

        private string URLPath
        {
            get => $"{base.BaseURL}/{base.BaseVersion}/District";
        }

        #endregion

        #region " queries "

        public async Task<IEnumerable<DistrictModel>> GetDistrictsAsync()
        {
            HttpResponseMessage message = await httpClient.GetAsync(URLPath);

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception(GetErrorMessage(response));

            if (response.Data == null) return null;
            IEnumerable<DistrictModel> districts = JsonConvert.DeserializeObject<IEnumerable<DistrictModel>>(response.Data.ToString());
            return districts;
        }

        #endregion
    }
}

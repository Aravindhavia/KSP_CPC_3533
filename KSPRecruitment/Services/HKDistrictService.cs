using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public class HKDistrictService : BaseService, IHKDistrictService
    {
        #region " constructor "

        public HKDistrictService(IHttpContextAccessor session, IConfiguration configuration) : base(session, configuration)
        { }

        #endregion

        #region " properties "

        private string URLPath
        {
            get => $"{base.BaseURL}/{base.BaseVersion}/HKDistrict";
        }

        #endregion

        #region " queries "

        public async Task<IEnumerable<HKDistrictModel>> GetHKDistrictsAsync()
        {
            HttpResponseMessage message = await httpClient.GetAsync(URLPath);

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception(base.GetErrorMessage(response));

            if (response.Data == null) return null;
            IEnumerable<HKDistrictModel> districts = JsonConvert.DeserializeObject<IEnumerable<HKDistrictModel>>(response.Data.ToString());
            return districts;
        }

        #endregion
    }
}

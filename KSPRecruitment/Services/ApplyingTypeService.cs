using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public class ApplyingTypeService : BaseService, IApplyingTypeService
    {
        #region " constructor "

        public ApplyingTypeService(IHttpContextAccessor session, IConfiguration configuration) : base(session, configuration)
        { }

        #endregion

        #region " property "

        private string URLPath
        {
            get => $"{base.BaseURL}/{base.BaseVersion}/ApplyingType";
        }

        #endregion

        #region " queries "

        public async Task<IEnumerable<ApplyingTypeModel>> GetApplyingTypesAsync()
        {
            HttpResponseMessage message = await httpClient.GetAsync(URLPath);

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception($"{GetErrorMessage(response)}");

            if (response.Data == null) return null;

            IEnumerable<ApplyingTypeModel> applyingTypes = JsonConvert.DeserializeObject<IEnumerable<ApplyingTypeModel>>(response.Data.ToString());
            return applyingTypes;
        }

        #endregion
    }
}

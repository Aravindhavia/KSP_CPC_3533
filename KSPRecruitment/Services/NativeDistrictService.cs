﻿using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public class NativeDistrictService : BaseService, INativeDistrictService
    {
        #region " constructor "

        public NativeDistrictService(IHttpContextAccessor session, IConfiguration configuration) : base(session, configuration)
        { }

        #endregion

        #region " properties "

        private string URLPath
        {
            get => $"{base.BaseURL}/{base.BaseVersion}/NativeDistrict";
        }

        #endregion

        #region " queries "

        public async Task<IEnumerable<NativeDistrictModel>> GetNativeDistrictsAsync()
        {
            HttpResponseMessage message = await httpClient.GetAsync(URLPath);

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception(base.GetErrorMessage(response));

            if (response.Data == null) return null;
            IEnumerable<NativeDistrictModel> districts = JsonConvert.DeserializeObject<IEnumerable<NativeDistrictModel>>(response.Data.ToString());
            return districts;
        }

        #endregion
    }
}

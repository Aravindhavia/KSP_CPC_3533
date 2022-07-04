using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KSPRecruitment.Services
{
    public class PostService : BaseService, IPostService
    {
        #region " constructor "

        public PostService(IHttpContextAccessor session, IConfiguration configuration) : base(session, configuration)
        { }

        #endregion

        #region " properties "

        private string URLPath
        {
            get => $"{base.BaseURL}/{base.BaseVersion}/Post";
        }

        #endregion

        #region " queries "

        public async Task<PostModel> GetPostAsync()
        {
            HttpResponseMessage message = await httpClient.GetAsync(URLPath);

            string result = await message.Content.ReadAsStringAsync();
            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(result);
            if (!response.Succeed) throw new System.Exception(base.GetErrorMessage(response));

            if (response.Data == null) return null;
            PostModel post = JsonConvert.DeserializeObject<PostModel>(response.Data.ToString());
            return post;
        }

        #endregion
    }
}

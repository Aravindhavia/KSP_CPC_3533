using KSPRecruitment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace KSPRecruitment.Services
{
    public abstract class BaseService
    {
        #region " constructor "

        public BaseService(IHttpContextAccessor session, IConfiguration configuration)
        {
            _configuration = configuration;

            ipAddress = session.HttpContext.Connection.RemoteIpAddress;
            _session = session.HttpContext.Session;
        }

        #endregion

        #region " definitions "

        private readonly IConfiguration _configuration;

        protected readonly IPAddress ipAddress;
        private readonly ISession _session;

        private HttpClient _httpClient;

        #endregion

        #region " properties "

        protected string BaseURL
        {
            get
            {
                return _configuration["AppSettings.WebAPIURL"];
            }
        }

        protected string BaseVersion
        {
            get => "v1";
        }

        protected HttpClient httpClient
        {
            get
            {
                if (string.IsNullOrEmpty(JWTToken))
                {
                    _httpClient = new HttpClient();
                }
                else
                {
                    _httpClient = new HttpClient();
                    AuthenticationHeaderValue authHeader = new AuthenticationHeaderValue("bearer", JWTToken);
                    _httpClient.DefaultRequestHeaders.Authorization = authHeader;
                }

                return _httpClient;
            }
        }

        private string JWTToken
        {
            get { return _session.GetString("oToken"); }
        }

        protected JsonSerializerSettings JsonSetting
        {
            get
            {
                return new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
            }
        }

        #endregion

        #region " methods "

        protected string GetErrorMessage(APIResponse response)
        {
            if ((response.Errors != null && response.Errors.Count > 0) || (response.Message == null || string.IsNullOrEmpty(response.Message)))
            {
                if (response.Errors == null || response.Errors.Count == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return string.Join("", response.Errors.ToArray());
                }
            }
            else
            {
                return response.Message;
            }
        }

        #endregion
    }
}

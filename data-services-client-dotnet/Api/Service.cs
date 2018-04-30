using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Quadient.DataServices.Api.User;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public abstract class Service
    {               
        private readonly int TokenExpiration = 8 * 60 * 1000;
        private readonly HttpClient _httpClient;
        private readonly HttpClient _authClient;
        protected ICredentials Credentials {get;}
        protected IConfiguration Configuration {get;}

        protected Service(ICredentials credentials, IConfiguration configuration)
        {
            if (_httpClient != null) return;
            Credentials = credentials;
            Configuration = configuration;
            
            var handler = new HttpClientHandler
            {
                PreAuthenticate = true,
                ClientCertificateOptions = ClientCertificateOption.Automatic
            };

            _httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMinutes(Constants.ServiceTimeout),
                BaseAddress = GetBaseAddress()
            };
            _httpClient.DefaultRequestHeaders.Add("User-Agent", configuration.UserAgent);

            _authClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromMinutes(Constants.ServiceTimeout),
                BaseAddress = GetBaseAddress(true)
            };
            _authClient.DefaultRequestHeaders.Add("User-Agent", configuration.UserAgent);
        }

        protected Service(ICredentials credentials): this(credentials, new Configuration())
        {}

        private ISession _session;
        private DateTime _expiration;
        private async Task<ISession> GetSession()
        {           

            if (_session != null && _expiration > DateTime.Now) return _session;
            AuthToken request = null;
            if (Configuration.IsAdmin)
            {
                request = new DataServicesToken(Credentials);
            } else
            {
                request = new QuadientCloudToken(Credentials);
            }
            using (var httpRequest = new HttpRequestMessage(request.Method, request.ServicePath))
            {
                httpRequest.Content = new StringContent(SerializeObject(request.Content), Encoding.UTF8, "application/json");
                using (var result = await _authClient.SendAsync(httpRequest))
                {
                    result.EnsureSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    _session = DeserializeObject<Session>(resultContent);
                }
            }
            if (Configuration.IsAdmin) _session.Token = _session.AccessToken;
            _expiration = DateTime.Now.AddMilliseconds(TokenExpiration);
            return _session;
        }

        protected async Task<R> Execute<T,R>(IRequest<T,R> request, IDictionary<string, string> headers = null)
        {
            var session = await GetSession();
            using (var httpRequest = new HttpRequestMessage(request.Method, request.ServicePath))
            {
                httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                if (headers != null)
                {
                    foreach(var key in headers.Keys)
                    {
                        httpRequest.Headers.TryAddWithoutValidation(key, headers[key]);
                    }
                }
                if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put)
                {
                    httpRequest.Content = new StringContent(SerializeObject(request.Content), Encoding.UTF8, "application/json");
                }
                using (var result = await _httpClient.SendAsync(httpRequest))
                {
                    result.EnsureSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<R>(resultContent);
                }
            }
        }

        private Uri GetBaseAddress(bool isCloud = false)
        {
            var address = $"https://data.quadientcloud.{(Credentials.Region == Region.US ? "com": "eu")}/";
            if (isCloud)
            {
                if (!string.IsNullOrWhiteSpace(Configuration.QuadientCloudAddress))
                {
                    address = Configuration.QuadientCloudAddress;
                }
                else if (!string.IsNullOrWhiteSpace(Credentials.Company))
                {
                    address = $"https://{Credentials.Company}.quadientcloud.{(Credentials.Region == Region.US ? "com": "eu")}/";
                }
                else
                {
                    Configuration.IsAdmin = true;
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Configuration.DataServicesAddress))
                {
                    address = Configuration.DataServicesAddress;
                }
            }
            return new Uri(address);
        }

        private static string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        private static T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}

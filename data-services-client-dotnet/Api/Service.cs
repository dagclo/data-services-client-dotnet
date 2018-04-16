using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public interface IService
    {
        Task<T> Get<T>();
        Task Delete();
        Task<R> Post<T, R>(T body);
        Task<T> Post<T>(Dictionary<string, string> body);
        Task<T> Post<T>(MultipartFormDataContent body);
        Task<R> Put<T, R>(T body);
    }

    public abstract class Service : IService
    {
        private IConfiguration _configuration;
        private ICredentials _credentials;
        private HttpClient _httpClient;
        protected string ServicePath {private get; set;}

        public void Initialize(ICredentials credentials, IConfiguration configuration)
        {
            if (_httpClient == null)
            {
                _credentials = credentials;
                _configuration = configuration;
                var handler = new HttpClientHandler
                {
                    PreAuthenticate = true,
                    ClientCertificateOptions = ClientCertificateOption.Automatic
                };
                _httpClient = new HttpClient(handler)
                {
                    Timeout = TimeSpan.FromMinutes(Constants.ServiceTimeout),
                    BaseAddress = new Uri(configuration.BaseAddress)
                };
            }
        }

        private Session _session;
        private async Task<Session> GetSession()
        {
            return _session ?? (_session = await Post<ICredentials, Session>(_configuration.CloudAddress, _credentials));
        }

        public async Task<T> Get<T>()
        {
            var session = await GetSession();
            using (var request = new HttpRequestMessage(HttpMethod.Get, ServicePath))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<T>(resultContent);
                }
            }
        }

        private async Task<T> Send<T>(string servicePath, HttpContent content, HttpMethod method)
        {
            var session = await GetSession();
            using (var request = new HttpRequestMessage(method, servicePath))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                request.Content = content;
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<T>(resultContent);
                }
            }
        }

        public async Task Delete()
        {
            var session = await GetSession();
            using (var request = new HttpRequestMessage(HttpMethod.Delete, ServicePath))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                request.Content = new StringContent("", Encoding.UTF8, "application/json");
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureSuccessStatusCode();
                }
            }
        }

        protected async Task<R> Post<T, R>(string servicePath, T body)
        {
            return await Send<R>(servicePath, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Post);
        }

        public async Task<R> Post<T, R>(T body)
        {
            return await Send<R>(ServicePath, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Post);
        }

        public async Task<T> Post<T>(Dictionary<string, string> body)
        {
            return await Send<T>(ServicePath, new FormUrlEncodedContent(body), HttpMethod.Post);
        }

        public async Task<T> Post<T>(MultipartFormDataContent body)
        {
            return await Send<T>(ServicePath, body, HttpMethod.Post);
        }

        public async Task<R> Put<T, R>(T body)
        {
            return await Send<R>(ServicePath, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Put);
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

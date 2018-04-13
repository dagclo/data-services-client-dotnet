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
        Task<T> Get<T>(string uri);
        Task Delete(string uri);
        Task<R> Post<T, R>(string uri, T body);
        Task<T> Post<T>(string uri, Dictionary<string, string> body);
        Task<T> Post<T>(string uri, MultipartFormDataContent body);
        Task<R> Put<T, R>(string uri, T body);
    }

    internal class Service: IService
    {
        readonly IConfiguration _configuration;
        readonly ICredentials _credentials;
        readonly HttpClient _httpClient;

        internal Service(ICredentials credentials, IConfiguration configuration)
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

        private Session _session;
        private async Task<Session> GetSession()
        {
            return _session ?? (_session = await Post<ICredentials, Session>(_configuration.CloudAddress, _credentials));
        }

        public async Task<T> Get<T>(string uri)
        {
            var session = await GetSession();
            using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureNessSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<T>(resultContent);
                }
            }
        }

        async Task<T> Post<T>(string uri, HttpContent content, HttpMethod method)
        {
            var session = await GetSession();
            using (var request = new HttpRequestMessage(method, uri))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                request.Content = content;
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureNessSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<T>(resultContent);
                }
            }
        }

        public async Task Delete(string uri)
        {
            var session = await GetSession();
            using (var request = new HttpRequestMessage(HttpMethod.Delete, uri))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", session.Token);
                request.Content = new StringContent("", Encoding.UTF8, "application/json");
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureNessSuccessStatusCode();
                }
            }
        }

        public async Task<R> Post<T, R>(string uri, T body)
        {
            return await Post<R>(uri, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Post);
        }

        public async Task<T> Post<T>(string uri, Dictionary<string, string> body)
        {
            return await Post<T>(uri, new FormUrlEncodedContent(body), HttpMethod.Post);
        }

        public async Task<T> Post<T>(string uri, MultipartFormDataContent body)
        {
            return await Post<T>(uri, body, HttpMethod.Post);
        }

        public async Task<R> Put<T, R>(string uri, T body)
        {
            return await Post<R>(uri, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Put);
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

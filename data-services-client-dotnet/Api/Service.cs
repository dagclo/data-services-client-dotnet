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
    internal abstract class Service
    {
        readonly Session _session;
        readonly HttpClient _httpClient;

        protected Service(Session session, Configuration configuration)
        {
            _session = session;
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

        protected async Task<T> Get<T>(string uri)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _session.Token);
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureNessSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<T>(resultContent);
                }
            }
        }

        async Task<T> Send<T>(string uri, HttpContent content, HttpMethod method)
        {
            using (var request = new HttpRequestMessage(method, uri))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _session.Token);
                request.Content = content;
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureNessSuccessStatusCode();
                    var resultContent = await result.Content.ReadAsStringAsync();
                    return DeserializeObject<T>(resultContent);
                }
            }
        }

        protected async Task Delete(string uri)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Delete, uri))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _session.Token);
                request.Content = new StringContent("", Encoding.UTF8, "application/json");
                using (var result = await _httpClient.SendAsync(request))
                {
                    result.EnsureNessSuccessStatusCode();
                }
            }
        }

        protected async Task<R> Post<T, R>(string uri, T body)
        {
            return await Send<R>(uri, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Post);
        }

        protected async Task<T> Post<T>(string uri, Dictionary<string, string> body)
        {
            return await Send<T>(uri, new FormUrlEncodedContent(body), HttpMethod.Post);
        }

        protected async Task<T> Post<T>(string uri, MultipartFormDataContent body)
        {
            return await Send<T>(uri, body, HttpMethod.Post);
        }

        protected async Task<R> Put<T, R>(string uri, T body)
        {
            return await Send<R>(uri, new StringContent(SerializeObject(body), Encoding.UTF8, "application/json"), HttpMethod.Put);
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

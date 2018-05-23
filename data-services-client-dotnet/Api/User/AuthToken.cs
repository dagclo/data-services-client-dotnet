using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api.User
{
    public abstract class AuthToken : IRequest<ICredentials, Session>
    {
        public string ServicePath { get; set; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public ICredentials Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        internal abstract HttpContent GetHttpContent();
    }

    public class QuadientCloudToken : AuthToken
    {
        public QuadientCloudToken(QuadientCloudCredentials credentials)
        {
            ServicePath = "api/query/Users/AuthTokenByLogin";
            Content = new QuadientCloudCredentials
            {
                Username = credentials.Username,
                Password = credentials.Password
            };
        }

        internal override HttpContent GetHttpContent()
        {
            return null;
        }
    }

    public class DataServicesToken : AuthToken
    {
        public DataServicesToken(AdminCredentials credentials)
        {
            ServicePath = "oauth/token";
            Content = new AdminCredentials
            {
                Username = credentials.Username,
                Password = credentials.Password
            };
        }

        internal override HttpContent GetHttpContent()
        {
            var adminCredentials = (AdminCredentials)Content;
            return new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", adminCredentials.Username),
                new KeyValuePair<string, string>("password", adminCredentials.Password)
            });
        }
    }

    public class DataServicesApiKeyToken : AuthToken
    {
        public DataServicesApiKeyToken(AdminApiKey credentials)
        {
            ServicePath = "oauth/token";
            Content = new AdminApiKey
            {
                KeyId = credentials.KeyId,
                Secret = credentials.Secret
            };
        }

        internal override HttpContent GetHttpContent()
        {
            var apiKey = (AdminApiKey) Content;
            return new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", apiKey.KeyId),
                new KeyValuePair<string, string>("client_secret", apiKey.Secret)
            });
        }
    }
}

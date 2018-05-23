using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api.User
{
    public abstract class AuthToken : IRequest<IAuthCredentials, Session>
    {
        public string ServicePath { get; set; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public IAuthCredentials Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public abstract HttpContent GetContent();
    }

    public class QuadientCloudToken : AuthToken
    {
        public QuadientCloudToken(ICredentials credentials)
        {
            ServicePath = "api/query/Users/AuthTokenByLogin";
            Content = new UserCredentials
            {
                Email = credentials.Username,
                Password = credentials.Password
            };
        }

        public override HttpContent GetContent()
        {
            return null;
        }
    }

    public class DataServicesToken : AuthToken
    {
        public DataServicesToken(ICredentials credentials)
        {
            ServicePath = "oauth/token";
            Content = new AdminCredentials
            {
                Username = credentials.Username,
                Password = credentials.Password
            };
        }

        public override HttpContent GetContent()
        {
            return new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", ((AdminCredentials) Content).Username),
                new KeyValuePair<string, string>("password", Content.Password)
            });
        }
    }
}

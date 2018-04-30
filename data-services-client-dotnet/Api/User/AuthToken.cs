using System.Net.Http;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api.User
{
    public abstract class AuthToken: IRequest<IAuthCredentials, Session>
    {
        public string ServicePath {get;set;}
        public HttpMethod Method {get;} = HttpMethod.Post;
        public IAuthCredentials Content { get; set; }
    }

    public class QuadientCloudToken: AuthToken
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
    }

    public class DataServicesToken: AuthToken
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
    }
}

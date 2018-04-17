using System.Net.Http;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api.User
{
    public class AuthToken: IRequest<ICredentials, Session>
    {
        public string ServicePath {get; private set;} = "api/query/Users/AuthTokenByLogin";
        private readonly string AdminServicePath = "/oauth/token";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public ICredentials Content { get; set; }

        public AuthToken(ICredentials credentials, bool isAdmin = false)
        {
            if (isAdmin)
            {
                ServicePath = AdminServicePath;
            }
            Content = credentials;
        }
    }
}

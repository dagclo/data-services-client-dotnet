using System.Net.Http;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api.User
{
    public class AuthToken: IRequest<IAuthCredentials, Session>
    {
        public string ServicePath {get; private set;} = "api/query/Users/AuthTokenByLogin";
        private readonly string AdminServicePath = "/oauth/token";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public IAuthCredentials Content { get; set; }

        public AuthToken(ICredentials credentials, bool isAdmin = false)
        {
            if (isAdmin)
            {
                ServicePath = AdminServicePath;
                Content = new AdminCredentials
                {
                    Username = credentials.Username,
                    Password = credentials.Password
                };
            } else
            {
                Content = new UserCredentials 
                {
                    Email = credentials.Username,
                    Password = credentials.Password
                };
            }
        }
    }
}

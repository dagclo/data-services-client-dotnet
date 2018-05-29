
namespace Quadient.DataServices.Model
{
    public enum Region
    {
        US = 0,
        EU = 1
    }

    public interface ICredentials
    {
    }

    public class QuadientCloudCredentials: ICredentials
    {
        public string Company { get; set; }
        public string Username {get; set;}
        public string Password {get; set;}

        public QuadientCloudCredentials()
        {
        }

        public QuadientCloudCredentials(string company, string username, string password)
        {
            Company = company;
            Username = username;
            Password = password;
        }
    }

    public class AdminCredentials: ICredentials
    {
        public string Username {get; set;}
        public string Password {get; set;}

        public AdminCredentials()
        {

        }

        public AdminCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public class AdminApiKey : ICredentials
    {
        public string KeyId { get; set; }
        public string Secret { get; set; }

        public AdminApiKey()
        {
        }

        public AdminApiKey(string keyId, string secret)
        {
            KeyId = keyId;
            Secret = secret;
        }
    }

    public interface ISessionToken
    {
        string Token { get; set; }
    }

    public class SessionToken : ISessionToken
    {
        public string Token { get; set; }

        public SessionToken()
        {
        }

        public SessionToken(string token)
        {
            Token = token;
        }
    }
}

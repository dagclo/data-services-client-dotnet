
namespace Quadient.DataServices.Model
{
    public enum Region
    {
        US = 0,
        EU = 1
    }

    public interface IAuthCredentials
    {
        string Password {get; set;}
    }

    public class UserCredentials: IAuthCredentials
    {
        public string Email {get; set;}
        public string Password {get; set;}
    }

    public class AdminCredentials: IAuthCredentials
    {
        public string Username {get; set;}
        public string Password {get; set;}
    }

    public interface ICredentialsRegion
    {
        Region Region { get; set; }
    }

    public interface ICredentials : ICredentialsRegion
    {
        string Company {get; set;}
        string Username {get; set;}
        string Password {get; set;}
    }

    public class Credentials: ICredentials
    {
        public Region Region {get;set;} = Region.US;
        public string Company {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
    }

    public interface ISessionToken : ICredentialsRegion
    {
        string Token { get; set; }
    }

    public class SessionToken : ISessionToken
    {
        public Region Region { get; set; } = Region.US;
        public string Token { get; set; }
    }
}

using Newtonsoft.Json;

namespace Quadient.DataServices.Model
{
	public interface ISession
	{
		string Token { get; set; }
		string AccessToken { get; set; }
	}

	public class Session : ISession
	{
		[JsonProperty(PropertyName = "token")]
		public string Token { get; set; }
		[JsonProperty(PropertyName = "access_token")]
		public string AccessToken { get; set; }
	}
}

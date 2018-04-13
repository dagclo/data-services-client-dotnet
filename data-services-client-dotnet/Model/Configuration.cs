
namespace Quadient.DataServices.Model
{
    public interface IConfiguration
    {
        string BaseAddress { get; set; }
        string CloudAddress { get; set; }
        string UserAgent { get; set; }
    }

    public class Configuration: IConfiguration
    {
        public string BaseAddress { get; set; }
        public string CloudAddress { get; set; }
        public string UserAgent { get; set; } = "data-services-client-dotnet";
    }
}

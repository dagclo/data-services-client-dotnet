
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Model
{
    public interface IConfiguration
    {
        string DataServicesAddress { get; set; }
        string QuadientCloudAddress { get; set; }
        bool IsAdmin {get; set;}
        string UserAgent { get; }
    }

    public class Configuration: IConfiguration
    {
        public string DataServicesAddress { get; set; }
        public string QuadientCloudAddress { get; set; }
        public bool IsAdmin {get; set;}
        public string UserAgent { get; } = Constants.Origin;
    }
}

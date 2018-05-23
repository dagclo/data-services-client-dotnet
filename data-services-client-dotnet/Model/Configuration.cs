
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Model
{
    public interface IConfiguration
    {
        string DataServicesAddress { get; set; }
        string QuadientCloudAddress { get; set; }
        string UserAgent { get; }
        Region Region { get; set; }
    }

    public class Configuration: IConfiguration
    {
        public string DataServicesAddress { get; set; }
        public string QuadientCloudAddress { get; set; }
        public string UserAgent { get; } = Constants.Origin;
        public Region Region { get; set; } = Region.US;
    }
}

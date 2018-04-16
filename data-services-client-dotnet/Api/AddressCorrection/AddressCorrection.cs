using System.Collections.Generic;
using System.Threading.Tasks;
using Quadient.DataServices.Model.AddressCorrection;

namespace Quadient.DataServices.Api.AddressCorrection
{
    public class AddressCorrection: Service, IRequest<CorrectionRequest, CorrectionResponse>
    {
        private string ServicePath = "address-correction/v1";

        public List<CorrectionRequestAddress> Addresses { get; set; }

        public CorrectionRequestConfiguration Configuration { get; set; }

        public string JobID {get;}

        public AddressCorrection()
        {
            base.ServicePath = ServicePath;
        }

        public AddressCorrection(List<CorrectionRequestAddress> addresses): this()
        {
            Addresses = addresses;
        }

        public AddressCorrection(List<CorrectionRequestAddress> addresses, CorrectionRequestConfiguration configuration): this()
        {
            Addresses = addresses;
            Configuration = configuration;
        }

        public async Task<IResponse<CorrectionResponse>> Invoke()
        {
            return await Post<CorrectionRequest, CorrectionResponse>(ServicePath, new CorrectionRequest
            {
               Addresses = Addresses,
               Configuration = Configuration
            });
        }
    }
}

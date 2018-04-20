using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Address;

namespace Quadient.DataServices.Api.Address
{
    public class AddressCorrection: IRequest<CorrectionRequest, CorrectionResponse>
    {
        public string ServicePath {get;} = "services/address-correction/v1/correct";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public CorrectionRequest Content { get; set; }

        public AddressCorrection() {}

        public AddressCorrection(CorrectionRequestConfiguration configuration, List<CorrectionRequestAddress> addresses)
        {
            Content = new CorrectionRequest(addresses, configuration);
        }

        public AddressCorrection(List<CorrectionRequestAddress> addresses)
        {
            Content = new CorrectionRequest(addresses);
        }

        public AddressCorrection(CorrectionRequest content)
        {
            Content = content;
        }
    }
}

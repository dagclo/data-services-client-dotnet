using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Address;

namespace Quadient.DataServices.Api.Address
{
    /// <summary>
    /// Processes an array of addresses using the Address Correction engine.
    /// </summary>
    public class AddressCorrection : IRequest<CorrectionResponse>
    {
        public string ServicePath { get; } = "services/address-correction/v1/correct";
        public HttpMethod Method => HttpMethod.Post;
        public IDictionary<string, string> QueryStringParams { get; }
        private CorrectionRequest Content { get; set; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }

        public AddressCorrection()
        {
        }

        /// <summary>
        /// Processes an array of addresses using the Address Correction engine.
        /// </summary>
        /// <param name="configuration">The configuration of the correction request.</param>
        /// <param name="addresses"></param>
        public AddressCorrection(CorrectionRequestConfiguration configuration, List<CorrectionRequestAddress> addresses)
        {
            Content = new CorrectionRequest(addresses, configuration);
        }

        /// <summary>
        /// Processes an array of addresses using the Address Correction engine.
        /// </summary>
        /// <param name="addresses"></param>
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

using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    /// <summary>
    /// Sets a price for an aspect of a service 
    /// </summary>
    public class SaveServicePrices : IRequest<Prices>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public PriceSettingRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
		public IDictionary<string, string> Headers { get; }

        /// <summary>
        /// Sets a price for an aspect of a service 
        /// </summary>
        /// <param name="service">The service to set pricing details for.</param>
        /// <param name="request">The details of the job, session or other activity for which the calculation is requested.</param>
        public SaveServicePrices(string service, PriceSettingRequest request)
        {
            ServicePath = $"pricebook/v1/prices/{service}";
            Content = request;
        }
    }
}

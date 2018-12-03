using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    /// <summary>
    /// Allows updating the aspects of a particular price line 
    /// </summary>
    public class UpdateServicePriceLine : IRequest<object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Put;
        public PriceUpdate Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }

        /// <summary>
        /// Allows updating the aspects of a particular price line 
        /// </summary>
        /// <param name="id"></param>
        public UpdateServicePriceLine(string id)
        {
            ServicePath = $"pricebook/v1/prices/pricelines/{id}";
        }

        /// <summary>
        /// Allows updating the aspects of a particular price line 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="priceUpdate"></param>
        public UpdateServicePriceLine(string id, PriceUpdate priceUpdate) : this(id)
        {
            Content = priceUpdate;
        }
    }
}

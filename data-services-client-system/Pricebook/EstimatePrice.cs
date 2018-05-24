using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    public class EstimatePrice : IRequest<EstimateDetails, CalculateResponse>
    {
        public string ServicePath { get; } = "pricebook/v1/estimate";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public EstimateDetails Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public EstimatePrice()
        {
        }

        public EstimatePrice(EstimateDetails estimateDetails)
        {
            Content = estimateDetails;
        }
    }
}

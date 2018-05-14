using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Quadient.DataServices.Model.Pricebook;

namespace Quadient.DataServices.Api.Pricebook
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

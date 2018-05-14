using Quadient.DataServices.Model.Pricebook;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Pricebook
{
    public class CalculatePrice : IRequest<MeteringDetails, CalculateResponse>
    {
        public string ServicePath { get; } = "pricebook/v1/calculate";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public MeteringDetails Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public CalculatePrice()
        {

        }

        public CalculatePrice(MeteringDetails meteringDetails)
        {
            Content = meteringDetails;
        }
    }
}

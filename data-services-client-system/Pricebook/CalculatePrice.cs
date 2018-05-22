using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
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

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api.Pricebook
{
    public class SaveServicePrice : IRequest<PriceLineRequest, Id>
    {
        public string ServicePath { get; } = "pricebook/v1/prices/pricelines/";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public PriceLineRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public SaveServicePrice()
        {
        }

        public SaveServicePrice(string id)
        {
            ServicePath = $"pricebook/v1/prices/pricelines/{id}";
        }
    }
}

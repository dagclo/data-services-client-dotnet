using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    /// <summary>
    /// Returns a pricing estimate for a job, session or other activity that involves Data Services.
    /// </summary>
    public class EstimatePrice : IRequest<CalculateResponse>
    {
        public string ServicePath { get; } = "pricebook/v1/estimate";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public EstimateDetails Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }

        /// <summary>
        /// Returns a pricing estimate for a job, session or other activity that involves Data Services.
        /// </summary>
        public EstimatePrice()
        {
        }

        /// <summary>
        /// Returns a pricing estimate for a job, session or other activity that involves Data Services.
        /// </summary>
        /// <param name="estimateDetails">The details of the job, session or other activity for which the estimate is requested.</param>
        public EstimatePrice(EstimateDetails estimateDetails)
        {
            Content = estimateDetails;
        }
    }
}

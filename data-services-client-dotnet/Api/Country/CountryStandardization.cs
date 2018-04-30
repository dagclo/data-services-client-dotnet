using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Country;

namespace Quadient.DataServices.Api.Country
{
    public class CountryStandardization: IRequest<CountryStandardizationRequest, CountryStandardizationResponse>
    {
        public string ServicePath {get;} = "services/country-standardization/v1/find";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public CountryStandardizationRequest Content { get; set; }

        public CountryStandardization() {}

        public CountryStandardization(CountryStandardizationRequest content)
        {
            Content = content;
        }

        public CountryStandardization(List<string> countries)
        {
            Content = new CountryStandardizationRequest("en", countries);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Name;

namespace Quadient.DataServices.Api.Name
{
    public class NameValidation: IRequest<ParseRequest, ParseResponse>
    {
        public string ServicePath {get;} = "/services/name-validation/v1/parse";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public ParseRequest Content { get; set; }

        public NameValidation() {}

        public NameValidation(ParseRequest content)
        {
            Content = content;
        }

        public NameValidation(ParseRequestConfiguration configuration, List<ParseRequestItem> records)
        {
            Content = new ParseRequest(configuration, records);
        }

        public NameValidation(ParseRequestConfiguration configuration, IEnumerable<string> names)
        {
            var records = names.Select(name => new ParseRequestItem
                {
                    UnstructuredName = name
                })
                .ToList();
            Content = new ParseRequest(configuration, records);
        }
    }
}

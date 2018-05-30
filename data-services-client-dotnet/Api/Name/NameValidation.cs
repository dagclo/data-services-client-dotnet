using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Name;

namespace Quadient.DataServices.Api.Name
{
    /// <summary>
    /// Takes name information and tries to parse it. This parser is usually most useful as a simple utility function when one or more unstructured name strings has to be split into a structured set of fields with given name, family name, and so forth.
    /// </summary>
    public class NameValidation: IRequest<ParseRequest, ParseResponse>
    {
        public string ServicePath {get;} = "services/name-validation/v2/parse";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public ParseRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Takes name information and tries to parse it. This parser is usually most useful as a simple utility function when one or more unstructured name strings has to be split into a structured set of fields with given name, family name, and so forth.
        /// </summary>
        public NameValidation() {}

        /// <summary>
        /// Takes name information and tries to parse it. This parser is usually most useful as a simple utility function when one or more unstructured name strings has to be split into a structured set of fields with given name, family name, and so forth.
        /// </summary>
        /// <param name="content">The name parsing request body.</param>
        public NameValidation(ParseRequest content)
        {
            Content = content;
        }

        /// <summary>
        /// Takes name information and tries to parse it. This parser is usually most useful as a simple utility function when one or more unstructured name strings has to be split into a structured set of fields with given name, family name, and so forth.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="records"></param>
        public NameValidation(ParseRequestConfiguration configuration, List<ParseRequestItem> records)
        {
            Content = new ParseRequest(configuration, records);
        }

        /// <summary>
        /// Takes name information and tries to parse it. This parser is usually most useful as a simple utility function when one or more unstructured name strings has to be split into a structured set of fields with given name, family name, and so forth.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="names"></param>
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

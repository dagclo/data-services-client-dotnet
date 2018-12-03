using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Quadient.DataServices.Api.User;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    internal class HeaderDecorationServiceCaller : IServiceCaller
    {
        private readonly IServiceCaller _innerCaller;
        private readonly IDictionary<string, string> _headers;
        public HeaderDecorationServiceCaller(IServiceCaller innerCaller, IDictionary<string, string> headers)
        {
            _innerCaller = innerCaller;
            _headers = headers;
        }
        public Task<R> Execute<R>(IRequest<R> request)
        {
            var req = new HeaderDecorationRequest<R>(request, _headers);
            return _innerCaller.Execute(request);
        }

        public Task<R> Execute<R>(IRequest<R> request, CancellationToken cancellationToken)
        {
            var req = new HeaderDecorationRequest<R>(request, _headers);
            return _innerCaller.Execute(req);
        }
    }

    internal class HeaderDecorationRequest<R> : IRequest<R>
    {
        private readonly IRequest<R> _innerRequest;
        private readonly IDictionary<string, string> _headers;

        public HeaderDecorationRequest(IRequest<R> innerRequest, IDictionary<string, string> headers)
        {
            _innerRequest = innerRequest;
            _headers = headers;
        }

        IDictionary<string, string> IRequest<R>.Headers
        {
            get
            {
                var innerHeaders = _innerRequest.Headers;
                if (innerHeaders == null)
                    return _headers;
                var returnedHeaders = new Dictionary<string, string>(innerHeaders);
                foreach (var pair in _headers)
                {
                    if (!returnedHeaders.ContainsKey(pair.Key))
                        returnedHeaders[pair.Key] = pair.Value;
                }
                return returnedHeaders;
            }
        }

        string IRequest<R>.ServicePath => _innerRequest.ServicePath;

        HttpMethod IRequest<R>.Method => _innerRequest.Method;

        object IRequest<R>.Body => _innerRequest.Body;


        IDictionary<string, string> IRequest<R>.QueryStringParams => _innerRequest.QueryStringParams;
    }
}

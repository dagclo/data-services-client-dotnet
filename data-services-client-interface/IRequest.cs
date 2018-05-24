using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api
{
    public interface IRequest<T,R>
    {
        string ServicePath {get;}
        HttpMethod Method {get;}
        T Content {get; set;}
        IDictionary<string, string> QueryStringParams { get; }
    }
}

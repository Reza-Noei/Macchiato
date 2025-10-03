using Mediator.Net.Contracts;
using System.Net;

namespace Macchiato.Application.Dtos
{
    public class Response<T> : IResponse
    {
        public T Data { get; set; }
        
        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }        
    }
}

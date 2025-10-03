using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macchiato.Domain.Responses
{
    public class CustomResponse : HttpResponse
    {
        public override string ContentType { get; set; }

        public CustomResponse(string contentType)
        {
            ContentType = contentType;
        }
    }
}

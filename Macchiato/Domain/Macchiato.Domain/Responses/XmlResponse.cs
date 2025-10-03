namespace Macchiato.Domain.Responses
{
    // XML response
    public class XmlResponse : HttpResponse
    {
        public override string ContentType => "application/xml";
    }
}

namespace Macchiato.Domain.Requests
{
    public sealed class RawXmlRequestBody : RawRequestBody
    {
        public override string ContentType => "application/xml";
    }
}

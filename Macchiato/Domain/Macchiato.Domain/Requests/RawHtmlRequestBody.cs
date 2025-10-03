namespace Macchiato.Domain.Requests
{
    public sealed class RawHtmlRequestBody : RawRequestBody
    {
        public override string ContentType => "text/html";
    }
}

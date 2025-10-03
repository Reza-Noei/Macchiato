namespace Macchiato.Domain.Requests
{
    public sealed class RawJavaScriptRequestBody : RawRequestBody
    {
        public override string ContentType => "application/javascript";
    }
}
